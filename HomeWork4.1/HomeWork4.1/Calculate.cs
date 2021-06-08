using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._1
{
    class Calculate
    {
        public static void Welcome()
        {
            Console.WriteLine("Здравствуйте вас приветствует математическая программа");
            Console.WriteLine("пажалуйста введите число. ");
        }

        public static int Input()
        {
            string number = Console.ReadLine();
            return Convert.ToInt32(number);
            

        }

        public static int FindFactorial(int number)
        {
            int Factorial = 1;
            
            for (int i = 1; i <= number; i++)
            {
                Factorial *= i;
            }
            return Factorial;
        }


        public static int FindSum(int number)
        { 
            int SumOfNumbers = 0;
            
            for (int i = 1; i <= number; i++)
            {
                SumOfNumbers += i; 
            }
            return SumOfNumbers;
        }

        public static int FindMaxValue(int number)
        {
            int MaxValue = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    MaxValue = i;
                }
            }
            return MaxValue;
        }

        public static void PrintResultFactorial(int result)
        {
            Console.WriteLine("Факториал равен " + result);
        }

        public static void PrintResultSum(int result)
        {
          Console.WriteLine("Сумма от 1 до N равна " + result);
        }

        public static void PrintResultMaxValue(int result)
        {
            Console.WriteLine("Максимальное четное число меньше N равно " + result);
        }
    }
}
