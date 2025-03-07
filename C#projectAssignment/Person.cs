using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_projectAssignment;

namespace C_projectAssignment
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;

        }
        public void GetDetails()
        {
            Console.WriteLine("the details are:");

        }

    }
    class Student1 : Person
    {
        public int RollNumber { get; set; }
        public Student1(string Name, int Age, string gender, int rollNumber) : base(Name, Age, gender)
        {
            RollNumber = rollNumber;
        }
        public void GetDetails()
        {
            Console.WriteLine("name of person:" + Name);
            Console.WriteLine("age of person:" + Age);
            Console.WriteLine("gender of person:" + Gender);
            Console.WriteLine("roll number of student is:"+RollNumber);

        }

    }
    class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(string Name, int Age, string gender, string subject) : base(Name, Age, gender)
        {
            Subject = subject;
        }


        public void GetDetails()
        {
            Console.WriteLine("name of person:" + Name);
            Console.WriteLine("age of person:" + Age);
            Console.WriteLine("gender of person:" + Gender);
            Console.WriteLine("subject is:"+Subject);

        }
    }

}
