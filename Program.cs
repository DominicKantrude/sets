using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showroom = new HashSet<string>();

            showroom.Add("mustang");
            showroom.Add("eclipse");
            showroom.Add("corvette");
            showroom.Add("stingray");

            Console.Write(showroom.Count);

            showroom.Add("stingray");

            Console.Write(showroom.Count);

            HashSet<string> usedLot = new HashSet<string>();
            usedLot.Add("thatCar");
            usedLot.Add("thisCar");

            showroom.UnionWith(usedLot);

            showroom.Remove("corvette");

            Console.WriteLine(String.Join("; ", showroom));


            HashSet<string> Junkyard = new HashSet<string>();

            Junkyard.Add("cool car");
            Junkyard.Add("eclipse");
            Junkyard.Add("bad car");
            Junkyard.Add("stingray");

            HashSet<string> clone = new HashSet<string>(showroom);
            clone.IntersectWith(Junkyard);
            Console.WriteLine(String.Join("; ", clone));


            List<Car> cars = new List<Car>();
            Car corvette = new Car();
            corvette.Make = "cheverolet";
            corvette.Model = "corvette";
            corvette.Year = 1991;
            corvette.Price = 25000;

            cars.Add(corvette);

            Car lambo = new Car();
            lambo.Make = "idk";
            lambo.Model = "lamburguni";
            lambo.Year = 1995;
            lambo.Price = 75000;

            cars.Add(lambo);

            Car corolla = new Car();
            corolla.Make = "toyotta";
            corolla.Model = "corolla";
            corolla.Year = 2019;
            corolla.Price = 20000;

            cars.Add(corolla);

            foreach (Car car in cars)
            {
                Console.WriteLine($@"
    Make: {car.Make}
    Model: {car.Model}
    Year: {car.Year}
    Price: {car.Price}
    ");
            }



            // List<Dictionary<string, string>> cars = new List<Dictionary<string, string>>();
            //             Dictionary<string, string> corvette = new Dictionary<string, string>();
            //             corvette.Add("make", "cheverolet");
            //             corvette.Add("model", "corvette");
            //             corvette.Add("year", "1991");
            //             corvette.Add("price", "$25000");

            //             cars.Add(corvette);

            //              Dictionary<string, string> lambo = new Dictionary<string, string>();
            //             lambo.Add("make", "idk");
            //             lambo.Add("model", "lamburguni");
            //             lambo.Add("year", "1995");
            //            lambo.Add("price", "$75000");

            //             cars.Add(lambo);

            //              Dictionary<string, string> corolla = new Dictionary<string, string>();
            //             corolla.Add("make", "toyotta");
            //             corolla.Add("model", "corolla");
            //             corolla.Add("year", "2019");
            //             corolla.Add("price", "20000");

            //             cars.Add(corolla);

            // foreach (Dictionary<string, string> car in cars)
            // {
            //     foreach (KeyValuePair<string, string> pair in car)
            //     {
            //         Console.WriteLine($"{pair.Key} : {pair.Value}");

            //     }

            // }
        }
    }
}
