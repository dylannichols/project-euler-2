using System;

namespace project_euler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = 1;
            var num2 = 2;
            var newNum = 0;
            var sum = 2;

            while (newNum <= 4000000)
            {
                newNum = num1 + num2;
                if (newNum % 2 == 0)
                {
                    sum += newNum;
                }
                num1 = num2;
                num2 = newNum;
            }

            Console.WriteLine("The sum is " + sum);
        }
    }
}
