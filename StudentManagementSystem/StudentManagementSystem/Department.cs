using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Department
    {
        private string name;
        private string ID;
        private string headOfDepartment;
        private string secretaryOfDepartment;
        private bool isBachelor;
        private int studentCount;
        private string faculty;
        private double examScore;
        private List<string> erasmusCountry;


        public Department(string name, string ID, string faculty, bool isBachelor, string headOfDepartment, double examScore) 
        {
            this.name = name;
            this.ID = ID;
            this.faculty = faculty;
            this.isBachelor = isBachelor;
            this.headOfDepartment = headOfDepartment;
            this.examScore = examScore;
            
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

        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public bool IsBachelor
        {
            get { return isBachelor; }
            set { isBachelor = value; }
        }

        public string HeadOfDepartment
        {
            get { return headOfDepartment; }
            set { headOfDepartment = value; }
        }

        public double ExamScore
        {
            get { return examScore; }
            set { examScore = value; }
        }


    }
}
