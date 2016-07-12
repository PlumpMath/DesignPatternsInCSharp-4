using System;
using System.Collections.Generic;
using FactoryMethod.DataClasses;
using FactoryMethod.DataClasses.Enums;
using FactoryMethod.UserInterfaces;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new CarFactory() as ICarFactory;
            var carList = new List<Car>
            {
                factory.GetCar(CarMaker.Bugatti),
                factory.GetCar(CarMaker.Ferrari),
                factory.GetCar(CarMaker.Honda),
                factory.GetCar(CarMaker.Toyota),
            };

            Console.WriteLine("List of cars by manufacturers:");
            foreach (var car in carList)
            {
                Console.WriteLine("{0} Car Models:", car.Maker);
                Console.WriteLine("--------------------------");
                foreach (var carModel in car.ModelList)
                {
                    Console.WriteLine(carModel);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
