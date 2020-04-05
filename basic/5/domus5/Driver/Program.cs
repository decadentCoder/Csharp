using System;

namespace Driver
{
    public class Driver
    {
        public string Name { get; set; }
        public double Skill { get; set; }
        
    }

    public class Car
    {
        public string Model { get; set; }
        public double Speed { get; set; }
        public string Driver { get; set; } 

        public double CalculateSpeed()
        {
            double speed = Driver.Skill * Speed;
            return speed;
        }

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
            bugatti.Speed = 405;

            Car fikjo = new Car();
            fikjo.Model = "Monster Fikjo";
            fikjo.Speed = 441;

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

            Console.ReadLine();
            //RaceCars
           
        }


    }
}

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

                    //    //instanciating cars

        //    Car lamborgini = new Car();
        //    lamborgini.Model = "Lamborgini";
        //    lamborgini.Speed = 405;
        //    //lamborgini.Driver = // how to assign the driver;

        //    Car ferrari = new Car();
        //    ferrari.Model = "Ferrari";
        //    ferrari.Speed = 385;

        //    Car bugatti = new Car();
        //    bugatti.Model = "Bugatti";
        //    bugatti.Speed = 407;

        //    Car ficho = new Car();
        //    ficho.Model = "Monster Ficho";
        //    ficho.Speed = 421;

        //    //instanciating drivers

        //    Driver driver01 = new Driver();
        //    driver01.Name = "Blasing Jane";
        //    driver01.Skill = 1.14;

        //    Driver driver02 = new Driver();
        //    driver02.Name = "Jonny Rocket";
        //    driver02.Skill = 0.998;


        //    Driver driver03 = new Driver();
        //    driver03.Name = "Lightning Lucy";
        //    driver03.Skill = 1.12;

        //    Driver driver04 = new Driver();
        //    driver04.Name = "Trpe Munja";
        //    driver04.Skill = 1.15;

        //    Console.ReadLine();
        //    //RaceCars

        //}
            //RaceCars

       // }


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
