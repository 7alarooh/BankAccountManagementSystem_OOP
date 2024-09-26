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
        static List<BankAccount> accounts { get; set; }

         static Bank() 
        {
            accounts = new List<BankAccount>();
            IntialSetup();
        }

        //method to add a new account 
        public void AddAccount(BankAccount account) 
        {
            try
            {
                accounts.Add(account);
                Console.WriteLine("Account Successfully added!");
            } catch(Exception e) 
            { Console.WriteLine("Error:"+e); }
        }

        // method to get an account by account number
       
        public BankAccount GetAccountByNumber(string accountNumber, bool checkdo=false) 
        {
            foreach (BankAccount account in accounts) 
            {
                if (account.GetAccountNumber() == accountNumber)
                { return account; }
            }
            //or return null if not found
            if (checkdo==false)
            {
                Console.WriteLine("Account not found!");
                return null;
            }
            else { return null; }
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

           // for (int i = 0; i < accounts.Count; i++) { accounts[i].GetAccountInfo(); }

        }
        static void IntialSetup() {
            accounts.Add(new BankAccount("444", "mmm"));
            accounts.Add(new BankAccount("555", "ccc"));
            accounts.Add(new BankAccount("999", "ddd", 8));
            accounts.Add(new BankAccount("999", "ddd", 10));
        }


    }
}
