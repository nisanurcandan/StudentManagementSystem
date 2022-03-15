using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class MainScreenController
    {
        public static MainScreenController _instance = new MainScreenController();

        private static string answer;

        public void MainScreen()
        {
            Console.Clear();
            Console.WriteLine("1) Personal Informations");
            Console.WriteLine("2) Academic Informations");
            Console.WriteLine("3) Get Top Student in University");
            Console.WriteLine("4) Back");
            Console.WriteLine("Chose one of them");
            answer = Console.ReadLine();
            ShowNewScreen();
        }

        public void ShowNewScreen()
        {
            Console.Clear();
            switch (answer)
            {
                case "1":
                    MainScreenManager._instance.ShowMyPersonalInfo();
                    break;
                case "2": 
                    MainScreenManager._instance.ShowMyAcademicInfo();
                    break;
                case "3":
                    MainScreenManager._instance.GetTopStudentInfo();
                    break;
                case "4":
                    LoginScreenController._instance.LoginScreen();
                    break;
                default:
                    MainScreen();
                    break;
            }

        }

    }
}
