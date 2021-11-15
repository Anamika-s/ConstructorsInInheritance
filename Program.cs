using System;

namespace ConstructorsInInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // will invoke static cons
            // will invoke def cons
            Employee emp1 = new Employee();
            emp1.GetDetails();
            emp1.DisplayDetails();
            // will invoke para cons
            Employee emp2 = new Employee("Nimisha");
            emp2.DisplayDetails();
            // will invoke para cons
            Employee emp3 = new Employee(1,"Ajay");
            emp3.DisplayDetails();

            // will invoke para cons
            Employee emp4 = new Employee(2, "Lalit", "HR");
            emp4.DisplayDetails();
            // will invoke copy cons
            Employee emp5 = new Employee(emp4);

            // This will invoke para con of FullTime class
            FullTimEmployee fullTimEmployee = new FullTimEmployee
               (1, "Ajay", "HR", "Deepak", 90000);


        }
    }
}
