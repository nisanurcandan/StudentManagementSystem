using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Lecture
    {
        private string name;
        private string ID;
        private int labHour;
        private int theoreticalHour;
        private bool isOnline;


        public Lecture(string name, string ID, bool isOnline)
        {
            this.name = name;
            this.ID = ID;
            this.isOnline = isOnline;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        } 

        public string id
        {
            get { return ID; }
            set { ID = value; }
        }

        public bool IsOnline
        {
            get { return isOnline; }
            set { isOnline = value; }
        }
        
    }
}
