using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //need a class level reference to our bank account object
        BankAccount account;
        private void button1_Click(object sender, EventArgs e)
        {
            //close
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //display the starting balance
            account = new BankAccount(1000);
            BalanceLabel.Text = account.Balance.ToString("C");
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            decimal entry;

            if (!decimal.TryParse(DepositTextbox.Text, out entry))
            {
                MessageBox.Show("Please enter a valid deposit amount.");
                DepositTextbox.Clear();
                DepositTextbox.Focus();
                return;
            }

            if (entry <= 0)
            {
                MessageBox.Show("Deposit amount must be greater than zero.");
                return;
            }

            account.Deposit(entry);
            DepositTextbox.Clear();
            BalanceLabel.Text = account.Balance.ToString("C");
        }


        private void WithdrawalButton_Click(object sender, EventArgs e)
        {
             decimal entry;

            if (!decimal.TryParse(WithdrawalTextbox.Text, out entry))
            {
             MessageBox.Show("Please enter a valid withdrawal amount.");
             WithdrawalTextbox.Clear();
             WithdrawalTextbox.Focus();
             return;
        }

            if (entry <= 0)
            {
             MessageBox.Show("Withdrawal amount must be greater than zero.");
            return;
        }

    string errorMessage;
    bool success = account.Withdraw(entry, out errorMessage);

         if (!success)
        {
        MessageBox.Show(errorMessage);
         }
         else
         {
        WithdrawalTextbox.Clear();
        BalanceLabel.Text = account.Balance.ToString("C");
    }
}

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DepositTextbox.Clear();
            WithdrawalTextbox.Clear();
            DepositTextbox.Focus();
        }


        private void TotalsButton_Click(object sender, EventArgs e)
        {
            //display the summary form
            SummaryForm mySummaryForm = new SummaryForm();
            mySummaryForm.Show();


        }
    }
}
