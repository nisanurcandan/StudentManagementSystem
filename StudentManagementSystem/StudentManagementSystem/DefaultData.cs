using StudentManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class DefaultData
    {
        public static List<Professor> professors = new List<Professor>();
        public static List<Student> students = new List<Student>();
        public static List<Department> departments = new List<Department>();
        public static List<Lecture> lectures = new List<Lecture>();

        public DefaultData()
        {
            Lecture lct1 = new Lecture("Temel Bilgi Teknolojileri", "COMP101", true);
            Lecture lct2 = new Lecture("Veri Yapıları ve Algoritmalar", "COMP201", false);
            Lecture lct3 = new Lecture("Tasarım Desenleri", "COMP202", false);
            Lecture lct4 = new Lecture("Staj 1", "COMP290", true);
            Lecture lct5 = new Lecture("Yazılım Mimarisi ve Araçları", "COMP301", true);
            Lecture lct6 = new Lecture("Staj 2", "COMP390", true);
            Lecture lct7 = new Lecture("Bilişim Hukuku", "COMP401", false);
            Lecture lct8 = new Lecture("Bitirme Projesi", "COMP498", true);

            List<Lecture> enginsLectures = new List<Lecture>();
            enginsLectures.Add(lct2);
            enginsLectures.Add(lct3);
            enginsLectures.Add(lct5);

            List<Lecture> aşkınsLectures = new List<Lecture>();
            aşkınsLectures.Add(lct1);
            aşkınsLectures.Add(lct4);
            aşkınsLectures.Add(lct6);

            List<Lecture> nisasLectures = new List<Lecture>();
            nisasLectures.Add(lct1);
            nisasLectures.Add(lct2);
            nisasLectures.Add(lct4);

            List<Lecture> mertsLectures = new List<Lecture>();
            mertsLectures.Add(lct3);
            mertsLectures.Add(lct5);
            mertsLectures.Add(lct6);

            Professor pro1 = new Professor("Engin Kandıran", "123", "201029001", "engin.kandiran@yeditepe.edu.tr",
                15000, enginsLectures, Gender.Male, "Turkish", DateTime.Parse("18.05.1982"));

            Professor pro2 = new Professor("Aşkın Demirağ", "123", "2008390201", "aşkın.demirağ@yeditepe.edu.tr",
                15500, aşkınsLectures, Gender.Male, "Turkish", DateTime.Parse("23.11.1980"));

            Department dpt1 = new Department("Software Development", "290", "College of Applied Sciences", true, pro1.FullName, 447.78224);

            Student std1 = new Student("Nisanur Candan", "123", "20202905003", "nisanur.candan@std.yeditepe.edu.tr", dpt1,
                2020, nisasLectures, Gender.Female, "Turkish", DateTime.Parse("21.09.2002"));

            Student std2 = new Student("Mert Sancar", "123", "20192905004", "mert.sancar@std.yeditepe.edu.tr", dpt1,
                2019, mertsLectures, Gender.Male, "Turkish", DateTime.Parse("22.01.2001"));


            professors.Add(pro1);
            professors.Add(pro2);

            students.Add(std1);
            students.Add(std2);
          
            departments.Add(dpt1);
            
            lectures.Add(lct1);
            lectures.Add(lct2);
            lectures.Add(lct3);
            lectures.Add(lct4);
            lectures.Add(lct5);
            lectures.Add(lct6);
            lectures.Add(lct7);
            lectures.Add(lct8);
        }

       
    }
}
