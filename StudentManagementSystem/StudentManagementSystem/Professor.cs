using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Professor
    {
        private string fullName;
        private string ID;
        private int workingYear;
        private int salary;
        private List<Lecture> lectures;
        private string email;
        private string phoneNumber;
        private string HES;
        private string gender;
        private string nationality;
        private DateTime dateOfBirth;

        public Professor (string fullName, string ID, string email, int salary, List<Lecture> lectures, string gender, string nationality, DateTime dateOfBirth)
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

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string id
        {
            get { return ID; }
            set { ID = value; }

        }

        public string Email
        {
            get { return email; }
            set { email = value; }
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

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        } 

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }









    }

}
