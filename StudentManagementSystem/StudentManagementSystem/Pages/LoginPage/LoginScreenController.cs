using StudentManagementSystem.Enums;
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


        public LoginScreenController()
        {
        }

        public void LoginScreen()
        {
            Console.Clear();
            Console.WriteLine("***************STUDENT MANAGEMENT SYSTEM***************\n");
            Console.WriteLine("Enter your ID: ");
            CurrentUser.id = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            CurrentUser.password = Console.ReadLine();

            bool isValid = LoginScreenManager._instance.UserAuthentication(CurrentUser.id, CurrentUser.password);
            if (isValid)
            {
                MainScreenController._instance.MainScreen();
            }
            else
            {
                Console.WriteLine("Invalid ID or password");
                Console.WriteLine("Press any key to try again...");
                var ans = Console.ReadLine();
                LoginScreen();

            }

            
        }
    }
}
