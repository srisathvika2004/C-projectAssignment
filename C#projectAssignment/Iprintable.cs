using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_projectAssignment
{
    interface Iprintable
    {
        void print();
    }
    interface Iserializable
    {
        void save();
    }
    class Report: Iprintable, Iserializable
    {
        public void print()
        {
            Console.WriteLine("files are beimg printed");
        }
        public void save()
        {
            Console.WriteLine("files are being saved");
        }
    }
}
