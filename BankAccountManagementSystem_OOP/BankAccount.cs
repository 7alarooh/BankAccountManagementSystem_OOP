using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem_OOP
{
    public class BankAccount
    {
        // private properties
        public string accountNumber { get; private set; }
        public string accountHolderName { get; private set; }
        private decimal balance=0 ;

        // constructor with 2 parameters
        public BankAccount( string accountNumber, string accountHolderName) 
        {
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;
            this.balance = 0;//default balance

        }
        // constructor with an initial deposit amount
        public BankAccount(string accountNumber, string accountHolderName,decimal initialDeposit )
        { 
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;

            if (initialDeposit > 0) { Deposit(initialDeposit);
            }
            else {
                Console.WriteLine("deposit amount must be positive!");
            }
        }
        // method to deposit money  (increase balance)
        public void Deposit(decimal amount, bool show=false) 
        {

            if (amount > 0)
            {
                balance += amount;
                if (show == true)
                {
                    Console.WriteLine($"Successfully deposited {amount} OMR. New balance  is {balance} OMR");
                }
            }
            else
            {
                if (show == true)
                {
                    Console.WriteLine("deposit amount must be positive!");
                }
            }
        }

        //method to withdraw money (decrease balance)

        public void Withdraw(decimal amount) 
        {
            if (amount > 0 && amount<=balance)
            {
                balance -= amount;
                Console.WriteLine($"Successfully withdrew {amount} OMR. New balance  is {balance} OMR");
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount!");
            }
        }

        //method to Get Account Infomation 
        public void GetAccountInfo() {
            Console.WriteLine($"Account Number: {accountNumber} \n" +
                $"Account Holder: {accountHolderName}\n" +
                $"Balance: {balance} OMR \n" +
                $"---------------------------------------------------\n");
        }

        public string GetAccountNumber() {
            return $"{accountNumber}"; }

        public void editName(string name) { accountHolderName = name; }
        

    }
}
