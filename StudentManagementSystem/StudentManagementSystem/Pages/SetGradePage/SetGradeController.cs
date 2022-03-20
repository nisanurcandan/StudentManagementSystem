using StudentManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Pages.SetGradePage
{
    class SetGradeController
    {
        public static SetGradeController _instance = new SetGradeController();

        public SetGradeController()
        {
        }

        public void SetGradeScreen()
        {
            Professor currentProf = (Professor)CurrentUser.currentUser;
            currentProf.ShowMyAcademicInfo();

            Console.WriteLine("Choose a lecture");
            int lectureIndex = int.Parse(Console.ReadLine());
            Lecture selectedLecture = currentProf.Lectures[lectureIndex - 1];
            List<Student> takeCourseStudents = new List<Student>();
            for (int i = 0; i < DefaultData.students.Count; i++)
            {
                if(DefaultData.students[i].Lectures.Contains(selectedLecture))
                {
                    takeCourseStudents.Add(DefaultData.students[i]);
                }
                  
            }

            Console.Clear();
            for (int i = 0; i < takeCourseStudents.Count; i++)
            {
                Console.WriteLine("Index: " + (i + 1) + " ID: " + takeCourseStudents[i].id + " Name: " + takeCourseStudents[i].fullName );
            }

            Console.WriteLine("Choose a student");
            int studentIndex = int.Parse(Console.ReadLine());
            Student selectedStudent = takeCourseStudents[studentIndex - 1];
            Console.Clear();
            Console.WriteLine("Enter a grade for student");
            int grade = int.Parse(Console.ReadLine());

            if (grade > 90)
            {
                selectedStudent.Grades[selectedLecture] = LetterGrades.AA;
            }
            else if (grade > 85 && 90 < grade)
            {
                selectedStudent.Grades[selectedLecture] = LetterGrades.BA;
            }
            else if (grade > 80 && 85 < grade)
            {
                selectedStudent.Grades[selectedLecture] = LetterGrades.BB;
            }
            else if (grade > 75 && 80 < grade)
            {
                selectedStudent.Grades[selectedLecture] = LetterGrades.CB;
            }
            else if (grade > 60 && 75 < grade)
            {
                selectedStudent.Grades[selectedLecture] = LetterGrades.CC;
            }
            else if (grade > 55 && 60 < grade)
            {
                selectedStudent.Grades[selectedLecture] = LetterGrades.DC;
            }
            else if (grade > 50 && 55 < grade)
            {
                selectedStudent.Grades[selectedLecture] = LetterGrades.DD;
            }
            else
            {
                selectedStudent.Grades[selectedLecture] = LetterGrades.FF;
            }






        }




    }
}
