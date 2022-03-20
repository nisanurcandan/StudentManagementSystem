using System;
using StudentManagementSystem.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Pages.SetGradePage
{
    class SetGradeManager
    {
        public static SetGradeManager _instance = new SetGradeManager();

        public SetGradeManager()
        {

        }

        public List<Student> GetStudentsByLecture(Lecture lecture)
        {
            List<Student> takeCourseStudents = new List<Student>();
            for (int i = 0; i < DefaultData.students.Count; i++)
            {
                if (DefaultData.students[i].Lectures.Contains(lecture))
                {
                    takeCourseStudents.Add(DefaultData.students[i]);
                }
            }
            return takeCourseStudents;
        }

        public LetterGrades NumberGradeToLetterGrade(int grade)
        {

            if (grade > 90)
            {
                return LetterGrades.AA;
            }
            else if (grade > 85 && 90 < grade)
            {
                return LetterGrades.BA;
            }
            else if (grade > 80 && 85 < grade)
            {
                return LetterGrades.BB;
            }
            else if (grade > 75 && 80 < grade)
            {
                return LetterGrades.CB;
            }
            else if (grade > 60 && 75 < grade)
            {
                return LetterGrades.CC;
            }
            else if (grade > 55 && 60 < grade)
            {
                return LetterGrades.DC;
            }
            else if (grade > 50 && 55 < grade)
            {
                return LetterGrades.DD;
            }
            else
            {
                return LetterGrades.FF;
            }
        }
    }
}
