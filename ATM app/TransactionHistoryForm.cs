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
    public partial class TransactionHistoryForm : Form
    {
        User user;
        public TransactionHistoryForm(User u)
        {
            InitializeComponent();
            user = u;
            FillHistory();
        }
        public void FillHistory()
        {
            transactionHistoryGridView.DataSource = SqlConnector.ShowHistory(user);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            LoggedForm lfm = new LoggedForm(user);
            lfm.Show();
            this.Close();
        }
    }
}
