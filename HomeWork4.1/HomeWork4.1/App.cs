using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._1
{
    class App
    {
        public static void StartApp()
        {
            Calculate.Welcome();
            var Number = Calculate.Input();
            Calculate.PrintResultFactorial(Calculate.FindFactorial(Number));
            Calculate.PrintResultSum(Calculate.FindSum(Number));
            Calculate.PrintResultMaxValue(Calculate.FindMaxValue(Number));
           
            Console.ReadLine();
        }
    }
}
