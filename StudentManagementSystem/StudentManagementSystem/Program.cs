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


            DefaultData defaultData = new DefaultData();
            LoginScreenController._instance.LoginScreen();



                
        

        //void ShowProfessor()
        //{

        //    for (int i = 0; i < professors.Count; i++)
        //    {
        //        Console.WriteLine("Fullname: " + professors[i].fullName);
        //        Console.WriteLine("ID: " + professors[i].ID);
        //        Console.WriteLine("E-mail: " + professors[i].email);
        //        Console.WriteLine("Salary: " + professors[i].Salary);
        //        Console.WriteLine("Lectures: " + professors[i].Lectures.Count);
        //        Console.WriteLine("Gender: " + professors[i].gender);
        //        Console.WriteLine("Nationality: " + professors[i].nationality);
        //        Console.WriteLine("DateOfBirth: " + professors[i].dateOfBirth);
        //        Console.WriteLine("***************************");
        //    }


        //}

        //void ShowStudents()
        //{

        //    for (int i = 0; i < students.Count; i++)
        //    {
        //        Console.WriteLine("Fullname: " + students[i].fullName);
        //        Console.WriteLine("ID: " + students[i].ID);
        //        Console.WriteLine("E-mail: " + students[i].email);
        //        Console.WriteLine("Department: " + students[i].Department.Name);
        //        Console.WriteLine("StartingYear: " + students[i].StartingYear);
        //        Console.WriteLine("Gender: " + students[i].gender);
        //        Console.WriteLine("Nationality: " + students[i].nationality);
        //        Console.WriteLine("DateOfBirth: " + students[i].dateOfBirth);
        //        Console.WriteLine("***************************");
        //    }


        //}

        //void ShowLectures()
        //{

        //    for (int i = 0; i < lectures.Count; i++)
        //    {
        //        Console.WriteLine("Name: " + lectures[i].Name);
        //        Console.WriteLine("ID: " + lectures[i].id);
        //        Console.WriteLine("isOnline: " + lectures[i].IsOnline);
        //        Console.WriteLine("***************************");
        //    }


        //}


        //void ShowDepartments()
        //{

        //    for (int i = 0; i < departments.Count; i++)
        //    {
        //        Console.WriteLine("Name: " + departments[i].Name);
        //        Console.WriteLine("ID: " + departments[i].id);
        //        Console.WriteLine("Faculty: " + departments[i].Faculty);
        //        Console.WriteLine("IsBachelor: " + departments[i].IsBachelor);
        //        Console.WriteLine("HeadOfDepartment: " + departments[i].HeadOfDepartment);
        //        Console.WriteLine("ExamScore: " + departments[i].ExamScore);
        //        Console.WriteLine("***************************");
        //    }


        //}



        //Console.WriteLine("***************STUDENT MANAGEMENT SYSTEM***************");

        //Console.WriteLine("1-Professor");
        //Console.WriteLine("2-Student");
        //Console.WriteLine("3-Lecture");
        //Console.WriteLine("4-Department");

        //bool isInvalid = true;
        //while (isInvalid)
        //{
        //    Console.WriteLine("Choose a number?");
        //    string number = Console.ReadLine();
        //    switch (number)
        //    {
        //        case "1":
        //            ShowProfessor();
        //            isInvalid = false;
        //            break;

        //        case "2":
        //            ShowStudents();
        //            isInvalid = false;
        //            break;

        //        case "3":
        //            ShowLectures();
        //            isInvalid = false;
        //            break;

        //        case "4":
        //            ShowDepartments();
        //            isInvalid = false;
        //            break;

        //        default:
        //            Console.WriteLine("Invalid answer");
        //            break;
        //    }
        //}


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
