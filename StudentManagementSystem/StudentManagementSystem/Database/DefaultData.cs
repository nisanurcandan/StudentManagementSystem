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
            Lecture lct1 = new Lecture("Temel Bilgi Teknolojileri", "COMP101", true, 1, 2);
            Lecture lct2 = new Lecture("Veri Yapıları ve Algoritmalar", "COMP201", false, 3, 1);
            Lecture lct3 = new Lecture("Tasarım Desenleri", "COMP202", false, 2, 1);
            Lecture lct4 = new Lecture("Staj 1", "COMP290", true, 2, 2);
            Lecture lct5 = new Lecture("Yazılım Mimarisi ve Araçları", "COMP301", true, 2, 3);
            Lecture lct6 = new Lecture("Staj 2", "COMP390", true, 2, 1);
            Lecture lct7 = new Lecture("Bilişim Hukuku", "COMP401", false, 1, 2);
            Lecture lct8 = new Lecture("Bitirme Projesi", "COMP498", true, 2, 1);

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
            nisasLectures.Add(lct8);

            List<string> erasmusCountry = new List<string>();

            Dictionary<Lecture, LetterGrades> nisaLetterGrades = new Dictionary<Lecture, LetterGrades>();
            nisaLetterGrades.Add(lct1, LetterGrades.AA);
            nisaLetterGrades.Add(lct2, LetterGrades.CB);
            nisaLetterGrades.Add(lct4, LetterGrades.BB);
            nisaLetterGrades.Add(lct8, LetterGrades.AA);

            List<Lecture> mertsLectures = new List<Lecture>();
            mertsLectures.Add(lct3);
            mertsLectures.Add(lct5);
            mertsLectures.Add(lct6);

            Dictionary<Lecture, LetterGrades> mertLetterGrades = new Dictionary<Lecture, LetterGrades>();
            mertLetterGrades.Add(lct3, LetterGrades.AA);
            mertLetterGrades.Add(lct5, LetterGrades.BA);
            mertLetterGrades.Add(lct6, LetterGrades.FF);


            Professor pro1 = new Professor("Engin Kandıran", "201029001", "123",  "engin.kandiran@yeditepe.edu.tr",
                15000, enginsLectures, Gender.Male, "Turkish", DateTime.Parse("18.05.1982"), 12);

            Professor pro2 = new Professor("Aşkın Demirağ", "2008390201", "123",  "aşkın.demirağ@yeditepe.edu.tr",
                15500, aşkınsLectures, Gender.Male, "Turkish", DateTime.Parse("23.11.1980"), 14);

            Department dpt1 = new Department("Software Development", "290", "College of Applied Sciences", true, pro1.FullName, 447.78224, "Ebru Hoca", 2, erasmusCountry);

            Student std1 = new Student("Nisanur Candan", "20202905003", "123",  "nisanur.candan@std.yeditepe.edu.tr", dpt1,
                2020, 2024, nisasLectures, nisaLetterGrades, Gender.Female, "Turkish", DateTime.Parse("21.09.2002"));

            Student std2 = new Student("Mert Sancar", "20192905004", "123" , "mert.sancar@std.yeditepe.edu.tr", dpt1,
                2019, 2023, mertsLectures, mertLetterGrades, Gender.Male, "Turkish", DateTime.Parse("22.01.2001"));


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
