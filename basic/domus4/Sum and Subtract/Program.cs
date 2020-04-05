using System;

namespace Sum_and_Subtract
{
    class Program
    {

        //static void Intro()
        //{
        //    Console.WriteLine("Enter a \"+\" for Addition or \"-\" for Subtraction ");
        //    char oppChoice = char.Parse(Console.ReadLine());
        //    switch (oppChoice)
        //    {
        //        case '+':
        //            Add();
        //            break;
        //        case '-':
        //            Subtract();
        //            break;
        //        default:
        //            while (oppChoice.Length > 1 || oppChoice != '+' || oppChoice != '-')
        //            {
        //                Console.WriteLine("Invalid input! Please enter either \"+\" or \"-\"");
        //                oppChoice = char.Parse(Console.ReadLine());
        //            }
        //            break;

        //    }
        //}
        static void Intro()
        {
            bool shifter = true;

            while (shifter == true)
            {
                Console.WriteLine("Enter a \"+\" for Addition or \"-\" for Subtraction ");
                //char oppChoice = char.Parse(Console.ReadLine());
                string parsedEntry = Console.ReadLine();
                switch (parsedEntry)
                {
                    case "+":
                        Add();
                        break;
                    case "-":
                        Subtract();
                        break;
                    default:
                        while (parsedEntry != "+" || parsedEntry != "-")
                        {
                            Console.WriteLine("Invalid input! Please enter either \"+\" or \"-\"");
                            parsedEntry = Console.ReadLine(); 

                            //validation won`t work???
                            //се се чини ок: ако инпутот не го исполнува условот, лупот треба да се повторува, седури условот не е исполнет
                            //кога ќе е исполнет, програмот треба повторно да почне од свичот; функционираше во SumofEvens зошто не ф-ционира тука?
                        }
                        break;

                }
            }
        }
        static void Subtract()
        {
            Console.WriteLine("Please enter two numbers. \n Enter your first number");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Now enter the second number");
            double second = double.Parse(Console.ReadLine());
            double sub = first - second;
            Console.WriteLine(sub); 
        }

        static void Add()
        {
            Console.WriteLine("Please enter two numbers. \n Enter your first number");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Now enter the second number");
            double second = double.Parse(Console.ReadLine());
            double add = first + second;
            Console.WriteLine(add);
        }

            //        if (oppChoice = "+")
            //            {
            //                Add();
            //    }
            //            if (oppChoice == '-')
            //            {
            //                Subtract();
            //}




static void Main(string[] args)
        {
            Intro();
            Console.ReadLine();
        }
    }
}
