using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public static void FindPrimeNum()
        {
            int number, half, i, flag = 0;
            Console.WriteLine("Enter any positive number");
            number = Convert.ToInt32(Console.ReadLine());
            half = number / 2;

            for( i=2;i<=half;i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Number is not prime");
                    flag = 1;
                    break;
                }
            }
            if(flag==0)
                Console.WriteLine("Number is prime");
        }
    }
}
