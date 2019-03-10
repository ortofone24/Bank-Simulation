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

            var name = "Nazwa: Bank";
            
            var author = "Autor: MG";

            var breakLine = "-----------------------";


            List<Account> accounts = new List<Account>();

            

            accounts.Add(new SavingsAccount(1, "Marek", "Zajac", 1234567890));
            accounts.Add(new SavingsAccount(2, "Marek", "Aaaa", 1234554321));
            accounts.Add(new SavingsAccount(3, "Zzzz", "Bbb", 0987654321));
            accounts.Add(new BillingAccount(4, "Marek", "Zajac", 1234567890));
            accounts.Add(new BillingAccount(5, "Marek", "Aaaa", 1234554321));

            IEnumerable<Account> accounts2 = accounts;

            Printer printer = new Printer();

            printer.Print(accounts[1]);
            printer.Print(accounts[4]);

            foreach (var item in accounts2)
            {
                Console.WriteLine(item.FirstName);
            }


            //Console.WriteLine(name);
            //Console.WriteLine(author);
            //Console.WriteLine(breakLine + "{0}" , Environment.NewLine);


            //SavingsAccount savingsAccount = new SavingsAccount(1,"Marcin", "Gala", 98948129842);


            //SavingsAccount secondSavingsAccount = new SavingsAccount(2, "Gosia", "Ruszniak", 346346346);
            ////string fullName = secondSavingsAccount.GetFullName();
            ////string balance = secondSavingsAccount.GetBalance();

            //BillingAccount billingAccount = new BillingAccount(1, secondSavingsAccount.FirstName,
            //    secondSavingsAccount.LastName, secondSavingsAccount.Pesel);


            ////Account ac = new Account("asta54",123.34m,"tt2","sst",14155); zwróci błąd dla metody abstrakcyjnej




            ////IPrinter print = new Printer();
            //IPrinter print = new SmallerPrinter();



            //print.Print(savingsAccount);
            //Console.WriteLine($"Drguie konto w systemie dostała: {secondSavingsAccount.GetFullName()} , oraz posiada na koncie {secondSavingsAccount.GetBalance()}");
            //print.Print(secondSavingsAccount);

            //Console.WriteLine("Twoje saldo {0}",billingAccount.GetBalance());
            //print.Print(billingAccount);

            //SavingsAccount account;
            //account = new SavingsAccount("940000000003", 0.15M, "Duza", "RRak", 93010133333);
            //Console.WriteLine(account.TypeName());

            //account = new BillingAccount("940000000005", 0.20M, "Mała", "RRuak", 93010133333);
            //Console.WriteLine(account.TypeName());

            Console.ReadKey();
        }
    }
}
