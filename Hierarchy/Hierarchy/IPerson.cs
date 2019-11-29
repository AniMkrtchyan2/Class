using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    interface IPerson
    {
        ulong Id { get; set; }

        string Name { get; set; }

        string LastName { get; set; }
    }
}
