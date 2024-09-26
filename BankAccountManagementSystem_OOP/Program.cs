namespace BankAccountManagementSystem_OOP
{
    public class Program
    {// Make 'bank' static so it can be accessed from static methods
        private static Bank Bank = new Bank();
        static void Main(string[] args)
        {
            mainMenu();
        }
        static void mainMenu()
        {
            bool ExitFlag = false;
            do
            {
                Console.WriteLine("Welcome Course Enrollment System");
                Console.WriteLine("\n Enter the No. of operation you need :");
                Console.WriteLine("\n 1 .Create New Account");
                Console.WriteLine("\n 2 .Deposit Money");
                Console.WriteLine("\n 3 .Withdraw Money");
                Console.WriteLine("\n 4 .Display All Accounts");
                Console.WriteLine("\n 0 .singOut");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        CreateNewAccount();
                        break;
                    case "2":
                        Console.Clear();
                        DepositMoney();
                        break;
                    case "3":
                        Console.Clear();
                        WithdrawMoney();
                        break;
                    case "4":
                        Console.Clear();
                        DisplayAllAccounts();
                        break;
                    case "0":
                        ExitFlag = true;
                        break;
                    default:
                        Console.WriteLine("Sorry your choice was wrong !!");
                        break;
                }

            } while (ExitFlag != true);
        }

        static void CreateNewAccount()
        {
            Console.Clear();
            Console.WriteLine(":::::: Create New Account ::::::");

            string accountNumber = GetInput("Enter the account number:");
            if (!IsNumeric(accountNumber)) { Console.WriteLine("Sorry! you must Enter numbers only!");
                return;
            }

                string accountHolderName = GetInput("Enter the account holder name:");
            
            if (string.IsNullOrEmpty(accountNumber) || string.IsNullOrEmpty(accountHolderName))
            {
                Console.WriteLine("Operation canceled.");
                return;
            }

            string initialDepositInput = GetInput("Enter initial deposit (optional, press Enter to skip):");
            if (decimal.TryParse(initialDepositInput, out decimal initialDeposit))
            {
                Bank.AddAccount(new BankAccount(accountHolderName, accountNumber, initialDeposit));
            }
            else
            {
                Bank.AddAccount(new BankAccount(accountHolderName, accountNumber));
            }
        }

        // Function to deposit money
        static void DepositMoney()
        {
            string accountNumber = GetInput("Enter the account number:");
            if (!IsNumeric(accountNumber))
            {
                Console.WriteLine("Sorry! you must Enter numbers only!");
                return;
            }
            BankAccount account = Bank.GetAccountByNumber(accountNumber);
            if (account != null)
            {
                string amountInput = GetInput("Enter amount to deposit:");
                if (decimal.TryParse(amountInput, out decimal amount))
                {
                    account.Deposit(amount);
                }
                else
                {
                    Console.WriteLine("Invalid amount!");
                }
            }
        }

        // Function to withdraw money
        static void WithdrawMoney()
        {
            string accountNumber = GetInput("Enter the account number:");
            BankAccount account = Bank.GetAccountByNumber(accountNumber);
            if (!IsNumeric(accountNumber))
            {
                Console.WriteLine("Sorry! you must Enter numbers only!");
                return;
            }
            if (account != null)
            {
                string amountInput = GetInput("Enter amount to withdraw:");
                if (decimal.TryParse(amountInput, out decimal amount))
                {
                    account.Withdraw(amount);
                }
                else
                {
                    Console.WriteLine("Invalid amount!");
                }
            }
        }

        // Function to display all accounts
        static void DisplayAllAccounts()
        {
            Console.Clear();
            Bank.DisplayAllAccounts();
        }

        // Helper function to get user input
         
        static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            // Check if the user wants to exit
            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Exiting the current operation...");
                return null; // Return null if "exit" is entered
            }

            return input; // Return the valid input
        }

        static bool IsNumeric(string value) 
        { 
            return value.All(char.IsDigit);
        }
    }

}
