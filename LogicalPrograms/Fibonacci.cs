using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class Fibonacci
    {
        public static void FindSeries()
        {
            int num1 = 0, num2 = 1, num3, number, i;
            Console.WriteLine("enter the Number of elements you want!!");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1+" "+num2+" ");

            for (i = 2; i < number; i++)
            {
                num3 = num1 + num2;
                Console.Write(" "+num3+" ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
