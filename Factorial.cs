using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pankaj
{
    internal class Factorial
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            int x = int.Parse(Console.ReadLine());
            int fact =1;
            for(int i=1; i<=x; i++)
                {
                fact = fact * i;
            }
            Console.WriteLine("The factorial of "+x+" is: "+fact);
            Console.ReadLine();
        }
    }
}
