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
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //close this window
            Close();

        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {

         }

        private void SummaryForm_Activated(object sender, EventArgs e)
        {
            //refreshes the data every time the user
            //uses it
            DepositsLabel.Text = BankAccount.totalDeposits.ToString("C");
            WithdrawalsLabel.Text = BankAccount.totalWithdrawals.ToString("C");
            TotalTransactionsLabel.Text = BankAccount.totalTransactions.ToString();

        }
    }
}
