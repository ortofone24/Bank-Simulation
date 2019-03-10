using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SmallerPrinter : IPrinter
    {
        private string breakLine = "---------------------";

        public void Print(Account account)
        {
            Console.WriteLine("Dane konta: {0}", account.AccountNumber);
            Console.WriteLine("Imię i nazwisko właściciela: {0}", account.GetFullName());
            Console.WriteLine("{0}" + breakLine + "{0}", Environment.NewLine);
        }
    }
}
