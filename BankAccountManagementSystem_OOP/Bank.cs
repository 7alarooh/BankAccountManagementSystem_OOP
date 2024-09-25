using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem_OOP
{
    internal class Bank
    {
        //list to store Bank accounts 
        private List<BankAccount> accounts;

        public Bank() 
        {
            accounts = new List<BankAccount>();
        }

        //method to add a new account 
        public void AddAccount(BankAccount account) 
        {
            accounts.Add(account);
            Console.WriteLine("Account Successfully added!");
        }

    }
}
