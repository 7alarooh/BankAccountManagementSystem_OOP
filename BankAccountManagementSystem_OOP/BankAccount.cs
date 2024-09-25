using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem_OOP
{
    public class BankAccount
    {
        // private properties
        private string accountNumber;
        private string accountHolderName;
        private decimal balance;

        // constructor with 2 parameters
        public BankAccount(string accountHolderName, string accountNumber) 
        {
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;
            this.balance = 0;//default balance

        }
        // constructor with an initial deposit amount
        public BankAccount(string accountHolderName, string accountNumber,decimal initialDeposit )
        { 
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;

            if (initialDeposit > 0) { balance = initialDeposit;
                Console.WriteLine($"Successfully deposited {initialDeposit} OMR");
            }
            else {
                Console.WriteLine("deposit amount must be positive!");
            }

        }


    }
}
