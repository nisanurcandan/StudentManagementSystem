using StudentManagementSystem.Enums;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class User
    {

        public string fullName;
        public string ID;
        public string password;
        public Gender gender;
        public string nationality;
        public DateTime dateOfBirth;
        public string email;
        public string phoneNumber;
        public string HES;
        public List<Message> inbox = new List<Message>();


        public User(string fullName, string ID, string password, string email, Gender gender, string nationality, DateTime dateOfBirth)
        {
            this.fullName = fullName;
            this.ID = ID;
            this.password = password;
            this.email = email;
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
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Gender Gender
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

        public void ShowMyPersonalInfo()
        {
            Console.WriteLine("Fullname: " + fullName);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("E-mail: " + email); ;
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Nationality: " + nationality);
            Console.WriteLine("Birth Date: " + dateOfBirth);
        }

        public virtual void ShowMyAcademicInfo()
        {

        }

    }

}
