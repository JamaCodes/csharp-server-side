using System;

namespace Classes
{
    public class Employee
    {

        /* Properties */
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        /* Methods*/
        public void EmployeeWelcome(Employee employee)
        {
            Console.WriteLine($"Hello {employee.FullName}");
        }


    };
}

