using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicateelements
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

            Console.WriteLine("Duplicate elements in given array: ");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        Console.WriteLine(array[j]);
                }
            }
        }
    }
}
