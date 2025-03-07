using System;

using System.Security.Claims;
namespace C_projectAssignment
{
    class Program
    {
        //public static void Main(String[] args)
        //{
        //    BankAccount b = new BankAccount();
        //    b.Deposit(1000);
        //    Console.WriteLine("The balance after deposit is:" + b.GetBalance());

        //    b.Withdraw(500);
        //    Console.WriteLine("The remaining balance is: " + b.GetBalance());
        //}
        //public static void Main(string[] args)
        //{
        //    Student s = new Student();

        //    Console.WriteLine("Enter student name:");
        //    string name = Console.ReadLine();
        //    while (string.IsNullOrEmpty(name))
        //    {
        //        Console.WriteLine("The name can't be empty. Please enter a valid name:");
        //        name = Console.ReadLine();
        //    }
        //    s.Name = name;

        //    Console.WriteLine("Enter student RollNumber:");
        //    int rollNumber;
        //    while (!int.TryParse(Console.ReadLine(), out rollNumber) || rollNumber < 0)
        //    {
        //        Console.WriteLine("RollNumber must be a non-negative integer. Please enter a valid RollNumber:");
        //    }
        //    s.RollNumber = rollNumber;

        //    Console.WriteLine("\nStudent Details:");
        //    Console.WriteLine("Name: " + s.Name);
        //    Console.WriteLine("RollNumber: " + s.RollNumber);

        //}
        //public static void Main(string[] args)
        //{
        //    Book b = new Book();
        //    b.Displaydetails();
        //    Book b2 = new Book("ikiagi","shake sphere");
        //    b2.Displaydetails();
        //    Book b3 = new Book("ramayan","valmiki",123);
        //    b3.Displaydetails();
        //}
        //public static void Main(string[] args)
        //{
        //    Circle c = new Circle(4);
        //    Console.WriteLine(c.CalculateArea());
        //    Rectangle r = new Rectangle(4, 2);
        //    Console.WriteLine(r.CalculateArea());

        //}
        public static void Main(string[] args)
        //{
        //    Car c = new Car();
        //    c.Start();
        //    Bike b = new Bike();
        //    b.Start();
        //}





        //{
        //    Student1 s1 = new Student1("sath", 21, "F", 23);
        //    s1.GetDetails();
        //    Teacher t = new Teacher("pinky", 31, "M", "maths");
        //    t.GetDetails();
        //}




        //{
        //    Calculator c = new Calculator();
        //    c.Add(1,2);
        //    Calculator c1 = new Calculator();
        //    c1.Add(1,2,3);
        //    Calculator c2 = new Calculator();
        //    c2.Add(1.12,2.13);

        //}




        //{
        //    MusicPlayer m = new MusicPlayer();
        //    m.Play();
        //    VideoPlayer v = new VideoPlayer();
        //    v.Play();
        //}





        //{
        //    Report r = new Report();
        //    r.print();
        //    r.save();
        //}

        //{
        //    Admin a = new Admin("apple","teacher");
        //    a.AccessControl();
        //    Customer c = new Customer("ball","singer");
        //    c.AccessControl();
        //}


        //{
        //    Manager manager = new Manager("Alice");
        //    Department dept1 = new Department("HR", manager);

        //    // Shallow Copy
        //    Department dept2 = dept1.ShallowCopy();
        //    dept2.Manager.Name = "Bob";

        //    // Deep Copy
        //    Department dept3 = dept1.DeepCopy();
        //    dept3.Manager.Name = "Charlie";

        //    Console.WriteLine($"Dept1 Manager: {dept1.Manager.Name}"); // Bob
        //    Console.WriteLine($"Dept2 Manager: {dept2.Manager.Name}"); // Bob
        //    Console.WriteLine($"Dept3 Manager: {dept3.Manager.Name}"); // Charlie
        //}

        //{
        //    // Set InterestRate via static method
        //    Bank.SetInterestRate(0.05);

        //    Bank bank1 = new Bank();
        //    Bank bank2 = new Bank();

        //    Console.WriteLine($"Interest Rate: {Bank.InterestRate}");
        //    Console.WriteLine($"Bank1 Interest on 1000: {bank1.CalculateInterest(1000)}");
        //    Console.WriteLine($"Bank2 Interest on 1000: {bank2.CalculateInterest(1000)}");
        //}


        //{
        //    SecuritySystem security = new SecuritySystem();
        //    security.Activate();
        //    // SecuritySystem cannot be inherited, so no derived class can be created.
        //}


        //{


        //    Button button = new Button();
        //    button.OnClick += () => Console.WriteLine("Event triggered: Button was clicked.");

        //    // Simulating button click
        //    button.Click();
        //} 

      
            {
                VehicleFactory factory = new VehicleFactory();

                IVehicle vehicle1 = factory.GetVehicle("Car");
                vehicle1.Drive();

                IVehicle vehicle2 = factory.GetVehicle("Bike");
                vehicle2.Drive();
            }




    }
}
    




