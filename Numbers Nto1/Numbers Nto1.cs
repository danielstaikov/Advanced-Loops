using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_Nto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int i = numbers; i >= 1; i --)
            {
                Console.WriteLine(i);
            }
        }
    }
}
