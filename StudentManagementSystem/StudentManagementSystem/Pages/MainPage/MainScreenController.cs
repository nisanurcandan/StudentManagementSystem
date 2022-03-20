using StudentManagementSystem.Pages.MessagePage;
using StudentManagementSystem.Pages.SetGradePage;
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
            switch (CurrentUser.userType)
            {
                case Enums.UserType.Student:
                    MainScreenStudent();
                    break;
                case Enums.UserType.Professor:
                    MainScreenProfessor();
                    break;
                default:
                    break;
            }
        }

        public void MainScreenStudent()
        {
            Console.Clear();
            Console.WriteLine("1) Personal Informations");
            Console.WriteLine("2) Academic Informations");
            Console.WriteLine("3) Messages");
            Console.WriteLine("4) Back");
            Console.WriteLine("Chose one of them");
            answer = Console.ReadLine();
            ShowNewScreenStudent();
        }

        public void MainScreenProfessor()
        {
            Console.Clear();
            Console.WriteLine("1) My Personal Informations");
            Console.WriteLine("2) My Academic Informations");
            Console.WriteLine("3) Messages");
            Console.WriteLine("4) Get Top Student in University");
            Console.WriteLine("5) Set Grade For Student");
            Console.WriteLine("6) Back");
            Console.WriteLine("Chose one of them");
            answer = Console.ReadLine();
            ShowNewScreenProfessor();
        }

        public void ShowNewScreenStudent()
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
                    MessageController._instance.MessageScreen();
                    break;
                case "4":
                    LoginScreenController._instance.LoginScreen();
                    break;
                default:
                    MainScreenStudent();
                    break;
            }
        }

        public void ShowNewScreenProfessor()
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
                    MessageController._instance.MessageScreen();
                    break;
                case "4":
                    MainScreenManager._instance.GetTopStudentInfo();
                    break;
                case "5":
                    SetGradeController._instance.SetGradeScreen();
                    break;
                case "6":
                    LoginScreenController._instance.LoginScreen();
                    break;
                default:
                    MainScreenProfessor();
                    break;
            }
        }

    }
}