using System;

namespace Switching_Inputs
{
    class Program
    {
        public static int answerSubtract { get; private set; }
        public static object MessageBox { get; private set; }

        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 6;

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.Write(num1 + " " + num2);
        }
    }
}
