using StudentManagementSystem.Enums;
using StudentManagementSystem.Pages.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{

    class LoginScreenController
    {
        public static LoginScreenController _instance = new LoginScreenController();
        private LoginScreen loginScreen = new LoginScreen();

        public LoginScreenController()
        {
        }

        public void Run()
        {
            Application.Run(loginScreen);
        }

        public void UserAuthentication(string id, string password)
        {
            bool isValid = LoginScreenManager._instance.UserAuthentication(id, password);
            if (isValid)
            {
                loginScreen.Hide();
                MainScreen mainScreen = new MainScreen();
                mainScreen.welcomeText.Text = "Welcome, "+CurrentUser.currentUser.fullName.Split(' ')[0];
                mainScreen.Show();
            }
            else
            {
                MessageBox.Show("Invalid ID or Password");
            }

            
        }
    }
}
