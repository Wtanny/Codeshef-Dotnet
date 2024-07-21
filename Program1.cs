using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program1
    {
        int n1, n2, Rem;
       public  void gcd()
        {

            Console.WriteLine("Enter the 1 number:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2 number:");
            int n2 = Convert.ToInt32(Console.ReadLine());



            while (n2 != 0)
            {
                Rem = n1 % n2;
                n1 = n2;
                n2 = Rem;
            }
            //return Rem;
            Console.Write("Greatest Common Divisior:");
            Console.WriteLine("\t"+n1);
        }
    }
}



