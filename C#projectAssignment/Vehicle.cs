using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_projectAssignment
{
    class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("vehicle started");
        }
    }
    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car started");
        }

    }
    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("bike started");
        }
    }
}
