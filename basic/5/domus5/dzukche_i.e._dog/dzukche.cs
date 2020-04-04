using System;

namespace dzukche_i.e._dog
{


    public class Dzukche
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is now eating the prosciuto you`ve bought.");
        }
        public void Play()
        {
            Console.WriteLine($"{Name} is now playing. Probably hiding your shoes somewhere...");
        }
        public void ChaseTail()
        {
            Console.WriteLine($"{Name} is now chasing its tail. Oh, no, wait... it actually contemplates on singularity!");
        }

        public void Activity()
        {
            Console.WriteLine($"\n Great, you are now a proud owner of {Name}, a {Color} {Race} ! \n What would you like {Name} to do? \n Please choose one of the three options by entering the respective number");
            Console.WriteLine($"\n 1. {Name} should EAT. \n 2. {Name} should PLAY. \n 3. {Name} should CHASE ITS TAIL.");
            int entry = int.Parse(Console.ReadLine());
            switch (entry)
            {
                case 1:
                    Eat();
                    break;
                case 2:
                    Play();
                    break;
                case 3:
                    ChaseTail();
                    break;
                default:
                    if (entry != 1 ^ entry != 2 ^ entry != 3)
                    {
                        Console.WriteLine("Your dog is \"arrested\" by Animal Control! You should be better dog owner or maybe not own a dog at all!");
                    }
                    else while (String.IsNullOrEmpty(entry.ToString())) // null/empty input validation! won`t work
                        {
                            Console.WriteLine("Please enter value!");
                            entry = int.Parse(Console.ReadLine());

                        }
                    break;
            }
        }
        public void DisplayDog()
        {
           
        }

    }
    class dzukche
    {
        static void Main(string[] args)
        {
            Dzukche sampleDzukac = new Dzukche();

            Console.WriteLine("Enter the name of your dog");
            sampleDzukac.Name = Console.ReadLine();

            Console.WriteLine("Enter the race of your dog");
            sampleDzukac.Race = Console.ReadLine();

            Console.WriteLine("Enter the color of your dog");
            sampleDzukac.Color = Console.ReadLine();

            
            sampleDzukac.Activity();
            Console.ReadLine();
           

        }
    }

    
}
