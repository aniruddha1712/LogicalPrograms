using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public static void FindReverse()
        {
            int remainder, reverse = 0, number;
            Console.WriteLine("Enter number to get its Reverse");
            number = Convert.ToInt32(Console.ReadLine());

            while(number>0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }
            Console.WriteLine("Reversed number is :{0}", reverse);
        }
    }
}
