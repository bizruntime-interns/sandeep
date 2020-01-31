using System;

namespace if__else_if_else_conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;

            if (a == 10)
            {
                Console.WriteLine("a is 10");
            }
            else if (a == 15)
            {
                Console.WriteLine("a is 15");
            }
            else if (a == 20)
            {
                Console.WriteLine("a is 20");
            }
            else
            {
                Console.WriteLine("a is not present");
            }
        }
    }
}
