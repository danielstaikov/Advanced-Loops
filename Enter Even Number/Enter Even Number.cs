using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumberEven = true;
            int number = 0;
            try
            {
            Console.Write("Enter even number: ");
            number = int.Parse(Console.ReadLine());
            isNumberEven = (number % 2 != 0);
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid number.");
            }

            if (isNumberEven)
            {

                    Console.WriteLine("The number is not even.");

                while (isNumberEven)
                {


                    try
                    {

                        Console.Write("Enter even number: ");
                        number = int.Parse(Console.ReadLine());
                        isNumberEven = (number % 2 != 0);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Invalid number.");

                    }

                }

            }

            Console.WriteLine($"Even number entered: {number}");
        }
    }
}
