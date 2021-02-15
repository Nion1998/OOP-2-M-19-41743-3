using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter Array Size: ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter Array {0} Element: ", n);
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }


            int[] anotherArray = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                anotherArray[i] = array[i];
            }
            Console.Write("Another Array Elements: ");
            for (int i = 0; i < anotherArray.Length; i++)
            {
                Console.Write(anotherArray[i] + " ");
            }
            Console.WriteLine( " ");
        }
    }
}
