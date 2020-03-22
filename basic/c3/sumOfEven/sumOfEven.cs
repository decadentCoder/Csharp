using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shifter = true;

            while (shifter == true)
            {

                int[] inputs = { };
                Array.Resize(ref inputs, 6);
                Console.WriteLine("Welcome to Sum of Even! You should enter 6 numbers, and you get the average of the even numbers");
                Console.WriteLine("enter integer no1");
                int entry1 = int.Parse(Console.ReadLine());
                inputs[0] = entry1;
                Console.WriteLine($"inputs0 = {inputs[0]}");

                Console.WriteLine("enter integer no2");
                int entry2 = int.Parse(Console.ReadLine());
                inputs[1] = entry2;
                
                Console.WriteLine("enter integer no3");
                Console.WriteLine($"inputs1 = {inputs[1]}");
                int entry3 = int.Parse(Console.ReadLine());
                inputs[2] = entry3;

                Console.WriteLine($"inputs2 = {inputs[2]}");
                Console.WriteLine("enter integer no4");
                int entry4 = int.Parse(Console.ReadLine());
                inputs[3] = entry4;

                Console.WriteLine($"inputs3 = {inputs[3]}");
                Console.WriteLine("enter integer no5");
                int entry5 = int.Parse(Console.ReadLine());
                inputs[4] = entry5;

                Console.WriteLine($"inputs4 = {inputs[4]}");
                Console.WriteLine("enter integer no6");
                int entry6 = int.Parse(Console.ReadLine());
                inputs[5] = entry6;
                Console.WriteLine($"inputs5 = {inputs[5]}");

                int sum = 0;
                int counterEven = 0;
                foreach (int i in inputs)
                {
                    if (i % 2 == 0) 
                    {
                        counterEven += 1;
                        Console.WriteLine("counter of Evens = " + counterEven);
                        sum += i;
                        Console.WriteLine("Sum of Evens = " + sum);
                    }
                    
                }
                sum = sum / counterEven;
                Console.WriteLine("average of evens = " + sum);
                Console.WriteLine("Enter X to quit, or C to continue!");
                string switcher = Console.ReadLine();
                switch (switcher)
                {
                    case "X":
                        shifter = false;
                        break;
                    case "C":
                        shifter = true;
                        break;
                    default:
                        while (switcher != "X" && switcher != "C")
                        {
                            Console.WriteLine("wrong entry! Only enter C or X! WARNING: Case sensitive!");
                            switcher = Console.ReadLine();
                        }
                        break;
                }
                
            }

            
            Console.ReadLine();
        }
    }
}
