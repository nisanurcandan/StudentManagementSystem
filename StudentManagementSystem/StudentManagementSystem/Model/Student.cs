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
        private Dictionary<Lecture, LetterGrades> grades = new Dictionary<Lecture, LetterGrades>();

        public Student(string fullName, string ID, string password, string email, Department department, int startingYear, int graduateYear, List<Lecture> lectures, Dictionary<Lecture, LetterGrades> grades, float GPA, Gender gender, string nationality, DateTime dateOfBirth)
            : base(fullName, ID, password, email, gender, nationality, dateOfBirth)
        {

            this.fullName = fullName;
            this.ID = ID;
            this.password = password;
            this.email = email;
            this.department = department;
            this.startingYear = startingYear;
            this.graduateYear = graduateYear;
            this.lectures = lectures;
            this.grades = grades;
            this.GPA = GPA;
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

        public int GraduateYear
        {
            get { return graduateYear; }
            set { graduateYear = value; }
        }

        public List<Lecture> Lectures
        {
            get { return lectures; }
            set { lectures = value; }
        }

        public Dictionary<Lecture, LetterGrades> Grades
        {
            get { return grades; }
            set { grades = value; }
        }

        public override void ShowMyAcademicInfo()
        {
            Console.WriteLine("Department: " + department.Name);
            Console.WriteLine("Starting Year: " + startingYear);
            Console.WriteLine("Graduate Year (Approximately): " + (startingYear+4));
            Console.WriteLine("GPA: " + GPA);
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < lectures.Count; i++)
            {
                Console.WriteLine("Lecture ID: " + lectures[i].id + "   " + "Grade: " + grades[lectures[i]]);
            }
        }
    }
}
