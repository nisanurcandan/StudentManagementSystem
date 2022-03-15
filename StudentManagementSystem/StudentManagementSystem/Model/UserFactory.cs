using StudentManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    class UserFactory
    {
        public static User Factory(UserType userType, userData)
        {
            User user = null;
            switch (userType)
            {
                case UserType.Student:
                    user = new Student(userData);
                    break;
                case UserType.Professor:
                    user = new Professor();
                    break;
                default:
                    break;
            }

            return user;

        }
    }
}
