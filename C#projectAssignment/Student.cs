
using System;

namespace C_projectAssignment
{
    class Student
    {
        public string Name { get; set; }
        public int RollNumber { get; set; }

        public void ValidateRollNumber(int rollNumber)
        {
            if (rollNumber < 0)
            {
                Console.WriteLine("Invalid student");
            }
            else
            {
                Console.WriteLine("RollNumber is: " + rollNumber);
            }
        }

        public void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("The name is empty");
            }
            else
            {
                Console.WriteLine("The Name is: " + name);
            }
        }
    }
}