using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_projectAssignment
{
    class User
    {
        public string UserName { get; set; }
        public string Role { get; set; }
        public User(string username, string role)
        {
            UserName = username;
            Role = role;

        }
        public virtual void AccessControl()
        {
            Console.WriteLine("Access is limited");

        }

    }
    class Admin : User
    {
        public Admin(string username, string role) : base(username, role) { }
        public override void AccessControl()
        {
            Console.WriteLine("total access is given ");
        }

    }
    class Customer : User
    {
        public Customer(string username, string role) : base(username, role) { }
        public override void AccessControl()
        {
            Console.WriteLine("limited access is given");
        }
    }
}
