using MySql.Data.MySqlClient;
using StudentManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Data;
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

            List<Lecture> aşkınsLectures = new List<Lecture>();
            aşkınsLectures.Add(lct1);
            aşkınsLectures.Add(lct4);
            aşkınsLectures.Add(lct6);

            Professor pro1 = new Professor("Engin Kandıran", "201029001", "engin.kandiran@yeditepe.edu.tr",
                15000, enginsLectures, Gender.Male, "Turkish", DateTime.Parse("18.05.1982"));

            Professor pro2 = new Professor("Aşkın Demirağ", "2008390201", "aşkın.demirağ@yeditepe.edu.tr",
                15500, aşkınsLectures, Gender.Male, "Turkish", DateTime.Parse("23.11.1980"));

            Department dpt1 = new Department("Software Development", "290", "College of Applied Sciences", true, pro1.FullName, 447.78224);

            Student std1 = new Student("Nisanur Candan", "20202905003", "nisanur.candan@std.yeditepe.edu.tr", dpt1,
                2020, Gender.Female, "Turkish", DateTime.Parse("21.09.2002"));

            Student std2 = new Student("Mert Sancar", "20192905004", "mert.sancar@std.yeditepe.edu.tr", dpt1,
                2019, Gender.Male, "Turkish", DateTime.Parse("22.01.2001"));


            List<Professor> professors = new List<Professor>();
            professors.Add(pro1);
            professors.Add(pro2);

            List<Student> students = new List<Student>();
            students.Add(std1);
            students.Add(std2);

            List<Department> departments = new List<Department>();
            departments.Add(dpt1);

            List<Lecture> lectures = new List<Lecture>();
            lectures.Add(lct1);
            lectures.Add(lct2);
            lectures.Add(lct3);
            lectures.Add(lct4);
            lectures.Add(lct5);
            lectures.Add(lct6);
            lectures.Add(lct7);
            lectures.Add(lct8);

            void ShowProfessor()
            {

                for (int i = 0; i < professors.Count; i++)
                {
                    Console.WriteLine("Fullname: " + professors[i].fullName);
                    Console.WriteLine("ID: " + professors[i].ID);
                    Console.WriteLine("E-mail: " + professors[i].email);
                    Console.WriteLine("Salary: " + professors[i].Salary);
                    Console.WriteLine("Lectures: " + professors[i].Lectures.Count);
                    Console.WriteLine("Gender: " + professors[i].gender);
                    Console.WriteLine("Nationality: " + professors[i].nationality);
                    Console.WriteLine("DateOfBirth: " + professors[i].dateOfBirth);
                    Console.WriteLine("***************************");
                }
               

            }

            void ShowStudents()
            {

                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine("Fullname: " + students[i].fullName);
                    Console.WriteLine("ID: " + students[i].ID);
                    Console.WriteLine("E-mail: " + students[i].email);
                    Console.WriteLine("Department: " + students[i].Department.Name);
                    Console.WriteLine("StartingYear: " + students[i].StartingYear);
                    Console.WriteLine("Gender: " + students[i].gender);
                    Console.WriteLine("Nationality: " + students[i].nationality);
                    Console.WriteLine("DateOfBirth: " + students[i].dateOfBirth);
                    Console.WriteLine("***************************");
                }


            }

            void ShowLectures()
            {

                for (int i = 0; i < lectures.Count; i++)
                {
                    Console.WriteLine("Name: " + lectures[i].Name);
                    Console.WriteLine("ID: " + lectures[i].id);
                    Console.WriteLine("isOnline: " + lectures[i].IsOnline);
                    Console.WriteLine("***************************");
                }


            }


            void ShowDepartments()
            {

                for (int i = 0; i < departments.Count; i++)
                {
                    Console.WriteLine("Name: " + departments[i].Name);
                    Console.WriteLine("ID: " + departments[i].id);
                    Console.WriteLine("Faculty: " + departments[i].Faculty);
                    Console.WriteLine("IsBachelor: " + departments[i].IsBachelor);
                    Console.WriteLine("HeadOfDepartment: " + departments[i].HeadOfDepartment);
                    Console.WriteLine("ExamScore: " + departments[i].ExamScore);
                    Console.WriteLine("***************************");
                }


            }



            Console.WriteLine("***************STUDENT MANAGEMENT SYSTEM***************");

            Console.WriteLine("1-Professor");
            Console.WriteLine("2-Student");
            Console.WriteLine("3-Lecture");
            Console.WriteLine("4-Department");

            bool isInvalid = true;
            while (isInvalid)
            {
                Console.WriteLine("Choose a number?");
                string number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        ShowProfessor();
                        isInvalid = false;
                        break;

                    case "2":
                        ShowStudents();
                        isInvalid = false;
                        break;

                    case "3":
                        ShowLectures();
                        isInvalid = false;
                        break;

                    case "4":
                        ShowDepartments();
                        isInvalid = false;
                        break;

                    default:
                        Console.WriteLine("Invalid answer");
                        break;
                }
            }
            

            //// ********************************** VERİTABANI TEST ******************************************
            //MySqlConnection cn;
            //MySqlCommand command;

            //cn = new MySqlConnection("Datasource = 127.0.0.1;username=root;password=;database=studentmanagment");
            //cn.Open();
            //command = new MySqlCommand("Select * from test_user", cn);
            //MySqlDataReader rdr = command.ExecuteReader();

            //List<string> names = new List<string>();
            //while (rdr.Read())
            //{
            //    names.Add(rdr[1].ToString());
            //    //Console.WriteLine("ID: " + rdr[0] + " Name: " + rdr[1]);
            //}

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

        }


    }
}
