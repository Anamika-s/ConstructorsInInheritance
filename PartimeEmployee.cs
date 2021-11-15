using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsInInheritance
{
    class PartimeEmployee : Employee
    {
        int duration;
        string projectName;
        public PartimeEmployee() : base() { }
        public PartimeEmployee(int id, string name,
           string department, string projectName,
           int duration) : base(id, name, department)
        {
            this.projectName = projectName;
            this.duration = duration;
        }
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter projectName");
            projectName = Console.ReadLine();
            Console.WriteLine("enter duration");
            duration = Convert.ToInt16(Console.ReadLine());

        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("projectName is " + projectName);
            Console.WriteLine("duration is " + duration);
             
        }
    }
}
