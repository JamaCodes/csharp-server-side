using System;

namespace BankConsole51
{
    class Program
    {
        static void Main(string[] args)
        {

        //    use an arg supplied to the program to set the bank name
        //if the user doesn't supply a name, display a message that they should and exit

        // display a welcome message for a bank management system with a list of menu options
        var bank = new Bank();
            try
            {
                string bankName = args[0];
                bank.Name = bankName;
              
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Please supply a bank name!");
                return;
            }
               Console.WriteLine($"{bank.Name} Management System. Please Choose an Option:");
                Console.WriteLine("----------------------------------------------------------");
        }
    }
    class Bank
    {
    public string bankName
    }
}

