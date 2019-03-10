﻿namespace Bank
{
    abstract class Account
    {
        public int Id { get; }
        public string AccountNumber { get; }
        public decimal Balance { get; } /* Saldo */
        public string FirstName { get; }
        public string LastName { get; }
        public long Pesel { get; }

        public Account(int id, string firstName, string lastName, long pesel)
        {
            Id = id;
            AccountNumber = generateAccountNumber(id);
            Balance = 0.0M;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
        }

        public abstract string TypeName();

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetBalance()
        {
            return string.Format("{0} zł", Balance);
        }

        private string generateAccountNumber(int id)
        {
            var accountNumber = string.Format("94{0:D10}", id);

            return accountNumber;
        }
    }
}
