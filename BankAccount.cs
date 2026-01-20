using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Account_Simulator
{
    class BankAccount
    {
        decimal balance;
        public static decimal totalDeposits;
        public static decimal totalWithdrawals;
        public static int totalTransactions;
        public BankAccount()
        {
            //this constructor is called without sending a starting balance
            balance = 0; 
        }
        public BankAccount(decimal startingBalance)
        {
            balance = startingBalance;
        }
        public decimal Balance
        {
            //read-only
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            totalDeposits += amount;
            totalTransactions++;
        }

        public bool Withdraw(decimal amount, out string errorMessage)
        {
            errorMessage = "";

            if (balance >= amount)
            {
                balance -= amount;
                totalWithdrawals += amount;
                totalTransactions++;
                return true;
            }

            errorMessage = "Insufficient funds - your balance is " + balance.ToString("C");
            return false;
        }

    }
}
