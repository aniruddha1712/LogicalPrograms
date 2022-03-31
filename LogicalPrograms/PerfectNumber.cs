using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public static void FindPerfectNum()
        {
            Console.WriteLine("Enter any number:");
            int number=Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            for (int i = 1; i < number; i++)
            {
                if (number%i==0)
                {
                    Console.WriteLine(i);
                    temp += i;
                }
            }
            if(temp==number)
                Console.WriteLine("Entered Number is Perfect Number");
            else
                Console.WriteLine("Entered Number is not a Perfect Number");

        }
    }
}
