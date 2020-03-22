using System;

namespace domus2
{
    class Calclucator
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Welcome to Console Calculator! Please enter the first number!");
            int entry1 = int.Parse(Console.ReadLine());
            Console.WriteLine("very good! Now enter the second number!");
            int entry2 = int.Parse(Console.ReadLine());
            Console.WriteLine("now select one of the four following mathematical opperations to perform:");
            Console.WriteLine("enter + for addition");
            Console.WriteLine("enter - for substraction");
            Console.WriteLine("enter * for multiplication");
            Console.WriteLine("enter / for division");

            char userEntry = char.Parse(Console.ReadLine());

            int resultAdd = entry1 + entry2;
            int resultSub = entry1 - entry2;
            int resultMul = entry1 * entry2;
            int resultDiv = entry1 / entry2;


            switch (userEntry)
            {
                case '+':
                    Console.WriteLine("Adding " + entry1 + " to " + entry2);
                    Console.WriteLine("Result: " + resultAdd);
                    break;
                case '-':
                    Console.WriteLine("Substracting " + entry2 + " from " + entry1);
                    Console.WriteLine("Result: " + resultSub);
                    break;
                case '*':
                    Console.WriteLine("Multiplying" + entry1 + " with " + entry2);
                    Console.WriteLine("Result: " + resultMul);
                    break;
                case '/':
                    Console.WriteLine("Dividing " + entry1 + " with " + entry2);
                    Console.WriteLine("Result: " + resultDiv);
                    break;
            }


            Console.ReadLine();
        }
    }
}
