using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatchNew
    {
        public static void Timer()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Console.WriteLine("enter num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num = num1 + num2;
            timer.Stop();
            Console.WriteLine("Time elapsed: {0}",timer.ElapsedMilliseconds);
        }
    }
}
