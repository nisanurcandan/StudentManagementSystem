using StudentManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class MainScreenManager
    {
        public static MainScreenManager _instance = new MainScreenManager();

        public string answer;
        public MainScreenManager()
        {
        }

        public void ShowMyPersonalInfo()
        {
            CurrentUser.currentUser.ShowMyPersonalInfo();
            Console.WriteLine("1) Back");
            answer = Console.ReadLine();
            MainScreenController._instance.MainScreen();

        }

        public void ShowMyAcademicInfo()
        {
            switch (CurrentUser.userType)
            {
                case UserType.Student:
                    Student std = (Student)CurrentUser.currentUser;
                    std.ShowMyAcademicInfo();
                    Console.WriteLine("1) Back");
                    answer = Console.ReadLine();
                    MainScreenController._instance.MainScreen();
                    break;
                case UserType.Professor:
                    Professor pro = (Professor)CurrentUser.currentUser;
                    pro.ShowMyAcademicInfo();
                    Console.WriteLine("1) Back");
                    answer = Console.ReadLine();
                    MainScreenController._instance.MainScreen();
                    break;
                default:
                    break;
            }
        }

    }
}
