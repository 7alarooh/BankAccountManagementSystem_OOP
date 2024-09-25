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

        // method to get an account by account number
       
        public BankAccount GetAccountByNumber(string accountNumber) 
        {
            foreach (BankAccount account in accounts) 
            {
                if (account.GetAccountNumber() == accountNumber)
                { return account; }
            }
            Console.WriteLine("Account not found!");
            return null;
        }

        public void DisplayAllAccounts() 
        {
            if (accounts.Count == 0) 
            {
                Console.WriteLine("No Accounts available!");
                return;
            }
            Console.WriteLine("List of accounts avaliable:" +
                "---------------------------------------------------\n");
            foreach (BankAccount account in accounts) 
            {
                account.GetAccountInfo();
            }

        }


    }
}
