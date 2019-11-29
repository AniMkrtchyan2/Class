using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public abstract class Person : IPerson
    {
        private ulong id;
        private const ulong digit =1000000000000;
        private string name;
        private string lastname;
        public ulong Id
        {
            get => this.id;
            set
            {
                if (value <= 0 || value > digit)
                {
                    throw new ArgumentOutOfRangeException("ID cannot be negative or zero");
                }
                this.id = value;
            }
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("The name cannot be empty");
                }
                if (!value.All(char.IsLetter) || !char.IsUpper(value, 0))
                {
                    throw new FormatException("The name start with capital letter");
                }
                this.name = value;
            }
        }

        public string LastName
        {
            get => this.lastname;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("The lastname cannot be empty");
                }
                if (!value.All(char.IsLetter) || !char.IsUpper(value, 0))
                {
                    throw new FormatException("The lastname start with capital letter!");
                }
                this.lastname = value;
            }
        }

        public Person(ulong id, string name, string lastname)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastname;
        }
        public override string ToString()
        {
            return string.Format("ID {0}; First name: {1}; Last name: {2}; ", this.id, this.name, this.lastname);
        }
    }
}
