using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_projectAssignment
{
    public class Manager
    {
        public string Name { get; set; }
        public Manager(string name)
        {
            Name = name;
        }
    }

    class Department
    {
        public string Name { get; set; }
        public Manager Manager { get; set; }

        public Department(string name, Manager manager)
        {
            Name = name;
            Manager = manager;
        }

        // Shallow Copy
        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

        // Deep Copy
        public Department DeepCopy()
        {
            Department department = (Department)this.MemberwiseClone();
            department.Manager = new Manager(this.Manager.Name);  // Deep copy of Manager
            return department;
        }
    }
}
