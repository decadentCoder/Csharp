using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Peire Vidal", "Comtessa de Dia", "Bernart de Ventadorn", "Rimbaut de Aurenga", "Arnaut Daniel" };
            string[] studentsG2 = { "Bart Simpson", "Nelson Manz", "Ralph Wigam", "Lisa Simpson", "Millhouse van Houten" };

            Console.WriteLine("Please select a student group");
            Console.WriteLine("Choices: enter 1 or 2");
            int entry = int.Parse(Console.ReadLine());

            switch (entry)
            {
                case 1:
                    Console.WriteLine("Group 1 Students: ");
                    foreach (string student in studentsG1)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                case 2:
                    Console.WriteLine("Group 2 Students: ");
                    foreach (string student in studentsG2)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                default:
                    Console.WriteLine("Wrong entry! Only enter 1 or 2!");
                    break;

            }
            Console.ReadLine();
        }
    }
}
