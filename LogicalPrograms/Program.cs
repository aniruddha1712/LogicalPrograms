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
            Console.WriteLine("1:Fibonacci\n2:PerfectNumber\n3:PrimeNumber");
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
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
