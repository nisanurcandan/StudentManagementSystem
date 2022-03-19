using MySql.Data.MySqlClient;
using StudentManagementSystem.Enums;
using StudentManagementSystem.Pages.SetGradePage;
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
