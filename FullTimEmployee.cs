using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsInInheritance
{
    class FullTimEmployee : Employee
    {
        string manager;
        int salary;
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter manager");
            manager = Console.ReadLine();
            Console.WriteLine("enter salary");
            salary = Convert.ToInt16(Console.ReadLine());

        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("manager is " + manager);
            Console.WriteLine("salary is " + salary);
             
        }
    }
}
