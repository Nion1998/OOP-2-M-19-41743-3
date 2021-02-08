using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenoddsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            int even = 0;
            int odd = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    
                    even += i;
                }
                else
                {
                    odd += i;
                }
            }
            Console.WriteLine("ALL EVEN SUM ="+even);
            Console.WriteLine("ALL ODD SUM =" + odd);
        }

    }
}
