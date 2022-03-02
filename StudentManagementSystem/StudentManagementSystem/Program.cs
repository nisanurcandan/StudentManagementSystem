using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
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


            Professor pro1 = new Professor("Engin Kandıran", "201029001", "engin.kandiran@yeditepe.edu.tr",
                15000, enginsLectures, "Male", "Turkish", DateTime.Parse("18.05.1982"));

            Department dpt1 = new Department("Software Development","290", "College of Applied Sciences", true, pro1.FullName, 447.78224);

            Student std1 = new Student("Nisanur Candan", "20202905003", "nisanur.candan@std.yeditepe.edu.tr", dpt1,
                2020, "female", "Turkish", DateTime.Parse("21.09.2002"));

            Console.WriteLine(std1.FullName);
            Console.WriteLine(std1.id);
            Console.WriteLine(std1.Email);
            Console.WriteLine(std1.Department);
            Console.WriteLine(std1.StartingYear);
            Console.WriteLine(std1.Gender);
            Console.WriteLine(std1.Nationality);

            Console.WriteLine("*******************");

            Console.WriteLine(pro1.FullName);
            Console.WriteLine(pro1.id);
            Console.WriteLine(pro1.Email);
            Console.WriteLine(pro1.Salary);
            Console.WriteLine(pro1.Lectures[0].Name); 
            Console.WriteLine(pro1.Gender);
            Console.WriteLine(pro1.Nationality);
            Console.WriteLine(pro1.DateOfBirth);

            Console.WriteLine("*******************");

            Console.WriteLine(dpt1.Name);
            Console.WriteLine(dpt1.id);
            Console.WriteLine(dpt1.Faculty);
            Console.WriteLine(dpt1.IsBachelor);
            Console.WriteLine(dpt1.HeadOfDepartment);
            Console.WriteLine(dpt1.ExamScore);

            Console.WriteLine("*******************");

            for (int i = 0; i < enginsLectures.Count; i++)
            {
                Console.WriteLine(enginsLectures[i].Name); 
                Console.WriteLine(enginsLectures[i].id);
                Console.WriteLine(enginsLectures[i].IsOnline);

                Console.WriteLine("*******************");

            }




        }


    }
}
