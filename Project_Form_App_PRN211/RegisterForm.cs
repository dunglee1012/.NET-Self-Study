using Project_Form_App_PRN211.Manager;
using Project_Form_App_PRN211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Form_App_PRN211
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public Account GetAccountInfo()
        {
            Account acc = new Account();
            acc.UserName = tbRegisterUsername.Text;
            acc.Password = tbRegisterPassword.Text;
            return acc;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = tbRegisterUsername.Text;
            string password = tbRegisterPassword.Text;
            string rePassword = tbRegisterRePassword.Text;

            if (password != rePassword)
            {
                MessageBox.Show("Password and Confirm Password not match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                AccountManager manager = new AccountManager();
                Account acc = manager.GetAccount(username, password);
                if (acc != null)
                {
                    MessageBox.Show("Acccount information is invalid");
                }
                else
                {
                    MessageBox.Show("Create Account " + username + " Successfully");
                    manager.AddAccount(GetAccountInfo());
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCreateAccount.Enabled == false)
            {
                btnCreateAccount.Enabled = true;
            }
            else if (btnCreateAccount.Enabled == true)
            {
                btnCreateAccount.Enabled = false;
            }
        }
    }
}
