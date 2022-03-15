using StudentManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{

    class LoginScreenController
    {
        public static LoginScreenController _instance = new LoginScreenController();


        public LoginScreenController()
        {
        }

        public void UserAuthentication(string id, string password)
        {
            bool isValid = LoginScreenManager._instance.UserAuthentication(id, password);
            if (isValid)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("NO");
            }

            
        }
    }
}
