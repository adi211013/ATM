using ATM_library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ATM_app
{
    public partial class LoggedForm : Form
    {
        public User user;
        public LoggedForm(User u)
        {
            InitializeComponent();
            user = u;
            header1Label.Text = $"Hello, {user.FirstName} {user.LastName}";
        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void depositWithdrawButton_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(user);
            transactionForm.ShowDialog();
            this.Close();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            TransactionHistoryForm thf = new TransactionHistoryForm(user);
            thf.ShowDialog();
            this.Close();
        }
    }
}
