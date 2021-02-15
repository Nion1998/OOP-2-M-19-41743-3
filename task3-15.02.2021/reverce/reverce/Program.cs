using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverce
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
           
            Console.Write("Enter Array Size: ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] array1 = new int[n];
            Console.WriteLine("Enter Array {0} Element: ", n);
            for (int i = 0; i < n; i++)
            {
                array1[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.Write("Revers of the Array: ");
            for (int i = array1.Length - 1; i >= 0; i--)
            {
                Console.Write(array1[i] + " ");
            }
           
        }
    }
}
