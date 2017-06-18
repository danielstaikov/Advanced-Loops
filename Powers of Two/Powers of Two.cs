using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int i = 0 ; i <= numbers; i++)
            {
                int powersOfTwo = (int) Math.Pow(2, i);
                Console.WriteLine(powersOfTwo);
            }
        }
    }
}
