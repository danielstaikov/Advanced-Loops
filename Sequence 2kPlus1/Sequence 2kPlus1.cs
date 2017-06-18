using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            //предишното число * 2 + 1
            int numbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numbers; i = i*2+1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
