using ATM_library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_app
{
    public partial class TransactionForm : Form
    {
        User user;
        public TransactionForm(User u)
        {
            InitializeComponent();
            user= u;
            balanceTextBox.Text += u.Balance;
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoggedForm lfm=new LoggedForm(user);
            lfm.Show();
            this.Close();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if(!ValidateForm())
            {
                MessageBox.Show("You must enter a number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return; 
            }
            var b= Convert.ToDecimal(amountTextBox.Text);
            SqlConnector.DepositMoney(user,b);
            LoggedForm lfm = new LoggedForm(user);
            lfm.Show();
            this.Close();


        }
        public bool ValidateForm()
        {
            var b = decimal.TryParse(amountTextBox.Text,out decimal num);

            return b;
        }
        public bool ValidateWithdraw()
        {
            decimal result = user.Balance - decimal.Parse(amountTextBox.Text);
            if (result > 0)
                return true;

            return false;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("You must enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!ValidateWithdraw())
            {
                MessageBox.Show("You cant withdraw more money than you actually have", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var b = Convert.ToDecimal(amountTextBox.Text);
            SqlConnector.WithdrawMoney(user, b);
            LoggedForm lfm = new LoggedForm(user);
            lfm.Show();
            this.Close();
        }
    }
}
