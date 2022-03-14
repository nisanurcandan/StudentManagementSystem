using StudentManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class LoginScreenManager
    {
        public static LoginScreenManager _instance = new LoginScreenManager();

        public LoginScreenManager()
        {
        }

        public bool UserAuthentication(string id, string password)
        {

            for (int i = 0; i < DefaultData.students.Count; i++)
            {
                if (id == DefaultData.students[i].id && password == DefaultData.students[i].password)
                {
                    CurrentUser.currentUser = DefaultData.students[i];
                    CurrentUser.userType = UserType.Student;
                    return true;
                }
            }

            for (int i = 0; i < DefaultData.professors.Count; i++)
            {
                if (id == DefaultData.professors[i].id && password == DefaultData.professors[i].password)
                {
                    CurrentUser.currentUser = DefaultData.professors[i];
                    CurrentUser.userType = UserType.Professor;
                    return true;
                }
            }

            return false;

        }
    }
}
