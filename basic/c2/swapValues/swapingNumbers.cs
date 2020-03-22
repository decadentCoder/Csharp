using System;

namespace swappingNumbers
{
    class swappingNumbers
    {
        static void Main(string[] args)
        {
            #region variables 

            int first;
            int second;
            int swap = 0;

            #endregion variables

            #region method

            //Console.WriteLine("Enter the first number!");
            //first = int.Parse(Console.ReadLine());
            
            //Console.WriteLine($"First number = {first}");
            //Console.WriteLine("Now enter the second number");
            //second = int.Parse(Console.ReadLine());

            //Console.WriteLine($"First number = {first}; Second number = {second}, swap value = {swap}");
            //swap = first;
            ////the value of first is now stored in swap
            //Console.WriteLine($"current value of swap = {swap}; of first = {first}");
            //first = second;
            //Console.WriteLine("assigning value of SECOND to FIRST (first now receives the value of second: first <-- second)");

            //Console.WriteLine($"current value of swap = {swap}; of first = {first}; of second = {second}");
            //second = swap;
            ////first = swap;

            //Console.WriteLine($"AFTER SWAPING First number = {first}; Second number = {second}, swap value = {swap}");
            //Console.WriteLine("swap = " + swap);

            #endregion method

            #region clean

            Console.WriteLine("Enter the first number!");
            first = int.Parse(Console.ReadLine());
            Console.WriteLine($"First number = {first}");
            Console.WriteLine("Now enter the second number");
            second = int.Parse(Console.ReadLine());
            Console.WriteLine($"First number = {first}; Second number = {second}");
            swap = first;
            first = second;
            second = swap;
            
            Console.WriteLine("...Doing some abracadabra... tadaam!");

            Console.WriteLine($"AFTER SWAPING: first number = {first}; Second number = {second}");

            #endregion clean

            Console.ReadLine();
        }
    }
}
