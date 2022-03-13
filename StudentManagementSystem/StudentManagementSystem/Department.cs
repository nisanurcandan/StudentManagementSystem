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
        private string faculty;
        private bool isBachelor;
        private string headOfDepartment;
        private double examScore;
        private string secretaryOfDepartment;
        private int studentCount;
        private List<string> erasmusCountry;


        public Department(string name, string ID, string faculty, bool isBachelor, string headOfDepartment, double examScore, string secretaryOfDepartment, int studentCount, List<string> erasmusCountry) 
        {
            this.name = name;
            this.ID = ID;
            this.faculty = faculty;
            this.isBachelor = isBachelor;
            this.headOfDepartment = headOfDepartment;
            this.examScore = examScore;
            this.secretaryOfDepartment = secretaryOfDepartment;
            this.studentCount = studentCount;
            this.erasmusCountry = erasmusCountry;     
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

        public string SecretaryOfDepartment
        {
            get { return secretaryOfDepartment; }
            set { secretaryOfDepartment = value; }
        }

        public int StudentCount
        {
            get { return studentCount; }
            set { studentCount = value; }
        }

        public List<string> ErasmusCountry
        {
            get { return erasmusCountry; }
            set { erasmusCountry = value; }
        }

    }
}
