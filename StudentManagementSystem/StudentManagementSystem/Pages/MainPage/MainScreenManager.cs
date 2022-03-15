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

        public void GetTopStudentInfo()
        {
            float maxGPA = 0.0f;
            Student topStudent = null;
            for (int i = 0; i < DefaultData.students.Count; i++)
            {
                if (maxGPA <= DefaultData.students[i].Gpa)
                {
                    maxGPA = DefaultData.students[i].Gpa;
                    topStudent = DefaultData.students[i];
                }
            }

            topStudent.ShowMyPersonalInfo();
            Console.WriteLine("**************************");
            topStudent.ShowMyAcademicInfo();

            Console.WriteLine("1) Back");
            var ans = Console.ReadLine();
            MainScreenController._instance.MainScreen();
        }

    }
}
