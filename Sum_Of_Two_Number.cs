using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pankaj
{
    internal class Sum_Of_Two_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum of two number is:" + sum);
            Console.ReadLine();
        }
    }
}
