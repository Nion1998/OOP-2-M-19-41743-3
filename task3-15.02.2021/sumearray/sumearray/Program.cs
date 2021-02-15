using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumearray
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
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Sum of the Array: " + sum);

        }
    }
}
