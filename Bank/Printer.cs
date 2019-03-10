using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Printer : IPrinter
    {
        private string breakLine = "---------------------";

        public void Print(Account account)
        {
            Console.WriteLine("Dane konta: {0}", account.AccountNumber);
            Console.WriteLine("Typ: {0}", account.TypeName());
            Console.WriteLine("Saldo: {0}", account.GetBalance());
            Console.WriteLine("Imię i nazwisko właściciela: {0}", account.GetFullName());
            Console.WriteLine("Pesel: {0}", account.Pesel);
            Console.WriteLine("{0}" + breakLine + "{0}", Environment.NewLine);
        }

        //public void Print(BillingAccount account)
        //{
        //    Console.WriteLine("Dane konta: {0}", account.AccountNumber);
        //    Console.WriteLine("Saldo: {0}", account.Balance);
        //    Console.WriteLine("Imię właściciela: {0}", account.FirstName);
        //    Console.WriteLine("Nazwisko właściciela: {0}", account.LastName);
        //    Console.WriteLine("Pesel: {0}", account.Pesel);
        //    Console.WriteLine("{0}" + breakLine + "{0}", Environment.NewLine);
        //}
    }
}
