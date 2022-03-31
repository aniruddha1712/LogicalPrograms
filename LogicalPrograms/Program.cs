using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs of C#");
            Console.WriteLine("1:Fibonacci\n2:PerfectNumber\n3:PrimeNumber\n" +
                "4:ReverseNumber\n5:CouponNumber");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Fibonacci.FindSeries();
                    break;
                case 2:
                    PerfectNumber.FindPerfectNum();
                    break;
                case 3:
                    PrimeNumber.FindPrimeNum();
                    break;
                case 4:
                    ReverseNumber.FindReverse();
                    break;
                case 5:
                    CouponNumber.FindCoupons();
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
