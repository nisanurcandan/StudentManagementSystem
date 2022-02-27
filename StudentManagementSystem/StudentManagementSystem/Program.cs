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
            Student std1 = new Student("Nisanur Candan", "20202905003",
                "nisanur.candan@std.yeditepe.edu.tr", Enums.Department.SoftwareDevelopment, 
                2020, "female", "Turkish", DateTime.Parse("21.09.2002"));

            Console.WriteLine(std1.FullName);
            Console.WriteLine(std1.id);
            Console.WriteLine(std1.Email);
            Console.WriteLine(std1.Department);
            Console.WriteLine(std1.StartingYear);
            Console.WriteLine(std1.Gender);
            Console.WriteLine(std1.Nationality);

        }
    }
}
