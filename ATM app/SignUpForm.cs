using ATM_library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_app
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if(!ValidateForm())
            {
                MessageBox.Show("You must enter more information","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            User user=new User(firstNameTextBox.Text,lastNameTextBox.Text,emailTextBox.Text,passwordTextBox.Text);
            SqlConnector.SignUp(user);

            MessageBox.Show("Your registration has been successful", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private bool ValidateForm()
        {
            if(firstNameTextBox.Text.Length==0)
                return false;
            if(lastNameTextBox.Text.Length==0)
                return false;
            if(emailTextBox.Text.Length==0) 
                return false;
            if (passwordTextBox.Text.Length==0)
                return false;

            

            return true;
        }
    }
}
