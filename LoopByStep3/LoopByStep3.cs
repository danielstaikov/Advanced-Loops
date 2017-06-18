using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int numbers = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers are:");
            for (int i = 1; i <= numbers; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
