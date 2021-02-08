using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Phy = 90;
            int che = 85;
            int bio = 85;
            int math = 90;
            int com = 90;

            int grade = (Phy + che + bio + math + com) / 5;
            if (grade >= 90)
                Console.WriteLine("Grade A+ ");
            else if (grade >= 85 && grade < 90)
                Console.WriteLine("Grade A ");
            else if (grade >= 80 && grade < 85)
                Console.WriteLine("Grade B+ ");
            else if (grade >= 75 && grade < 80)
                Console.WriteLine("Grade B ");
            else if (grade >= 50 && grade < 75)
                Console.WriteLine("Grade C+ ");
            else if (grade < 50)
                Console.WriteLine("Grade F+ ");
            else
                Console.WriteLine("E ");
            

        }
    }
}
