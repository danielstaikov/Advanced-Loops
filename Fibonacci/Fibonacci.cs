﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int fibonacciNum = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;
            if (fibonacciNum<2)
            {
                Console.WriteLine("1");
            }
            else
            {
            for (int i = 2; i <= fibonacciNum; i++)
            {

                    int sum = f0 + f1;
                    f0 = f1;
                    f1 = sum;
            }
            Console.WriteLine(f1);
            }

        }
    }
}
