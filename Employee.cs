using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsInInheritance
{
    class Employee
    {
        int id;
        string name;
        string department;
        static string manager;

        // Def cons
        public Employee() { }
        // Para cons
         public Employee(string name)
        {
            this.name = name;
            Console.WriteLine("Enter ID");
            id = Convert.ToByte(Console.ReadLine());
             
            Console.WriteLine("enter Department");
            department = Console.ReadLine();
        }
        // Para Cons
        public Employee(int id, string name)
        {
            this.name = name;
             
            this.id = id;
            Console.WriteLine("enter Department");
            department = Console.ReadLine();
        }
        // Para Cons
        public Employee(int id, string name, string department)
        {
            this.name = name;

            this.id = id;
            
            this.department = department;
        }
        // Static Cons
        static Employee()
        {
            manager = "Deepak";
        }
        // copy cons
         public Employee(Employee obj)
        {
            this.name = obj.name;
            this.department = obj.department;
            Console.WriteLine("Enter ID");
            id = Convert.ToByte(Console.ReadLine());
        }
        public void GetDetails()
        {
            Console.WriteLine("Enter ID");
            id = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("enter Department");
            department = Console.ReadLine();

        }
        public void DisplayDetails()
        {
            Console.WriteLine("Id is " + id);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Department is " + name);
        }

    }
}
