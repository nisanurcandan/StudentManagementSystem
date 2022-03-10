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
        private int workingYear;
        private int salary;
        private List<Lecture> lectures;

        public Professor (string fullName, string ID, string password, string email, int salary, List<Lecture> lectures, Gender gender, string nationality, DateTime dateOfBirth) 
            : base(fullName, ID, password, email, gender, nationality,dateOfBirth)
        {
            this.fullName = fullName;
            this.ID = ID;
            this.email = email;
            this.salary = salary;
            this.lectures = lectures;
            this.gender = gender;
            this.nationality = nationality;
            this.dateOfBirth = dateOfBirth;
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


    }

}
