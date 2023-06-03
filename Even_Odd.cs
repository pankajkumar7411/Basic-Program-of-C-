using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pankaj
{
    internal class Even_Odd
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x % 2 ==0)
            {
                Console.WriteLine("The number is Even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            Console.ReadLine();
        }
    }
}
