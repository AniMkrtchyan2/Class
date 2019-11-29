using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    interface IDeveloper
    {
        IList<Project> Projects { get; set; }
    }
}
