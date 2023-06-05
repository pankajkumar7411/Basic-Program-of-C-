using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pankaj
{
    internal class FibonacciSerise
    {
        static void Main()
        {
            int num1 = 1, num2 = 2, num3, number;
            Console.WriteLine("Enter the number of Elements: ");
            number = int.Parse(Console.ReadLine());
            for(int i =2;i<number;i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
            Console.ReadLine();
        }
    }
}
