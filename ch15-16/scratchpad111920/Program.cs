using System;
using System.Collections.Generic;


class Program
{

    public class AddressBook
    {
        public Dictionary<string, Contact> ContactDictionary { get; set; }
        public AddressBook()
        {
            ContactDictionary = new Dictionary<string, Contact>();
        }

        public void AddContact(Contact person)
        {
            ContactDictionary.Add(person.Email, person);
        }
       
        public Contact GetByEmail(Contact person)
        {
           
        }


    };

     public class Contact 
        {
            string FirstName;
            string LastName;
            string Email;
            string Address;
        };
    /*
        1. Add the required classes to make the following code compile.
        HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.
        

        2. Run the program and observe the exception.

        3. Add try/catch blocks in the appropriate locations to prevent the program from crashing
            Print meaningful error messages in the catch blocks.
    */

    static void Main(string[] args)
    
    {
        // Create a few contacts
        Contact bob = new Contact()
        {
            FirstName = "Bob",
            LastName = "Smith",
            Email = "bob.smith@email.com",
            Address = "100 Some Ln, Testville, TN 11111"
        };
        Contact sue = new Contact()
        {
            FirstName = "Sue",
            LastName = "Jones",
            Email = "sue.jones@email.com",
            Address = "322 Hard Way, Testville, TN 11111"
        };
        Contact juan = new Contact()
        {
            FirstName = "Juan",
            LastName = "Lopez",
            Email = "juan.lopez@email.com",
            Address = "888 Easy St, Testville, TN 11111"
        };


        // Create an AddressBook and add some contacts to it
        AddressBook addressBook = new AddressBook();
        addressBook.AddContact(bob);
        addressBook.AddContact(sue);
        addressBook.AddContact(juan);

        // Try to addd a contact a second time
        addressBook.AddContact(sue);


        // Create a list of emails that match our Contacts
        List<string> emails = new List<string>() {
            "sue.jones@email.com",
            "juan.lopez@email.com",
            "bob.smith@email.com",
        };

        // Insert an email that does NOT match a Contact
        emails.Insert(1, "not.in.addressbook@email.com");


        //  Search the AddressBook by email and print the information about each Contact
        foreach (string email in emails)
        {
            Contact ContactDictionary = addressBook.GetByEmail(email);
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Name: {contact.FullName}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Address: {contact.Address}");
        }


      
    }
}























































// using System;
// using System.Collections.Generic;

// namespace TryCatch
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Company chickenShack = new Company() { Name = "Greasy Pete's Chicken Shack" };
//             chickenShack.AddEmployee(new Employee() { FirstName = "Pete", LastName = "Shackleton" });
//             chickenShack.AddEmployee(new Employee() { FirstName = "Molly", LastName = "Frycook" });
//             chickenShack.AddEmployee(new Employee() { FirstName = "Pat", LastName = "Buttersmith" });

//             List<int> employeeIds = new List<int>() { 0, 11, 2 };
//             foreach (int id in employeeIds)
//             {
//                 try
//                 {
//                     Employee employee = chickenShack.GetEmployeeById(id);
//                     Console.WriteLine($"Employee #{id} is {employee.FirstName} {employee.LastName}.");
//                 }
//                 catch (ArgumentOutOfRangeException ex)
//                 {
//                     Console.WriteLine($"Employee #{id} was not found in the company.");
//                 }
//             }


//         }
//     }

//     public class Company
//     {
//         private List<Employee> _employees = new List<Employee>();
//         public string Name { get; set; }

//         public void AddEmployee(Employee employee)
//         {
//             _employees.Add(employee);
//         }

//         public Employee GetEmployeeById(int id)
//         {
//             return _employees[id];
//         }
//     }

//     public class Employee
//     {
//         public string FirstName { get; set; }
//         public string LastName { get; set; }
//     }
// }

