using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int reminder = num % 10;

            while ((reminder != 0) || (num != 0))
            {
                num = num / 10;
                sum += reminder;
                reminder = num % 10;
            }


            Console.WriteLine(sum);
        }
    }
}
