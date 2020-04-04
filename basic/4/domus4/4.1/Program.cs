using System;

namespace _4._1
{
    class Program
    {


        static void Substring()
        {
            string sedc = "Hello from SEDC CodeAcademy v7.103 beta!";
            Console.WriteLine(sedc);
            Console.WriteLine("Please enter a number.");
            int entry = int.Parse(Console.ReadLine());
            while(entry < 1 || entry >= sedc.Length )
            {
                Console.WriteLine($"Invalid input! Please enter a number between 1 and {sedc.Length}");
                entry = int.Parse(Console.ReadLine());

            }
            string output = sedc.Substring(entry, (sedc.Length - entry));
            Console.WriteLine(output);
            Console.WriteLine($"the length of the new string: {output.Length}");
            Console.ReadLine();
        }


        

        static void Main(string[] args)
        {

            Substring();
            Console.ReadLine();
        }


    }
}
