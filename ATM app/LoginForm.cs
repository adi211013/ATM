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
using static ATM_library.SqlConnector;

namespace ATM_app
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(!ValidateForm()) 
            {
                MessageBox.Show("You must enter more information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User user = new User(emailTextBox.Text, passwordTextBox.Text);
            SqlConnector.Login(user);

            if(user.id!=0)
            {
                LoggedForm lfm= new LoggedForm(user);
                lfm.Show();
            }
            else 
            {
                MessageBox.Show("Login failed");
            }//caller
        }
        private bool ValidateForm()
        {
            if(passwordTextBox.Text.Length == 0) 
                return false;
            if(emailTextBox.Text.Length == 0)
                return false;

            return true;
        }
    }
}
