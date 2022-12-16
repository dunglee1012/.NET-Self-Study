using Project_Form_App_PRN211.Manager;
using Project_Form_App_PRN211.Models;


namespace Project_Form_App_PRN211
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;

            AccountManager manager = new AccountManager();
            Account acc = manager.GetAccount(username, password);
            if (acc != null)
            {
                //MessageBox.Show("Welcome " + username);

                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                
            }
            else
            {
                MessageBox.Show("Account or password is wrong, try again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}