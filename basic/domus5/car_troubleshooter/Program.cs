using System;

namespace Driver
{
    public class Driver
    {
        public string Name { get; set; }
        public double Skill { get; set; }

        public void PrintDrivers()
        {
            Console.WriteLine($"{Name}");
        }

    }

    public class Car
    {
        public string Model { get; set; }
        public double Speed { get; set; }
        // public string Driver { get; set; }

        public void PrintCars()
        {
            Console.WriteLine($"{Model}; max. speed: {Speed}");
        }

        //public double CalculateSpeed()
        //{
        //  // double speed = Driver.Skill * Speed;
        //    return speed;
        //}

    }
       
   


    class Program
    {
        static void RaceCars()
        {

        }

        static void Main(string[] args)
        {
            //instanciating cars

            Car lamborgini = new Car();
            lamborgini.Model = "Lamborgini";
            lamborgini.Speed = 405;
            //lamborgini.Driver = // how to assign the driver;

            Car ferrari = new Car();
            ferrari.Model = "Ferrari";
            ferrari.Speed = 385;

            Car bugatti = new Car();
            bugatti.Model = "Bugatti";
            bugatti.Speed = 407;

            Car ficho = new Car();
            ficho.Model = "Monster Ficho";
            ficho.Speed = 421;

            object[] cars = {lamborgini, ferrari, bugatti, ficho };

            //instanciating drivers

            Driver driver01 = new Driver();
            driver01.Name = "Blasing Jane";
            driver01.Skill = 1.14;

            Driver driver02 = new Driver();
            driver02.Name = "Jonny Rocket";
            driver02.Skill = 0.998;


            Driver driver03 = new Driver();
            driver03.Name = "Lightning Lucy";
            driver03.Skill = 1.12;

            Driver driver04 = new Driver();
            driver04.Name = "Trpe Munja";
            driver04.Skill = 1.15;

            object[] drivers = { driver01, driver02, driver03, driver04 };
            
            Console.WriteLine("drivers");
            foreach (var i in drivers)
            {
                Console.WriteLine((i)); // //(1)како да направам да ми прикажува само едно проперти на класата, пр. името на возачот или моделот на колата? пробав со Car.Property; cars.Property [y].Property и секогаш добивам некој ерор
                                        //истото пробав и со долниот луп (for). (2) Зошто вака ( Console.WriteLine((i)); ) ми ги дава бланко пропертиа (Driver.Driver за class Driver t.e. Driver.Car за Car), иако се инстанцирани објекти од класата?
                                        //(3) и зошто за класата Car ми излистува 4х DRIVER.Car? (4) најпосле, пробав и со посебен метод да ги принта и да го повикам во loop, и така не успева
            }

            Console.WriteLine("cars");

            for (int y = 0; y < cars.Length; y++)
            {
              // (y).PrintCars();
               // y.PrintCars();
            }


           

            Console.WriteLine("Welcome to RACERS! You should choose two cars and two drivers for each car respectively. \n Choose your first car");
            Console.WriteLine();

            
            Console.ReadLine();
            //RaceCars

        }


    }
}

//Console.WriteLine("drivers");
//            foreach (var i in drivers)
//            {
//                Console.WriteLine($"{Name} ");


//public double Quotient
//{
//    get
//    {
//        return Driver.Skill * Speed;
//    }
//}


// backup

//namespace Driver
//{
//    public class Driver
//    {
//        public string Name { get; set; }
//        public double Skill { get; set; }

//    }

//    public class Car
//    {
//        public string Model { get; set; }
//        public double Speed { get; set; }
//        public string Driver { get; set; }

//        public double CalculateSpeed()
//        {
//            double speed = Driver.Skill * Speed;
//            return speed;
//        }

//    }


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //instanciating cars

//            Car lamborgini = new Car();
//            lamborgini.Model = "Lamborgini";
//            lamborgini.Speed = 405;
//            //lamborgini.Driver = // how to assign the driver;

//            Car ferrari = new Car();
//            ferrari.Model = "Ferrari";
//            ferrari.Speed = 385;

//            Car bugatti = new Car();
//            bugatti.Model = "Bugatti";
//            bugatti.Speed = 405;

//            Car fikjo = new Car();
//            fikjo.Model = "Monster Fikjo";
//            fikjo.Speed = 441;

//            //instanciating drivers

//            Driver driver01 = new Driver();
//            driver01.Name = "Blasing Jane";
//            driver01.Skill = 1.14;

//            Driver driver02 = new Driver();
//            driver02.Name = "Jonny Rocket";
//            driver02.Skill = 0.998;


//            Driver driver03 = new Driver();
//            driver03.Name = "Lightning Lucy";
//            driver03.Skill = 1.12;

//            Driver driver04 = new Driver();
//            driver04.Name = "Trpe Munja";
//            driver04.Skill = 1.15;


//            Console.ReadLine();
//        }
//    }
//}

//public double Quotient
//{
//    get
//    {
//        return Driver.Skill * Speed;
//    }
//}
