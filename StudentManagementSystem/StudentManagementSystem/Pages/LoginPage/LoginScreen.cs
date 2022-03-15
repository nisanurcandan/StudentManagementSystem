using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class LoginScreen : Form
    {
        private string loginId;
        private string loginPassword;
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox loginIdTextBox = (TextBox)sender;
            loginId = loginIdTextBox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox loginPasswordTextBox = (TextBox)sender;
            loginPassword = loginPasswordTextBox.Text;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginScreenController._instance.UserAuthentication(loginId, loginPassword);
        }
    }
}
