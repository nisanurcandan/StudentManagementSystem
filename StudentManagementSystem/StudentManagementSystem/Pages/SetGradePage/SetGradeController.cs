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
            List<Student> takeCourseStudents = SetGradeManager._instance.GetStudentsByLecture(selectedLecture);

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
            LetterGrades newLetterGrade = SetGradeManager._instance.NumberGradeToLetterGrade(grade);
            selectedStudent.Grades[selectedLecture] = newLetterGrade;
            selectedStudent.CalculateGPA();

            Console.WriteLine("Grade was successfully changed");
            string ans = Console.ReadLine();
            MainScreenController._instance.MainScreen();
        }

    }
}
