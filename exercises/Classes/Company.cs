using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; set }
        public DateTime CreatedOn { get; }
        public Company(string name, DateTime date)
        {
           Name = Name;
           date = CreatedOn;

        }
        public List<Employee> Employee {get;set;}

        // Create a public property for holding a list of current employees

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Company()
        {
            Employee = new List<Employee>();
        }
        Company Jamazon = new Company("Jamazon", DateTime);
         public void ListEmployees()
    {
        foreach(Employee.employee in Employees)
        Console.WriteLine($"{Employee.FullName} works for {name} as {Employee.Title} since {mployee.StartDate})
    }
    }

   
}
