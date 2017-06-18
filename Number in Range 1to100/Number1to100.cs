using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_in_Range_1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            int number = int.Parse(Console.ReadLine());
            bool isNumberIncorect = ((number > 100) || (number < 1));
            if (isNumberIncorect)
            {
                while (isNumberIncorect)
                {
                Console.WriteLine($"Invalid number!");
                Console.Write("Еnter a number in the range [1...100]: ");
                number = int.Parse(Console.ReadLine());
                isNumberIncorect = ((number > 100) || (number < 1));
                }

            }

            Console.WriteLine($"The number is: {number}");
        }
    }
}
