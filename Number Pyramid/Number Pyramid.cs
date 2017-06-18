using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j > 1) Console.Write(" ");
                    Console.Write(sum);
                    sum++;
                    if (sum > n) break;

                }
                Console.WriteLine();
                if (sum > n) break;

            }
        }
    }
}
