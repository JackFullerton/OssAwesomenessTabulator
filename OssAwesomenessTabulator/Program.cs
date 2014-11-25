﻿using System;
using System.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;
using OssAwesomenessTabulator.Data;
using System.Linq;
using Microsoft.WindowsAzure;
using System.Net;
using Octokit;
using Microsoft.WindowsAzure.Storage.Shared.Protocol;
using System.Collections.Generic;


namespace OssAwesomenessTabulator
{
    class Program
    {
        static void Main()
        {
            System.Diagnostics.Trace.TraceInformation("Starting");
            Console.Out.WriteLine("Starting");
            Execute();
            // JobHost host = new JobHost();
            // host.RunAndBlock();            
            Console.Out.WriteLine("Done");
            System.Diagnostics.Trace.TraceInformation("Done.");
        }

        private static void Execute()
        {
            // Get Data
            OssData data = Functions.GetData(getConfig());

            // Write to Azure blob
            Console.Out.WriteLine("Opening Azure Blob Store");
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConfigurationManager.ConnectionStrings["AzureWebJobsStorage"].ConnectionString); 
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Set CORS
            ServiceProperties properties = blobClient.GetServiceProperties();
            properties.Cors = new CorsProperties();
            properties.Cors.CorsRules.Add(new CorsRule()
            {
                AllowedHeaders = new List<string>() { "*" },
                AllowedMethods = CorsHttpMethods.Put | CorsHttpMethods.Get | CorsHttpMethods.Head | CorsHttpMethods.Post,
                AllowedOrigins = new List<string>() { "*" },
                ExposedHeaders = new List<string>() { "*" },
                MaxAgeInSeconds = 1800 // Make last 30 minutes in cache
            });
            blobClient.SetServiceProperties(properties);
            Console.Out.WriteLine("CORS Updated");

            CloudBlobContainer container = blobClient.GetContainerReference("output");
            // Make sure output container exists and it is publicly accessible
            container.CreateIfNotExists();
            container.SetPermissions(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });

            // The full monty
            Console.Out.WriteLine("Writing projects_all.json");
            writeJsonBlob(container, data, "projects_all.json");
            // Main file
            Console.Out.WriteLine("Writing projects.json");
            writeJsonBlob(container, data.Active(), "projects.json");
            // Top 50
            Console.Out.WriteLine("Writing projects_top.json");
            writeJsonBlob(container, data.Top(50), "projects_top.json");
        }

        private static void writeJsonBlob(CloudBlobContainer container, OssData data, string filename)
        {
            CloudBlockBlob blob = container.GetBlockBlobReference(filename);
            blob.Properties.ContentType = "application/json";
            using (Stream blobStream = blob.OpenWrite())
            {
                Functions.Write(blobStream, data);
            }
        }
 
        private static Config getConfig()
        {
            Credentials creds = null;
            
            if (ConfigurationManager.ConnectionStrings["GitHubID"] != null)
            {
                creds = new Credentials(ConfigurationManager.ConnectionStrings["GitHubID"].ConnectionString, ConfigurationManager.ConnectionStrings["GitHubPassword"].ConnectionString);
            }
            string url = CloudConfigurationManager.GetSetting("ConfigBaseURL");
            if (String.IsNullOrEmpty(url))
            {
                // Default to Microsoft config.
                url = "https://raw.githubusercontent.com/Microsoft/microsoft.github.io/master/data";
            }
            String[] users = null;
            if (ConfigurationManager.ConnectionStrings["CodePlexUsers"] != null)
            {
                users = ConfigurationManager.ConnectionStrings["CodePlexUsers"].ConnectionString.Split(';');
            }

            return Config.LoadFromWeb(url, creds, users);
        }
    }
}
