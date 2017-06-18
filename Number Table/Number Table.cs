using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                   int sum = i + j +1;

                    if (sum > n)
                    {
                        sum = 2 * n - sum;
                    }

                    Console.Write(sum + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
