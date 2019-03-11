using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            BankManager bankManager = new BankManager();
            bankManager.Run();

            //AccountsManager manager = new AccountsManager();

            //manager.CreateBillingAccount("Mg", "Mg", 1234567890);
            //manager.CreateSavingsAccount("Mg", "Mg", 1234567890);
            //manager.CreateSavingsAccount("aa", "aa", 0987654321);


            //IEnumerable<string> users = manager.ListOfCustomers();


            //foreach (string customer in users)
            //{
            //    Console.WriteLine(customer);
            //}

            //IList<Account> accounts = (IList<Account>)manager.GetAllAccounts();

            //Printer printer = new Printer();

            //printer.Print(accounts[0]);
            //printer.Print(accounts[2]);

            Console.ReadKey();
        }
    }
}
