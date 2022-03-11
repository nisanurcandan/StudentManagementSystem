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
            if (_instance == null)
            {
                _instance = this;
            }
        }

        public bool UserAuthentication(string id, string password)
        {
            bool isOK = false;
            // Girilen bilgiler burada kontrol edilecek.

            for (int i = 0; i < DefaultData.students.Count; i++)
            {
                Console.WriteLine(DefaultData.students[i]);
                if (id == DefaultData.students[i].ID && password == "123")
                {
                    isOK = true;
                    Console.WriteLine("Login successful");
                    break;
                }
                else
                {
                    isOK = false;
                    Console.WriteLine("Try Again");
                }
            }

            for (int i = 0; i < DefaultData.professors.Count; i++)
            {
                Console.WriteLine(DefaultData.professors[i]);
                if (id == DefaultData.professors[i].ID && password == "123")
                {
                    isOK = true;
                    Console.WriteLine("Login successful");
                    break;
                }
                else
                {
                    isOK = false;
                    Console.WriteLine("Try Again");
                }

            }

            return isOK;
        }
    }
}
