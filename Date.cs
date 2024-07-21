using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Date
    {
        
        public void calculate()
        {
            Console.WriteLine("Enter your birth date in ");
            var bdate = Convert.ToDateTime(Console.ReadLine());
            Console.ReadLine();

            //Console.WriteLine("Birth date:" + bdate);
            var age = DateTime.Now.Year - bdate.Year;
            Console.WriteLine("your current age is:" + age); 

            //var bdate = new DateTime(2002, 10, 09);
            //var age = DateTime.Now.Year - bdate.Year;

            //Console.WriteLine("Current age :" + age);
            Console.ReadLine();
            

        }
    }
}
