using System;

namespace UsingGenrics_MaxFind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Max Using Generics Program");


            FindMaximum<int> findIntMax = new FindMaximum<int>();
            FindMaximum<double> findMaximumDouble = new FindMaximum<double>();
            FindMaximum<string> findstring = new FindMaximum<string>();

            Console.WriteLine("\nMaximum of Integer value is : " + findIntMax.findMaxValue(599, 482, 635));
            Console.WriteLine("\nMaximum Floating value is : " + findMaximumDouble.findMaxValue(304.45, 95.27, 467.18));
            Console.WriteLine("\nMaximum String is : " + findstring.findMaxValue("Pratiksha", "Pravin", "Prashant"));

        }
    }
}
