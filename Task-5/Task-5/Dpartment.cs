using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    class Department
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private int studentCount;
        public int StudentCount
        {
            get { return studentCount; }
            set { studentCount = value; }
        }

        private Student[] students;

        public void AddStudent(params Student[] stu)
        {
            foreach (Student s in stu)
            {
                students[studentCount++] = s;
            }
        }


        public void PrintStudents()
        {
            for (int i = 0; i < studentCount; i++)
            {
                students[i].ShowInfo();
            }
        }
        public Student GetStudent(string id)
        {
            return null;
        }
        public Department() { }
        public Department(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
        }

    }
}