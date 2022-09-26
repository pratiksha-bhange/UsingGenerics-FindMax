using System;

namespace UsingGenrics_MaxFind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Max Using Generics Program");

            FindMax findMaximum = new FindMax();
            Console.WriteLine("Maximum of three floating values is: " + findMaximum.findMaxDoubleValue(8.9, 5.7, 3.4));
        }
    }
}
