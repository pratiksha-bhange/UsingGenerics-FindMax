using System;

namespace UsingGenrics_MaxFind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Max Using Generics Program");

            FindMax findMaximum = new FindMax();
            Console.WriteLine("\nMaximum of three String values is: " + findMaximum.findMaxStringValue("Pratiksha", "Pravin", "Prashant"));
        }
    }
}
