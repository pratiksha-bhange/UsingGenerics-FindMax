using System;

namespace UsingGenrics_MaxFind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Max Using Generics Program");

            FindMax findMaximum = new FindMax();
            Console.WriteLine("\nMaximum Integer value is : " + findMaximum.findMaxValue<int>(599, 149, 853));
            Console.WriteLine("\nMaximum Floating value is : " + findMaximum.findMaxValue<double>(9.3, 6.5, 5.8));
            Console.WriteLine("\nMaximum String is : " + findMaximum.findMaxValue<string>("Pratiksha", "Pravin", "Prashant")); 
        }
    }
}
