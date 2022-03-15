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
        private bool isOnline;
        private int labHour;
        private int theoreticalHour;


        public Lecture(string name, string ID, bool isOnline, int labHour, int theoreticalHour)
        {
            this.name = name;
            this.ID = ID;
            this.isOnline = isOnline;
            this.labHour = labHour;
            this.theoreticalHour = theoreticalHour;
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

        public int LabHour
        {
            get { return labHour; }
            set { labHour = value; }
        }

        public int TheoreticalHour
        {
            get { return theoreticalHour; }
            set { theoreticalHour = value; }
        }
    }
}
