using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Nion", "19-41743-3", 3.55f);
            Student s2 = new Student("Mehedi", "19-40022-1", 3.88f);
            Student s3 = new Student("Mim", "19-40128-2", 3.72f);

            Department d1 = new Department("Computer Science Engineering", "CSE");
            Department d2 = new Department("Electrionic Electical Engineering", "EEE");

            s1.Dept = d1;
            d1.AddStudent();

            s2.Dept = d1;
            s3.Dept = d2;
           
            s1.ShowSudentDeatils();
            s3.ShowSudentDeatils();
            Console.WriteLine("              ");
            d1.Name = "Computer Science and Engineering";
            d1.Id = "CSE";
            s2.ShowSudentDeatils();
        }
    }
}