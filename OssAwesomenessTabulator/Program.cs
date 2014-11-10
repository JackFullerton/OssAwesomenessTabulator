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
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConfigurationManager.ConnectionStrings["AzureWebJobsStorage"].ConnectionString); 
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference("output");
            container.CreateIfNotExists();
            
            // Full file
            Console.Out.WriteLine("Writing projects.json");
            CloudBlockBlob blob = container.GetBlockBlobReference("projects.json");
            using (Stream blobStream = blob.OpenWrite())
            {
                Functions.Write(blobStream, data);
            }
            // Top 50
            Console.Out.WriteLine("Writing projects_top.json");
            CloudBlockBlob topBlob = container.GetBlockBlobReference("projects_top.json");
            using (Stream blobStream = topBlob.OpenWrite())
            {
                Functions.Write(blobStream, data.Top(50));
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

            return Config.LoadFromWeb(url, creds);
        }
    }
}
