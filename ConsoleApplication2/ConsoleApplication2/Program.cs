using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            Console.Write("Enter Name: ");
            s1.Name = Console.ReadLine();

            Console.Write("Enter ID: ");
            s1.Id = Console.ReadLine();

            Console.Write("Enter Department: ");
            s1.Department = Console.ReadLine();


            Console.Write("Enter CGPA: ");
            s1.Cgpa = float.Parse(Console.ReadLine());

            s1.ShowInfo();




            Triangle s2 = new Triangle();

            Console.Write("Enter X : ");
            s2.X = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y : ");
            s2.Y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Z : ");
            s2.Z = Convert.ToInt32(Console.ReadLine());

            s2.ShowInfo();





            Account s3 = new Account();

            Console.Write("Enter ACC name : ");
            s3.AccName = Console.ReadLine();

            Console.Write("Enter ACC ID: ");
            s3.Acid = Console.ReadLine();

            Console.Write("Enter Dipo amm: ");
            s3.Deposit ( Convert.ToInt32(Console.ReadLine()));

            Console.Write("Enter Withdrow amm: ");
            s3.Withdraw (Convert.ToInt32(Console.ReadLine()));






            Course course = new Course();

            Console.Write("Enter Course Name: ");
            course.CourseName = Console.ReadLine();

            Console.Write("Enter Course Code: ");
            course.CourseCode = Console.ReadLine();

            Console.Write("Enter Course Credit: ");
            course.CourseCredit = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");
            course.ShowCourseInfo();






 
        }
    }
}
