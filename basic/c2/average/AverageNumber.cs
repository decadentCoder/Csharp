using System;

namespace average
{
    class AverageNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four numbers to get their average");
            Console.WriteLine("Enter the first number!");
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number!");
            int no2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number!");
            int no3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth and final number!");
            int no4 = int.Parse(Console.ReadLine());

            int average = (no1 + no2 + no3 + no4) / 4;
            Console.WriteLine($"The average for {no1}, {no2}, {no3} and {no4} is: {average}!");


            Console.ReadLine();
        }
    }
}
