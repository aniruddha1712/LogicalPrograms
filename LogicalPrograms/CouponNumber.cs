using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class CouponNumber
    {
        public static void FindCoupons()
        {
            int i = 1, count=0,min,max,number;

            Console.WriteLine("Enter how many numbers you want to generate?");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the lower range:");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper range:");
            max = Convert.ToInt32(Console.ReadLine());
            int range = max - min;

            Random random = new Random();
            List<int> list = new List<int>();
            if (number < range)
            {
                while(i<=number)
                {
                    int coupon = random.Next(min, max);
                    count++;
                    if(!list.Contains(coupon))
                    {
                        list.Add(coupon);
                        i++;
                        Console.Write(" "+coupon);
                    }
                }
            Console.WriteLine("\nWe needed {0} Random numbers to generate {1} distinct coupon numbers.", count, number);
            }
            else
            {
                Console.WriteLine("Cannot generate {0} coupon numbers in {1} range is short", number, range);
            }
        }
    }
}
