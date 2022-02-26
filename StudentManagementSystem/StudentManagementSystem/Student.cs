using StudentManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Student
    {
        private string fullName;
        private string ID;
        private string phoneNumber;
        private string email;
        private float GPA;
        private Department department;
        private int startingYear;
        private int graduateYear;
        private string HES;
        private string gender;
        private string nationality;
        private DateTime dateOfBirth;

        public Student(string fullName, string ID, string email, Department department, int startingYear, string gender, string nationality, DateTime dateOfBirth)
        {
            
            this.fullName = fullName;
            this.ID = ID;
            this.email = email;
            this.department = department;
            this.startingYear = startingYear;
            this.gender = gender;
            this.nationality = nationality;
            this.dateOfBirth = dateOfBirth;

        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }





    }
}
