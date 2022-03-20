using StudentManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Professor : User
    {
        private int salary;
        private List<Lecture> lectures;
        private int workingYear;

        public Professor (string fullName, string ID, string password, string email, int salary, List<Lecture> lectures, Gender gender, string nationality, DateTime dateOfBirth,  int workingYear) 
            : base(fullName, ID, password, email, gender, nationality,dateOfBirth)
        {
            this.fullName = fullName;
            this.ID = ID;
            this.password = password;
            this.email = email;
            this.salary = salary;
            this.lectures = lectures;
            this.gender = gender;
            this.nationality = nationality;
            this.dateOfBirth = dateOfBirth;
            this.workingYear = workingYear;
        }


        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public List<Lecture> Lectures
        {
            get { return lectures; }
            set { lectures = value; }
        }

        public int WorkingYear
        {
            get { return workingYear; }
            set { workingYear = value; }
        }
        public override void ShowMyAcademicInfo()
        {

            for (int i = 0; i < lectures.Count; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Index: "+ (i + 1) + " ID: " + lectures[i].id + " Name: " + lectures[i].Name + " Is Online: " + lectures[i].IsOnline);
            }
        }

    }

}
