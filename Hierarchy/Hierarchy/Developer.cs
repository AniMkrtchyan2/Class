using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Developer : RegularEmployee
    {
        private IList<Project> projects;

        public Developer(uint id, string name, string lastname, int salary, Department department,IList<Project> projects) 
            : base(id, name, lastname, salary, department)
        {
            this.Projects = projects;
        }
        public IList<Project> Projects
        {
            get=>this.projects;
            set { this.projects = value; }
        }

        public override string ToString()
        {
            string projectStr = string.Join("\n", this.projects);
            return "\nDeveloper -> " + base.ToString() + string.Format("\n{0} work on projects:\n{1}", this.Name, projectStr);
        }
    }
}
