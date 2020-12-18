using System;

namespace DelegatesActionFunc
{
    //declaring custom delegate as we do declare class
    public delegate int myCustomDelForCal(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Action a = PrintSomeThing;
            
            calculator(5, 10, Sum);

            myCustomDelForCal s = Sum;
            calculatorGeneric(2, 3, s);
        }

        private static void calculatorGeneric(int a, int b, myCustomDelForCal s)
        {
            Console.WriteLine(s(a, b));

        }

        public static void calculator(int a, int b, Func<int, int, int> oper)
        {
            Console.WriteLine(oper(a, b));
        }

        public static void PrintSomeThing()
        {
            Console.WriteLine("hello");
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
