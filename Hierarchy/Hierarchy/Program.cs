using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RegularEmployee> salesEmployees = new List<RegularEmployee>();
            List<RegularEmployee> productionEmployees = new List<RegularEmployee>();
            List<Sale> salesSaler1 = new List<Sale>();
            List<Sale> salesSaler2 = new List<Sale>();
            List<Project> projects = new List<Project>();


            Manager acountShef = new Manager(19061447, "Luca", "Pacioli", 3000, Department.Accounting, new List<RegularEmployee>());
            Manager marketingShef = new Manager(27051931, "Phiip", "Kotler", 4000, Department.Marketing, new List<RegularEmployee>());
            Manager productionShef = new Manager(19111942, "Peter", "Drucker", 4500, Department.Production, productionEmployees);
            Manager salesShef = new Manager(04021810, "Alexis", "Soyer", 5000, Department.Sales, salesEmployees);

            SalesEmployee saler1 = new SalesEmployee(01031984, "Bret", "Witek", 2100, Department.Sales, salesSaler1);
            SalesEmployee saler2 = new SalesEmployee(02031981, "Gor", "Matosyan", 2150, Department.Sales, salesSaler2);

            Developer developer1 = new Developer(11081982, "Richard", "Hris", 1800, Department.Production, projects);
            Developer developer2 = new Developer(10031987, "Christian", "Hargrave", 1800, Department.Production, projects);
            Developer developer3 = new Developer(11051985, "Freeman", "Lightner", 1800, Department.Production, projects);

            salesEmployees.Add(saler1);
            salesEmployees.Add(saler2);

            productionEmployees.Add(developer1);
            productionEmployees.Add(developer2);
            productionEmployees.Add(developer3);

            salesSaler1.Add(new Sale("Laptop", new DateTime(2019, 11, 29), 800M));
            salesSaler2.Add(new Sale("Software engineer", new DateTime(2019, 11, 30), 590M));

            projects.Add(new Project("CLEAR Virus", new DateTime(2019, 11, 30), "Anti virus program for", State.Open));
            projects.Add(new Project("Chess game", new DateTime(2019, 11, 10), "Game for computer", State.Open));

            List<Person> collection = new List<Person>()
            {
                acountShef,
                marketingShef,
                productionShef,
                salesShef,
                saler1,
                saler2,
                developer1,
                developer2,
                developer3
            };

            foreach (var person in collection)
            {
                Console.WriteLine(person);
                Console.WriteLine();
            }
        }
    }
}
