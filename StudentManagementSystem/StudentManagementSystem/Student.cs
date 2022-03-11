using StudentManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Student : User
    {
        
        private float GPA;
        private Department department;
        private int startingYear;
        private int graduateYear;
        private List<Lecture> lectures;
        private Dictionary<Lecture, LectureGrades> grades = new Dictionary<Lecture, LectureGrades>();

        public Student(string fullName, string ID, string password, string email, Department department, int startingYear, List<Lecture> lectures, Dictionary<Lecture, LectureGrades> grades, Gender gender, string nationality, DateTime dateOfBirth)
            : base(fullName, ID, password, email, gender, nationality, dateOfBirth)
        {

            this.fullName = fullName;
            this.ID = ID;
            this.email = email;
            this.department = department;
            this.startingYear = startingYear;
            this.lectures = lectures;
            this.grades = grades;
            this.gender = gender;
            this.nationality = nationality;
            this.dateOfBirth = dateOfBirth;

        }

        public Department Department
        {
            get { return department; }
            set { department = value; }
        }

        public int StartingYear
        {
            get { return startingYear; }
            set { startingYear = value; }
        }

        public List<Lecture> Lectures
        {
            get { return lectures; }
            set { lectures = value; }
        }

        public Dictionary<Lecture, LectureGrades> Grades
        {
            get { return grades; }
            set { grades = value; }
        }
    }
}
