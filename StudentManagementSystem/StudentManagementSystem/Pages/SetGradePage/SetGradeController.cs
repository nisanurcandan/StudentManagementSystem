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

            Console.WriteLine("1) Choose a Lecture");
            Console.Clear();
            Console.WriteLine("1) Choose a Student");
            Console.Clear();
            Console.WriteLine("1) Set Grade");

        }
    }
}
