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

        public bool UserAuthentication()
        {
            bool isOK = false;
            // Girilen bilgiler burada kontrol edilecek.
            return isOK;
        }
    }
}
