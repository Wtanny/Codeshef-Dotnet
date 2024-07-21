using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Factorial
    {
        int i, fact = 1, num;

        public void fac()
        {
            Console.WriteLine("Enter a number:");
            num =Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
              
            }
            Console.WriteLine("Factorial of a number" + fact);
            Console.ReadLine();
        }


    }
}
