using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pankaj
{
    internal class PrimeNumber
    {
        static void Main()
        {
            int n, m = 0, flag = 0, i;
            Console.WriteLine("Enter the number to check Prime:");
            n = Convert.ToInt32(Console.ReadLine());
           // m = n/2;
            for (i = 2; i <= n; i++)
            {
                if(n%2==0)
                {
                    Console.WriteLine("Number is not Prime:");
                    flag++;
                  
                }
            }
            if(flag==2)
            {
                Console.WriteLine("Number is Prime:");
            }
            Console.ReadLine();
        }
    }
}
