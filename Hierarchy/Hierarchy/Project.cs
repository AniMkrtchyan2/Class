using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hierarchy
{
    public enum State
    {
        Open,
        Closed,
    }
    class Project
    {
        private string projectName;
        private DateTime startDate;
        private string details;
        private State state;

        public Project(string projectName, DateTime startDate, string details, State state)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.Details = details;
            this.state = state;
        }
        public string ProjectName
        {
            get=> this.projectName; 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("The project name cannot be empty");
                }
                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9\s]+$") || !char.IsUpper(value, 0))
                {
                    throw new FormatException("The project name must be only latin letters and start with capital letter!");
                }
                this.projectName = value;
            }
        }

        public DateTime StartDate
        {
            get=>this.startDate;
            set { this.startDate = value; }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Details cannot be empty");
                }
                this.details = value;
            }
        }

        public void CloseProject()
        {
            this.state = State.Closed;
        }

        public override string ToString()
        {
            return string.Format("Project: {0}; Start date: {1}; Details: {2}; State: {3}", this.projectName, this.startDate.ToString("d"), this.details, this.state);
        }
    }
}
