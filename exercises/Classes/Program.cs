using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company myCompany = new Company
            /*this is an object initializer vvv*/
            {
            Name = "Jamazon"
            };
            // Create an instance of a company. Name it whatever you like.

            // Create three employees

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            

            Employee jama = new Employee 
            {
                FirstName = "jama",
                LastName = "Throwinthedamntowelmazon",
                Title = "Goat",
                StartDate = new DateTime(2021,11,17)
            };
        }
    }
}
 