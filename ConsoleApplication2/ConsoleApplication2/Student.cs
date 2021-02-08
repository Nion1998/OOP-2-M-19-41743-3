using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Student
    {
        private String name;
        private String id;
        private String department;
        private float cgpa;



        public Student()
        {
            Console.WriteLine(" Default Constructor");
        }



        public string Name
        {
            set { name = value; }
            get { return name; }
        }



        public string Id
        {
            set { id = value; }
            get { return id; }
        }



        public string Department
        {
            set { department = value; }
            get { return department; }
        }



        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }



        public void ShowInfo()
        {
            Console.WriteLine("Student Name :" + name);
            Console.WriteLine("Student Id  :" + id);
            Console.WriteLine("Student department :" + department);
            Console.WriteLine("Student cgpa :" + cgpa);
        }
    }
}
