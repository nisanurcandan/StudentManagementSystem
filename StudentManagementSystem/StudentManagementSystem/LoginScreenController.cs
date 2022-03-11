using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class LoginScreenController
    {
        public static LoginScreenController _instance = new LoginScreenController();

        public static string id;
        public static string password;

        public LoginScreenController()
        {
            if (_instance == null)
            {
                _instance = this;
            }
        }

        public void LoginScreen()
        {
            Console.WriteLine("***************STUDENT MANAGEMENT SYSTEM***************\n");
            Console.WriteLine("Enter your ID: ");
            id = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();

            LoginScreenManager._instance.UserAuthentication();
        }
    }
}
