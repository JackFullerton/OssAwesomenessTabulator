﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace OssAwesomenessTabulator.Data
{
    [DataContract]
    public class OssData
    {
        private List<Project> _projects = new List<Project>();
        private HashSet<string> _orgs = new HashSet<string>();
        
        // Included in JSON
        [DataMember]
        public DateTimeOffset LastUpdated { get { return DateTimeOffset.Now; } }

        [DataMember]
        public SummaryStats Summary { get; set; }

        [DataMember]
        public Project[] Projects
        {
            get
            {
                // Return the projects in order of awesomeness then last commit date
                return _projects
                    .OrderByDescending(project => project.Awesomeness)
                    .ThenByDescending(project => project.CommitLast)
                    .ToArray<Project>();
            }
        }

        public void AddProject(Project project)
        {
            _projects.Add(project);
            Summary.Projects = _projects.Count;
            Summary.Contributors += project.Contributors;
            Summary.OpenIssues += project.OpenIssues;
            Summary.Forks += project.Forks;
            Summary.Stars += project.Stars;

            if (!String.IsNullOrEmpty(project.GithubOrg))
            {
                _orgs.Add(project.GithubOrg);
                Summary.Organizations = _orgs.Count;
            }            
        }
        public void AddProjects(Project[] projects)
        {
            foreach (Project project in projects)
            {
                AddProject(project);
            }
        }
        public Project GetProject(Project project)
        {
            // This code is bad in many many way. Need to refactor.

            bool found = false;
            Project foundProject = null;
            // Check to see if project already exists in data
            foreach (Project p in _projects)
            {
                if (p.isGitHub())
                {
                    // looking for a GitHub Project
                    if (project.GithubRepo == p.GithubRepo
                        && project.GithubOrg == p.GithubOrg)
                    {
                        found = true;
                    }
                }
                else if (!String.IsNullOrEmpty(project.CodePlexProject))
                {
                    // looking for a CodePlex Project
                    if (project.CodePlexProject == p.CodePlexProject)
                    {
                        found = true;
                    }
                }
                else
                {
                    // look for a match using URL
                    if (p.Url == project.Url)
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    foundProject = p;
                    break;
                }
            }
            return foundProject;
        }


        public OssData()
        {
            Summary = new SummaryStats();
        }

        public OssData Top(int count)
        {
            OssData data = new OssData();
            data.AddProjects(_projects
                    .OrderByDescending(project => project.Awesomeness)
                    .ThenByDescending(project => project.CommitLast)
                    .Take(count)
                    .ToArray());
            data.Summary = this.Summary;
            return data;
        }

    }
}
