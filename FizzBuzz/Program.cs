using System;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main()
        {
            var fizz = "soda";
            var buzz = "pop";
            var fizzBuzz = "cola";

            var fizzMultiple = 2;
            var buzzMultiple = 7;

            for (var i = 1; i <= 100; i++)
            {
                if (i % fizzMultiple == 0 && i % buzzMultiple == 0) Console.WriteLine(fizzBuzz);
                else if (i % fizzMultiple == 0) Console.WriteLine(fizz);
                else if (i % buzzMultiple == 0) Console.WriteLine(buzz);
                else Console.WriteLine(i);
            }
        }
    }
}