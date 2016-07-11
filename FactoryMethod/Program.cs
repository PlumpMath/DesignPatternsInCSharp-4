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
            var carList = new List<ICar>
            {
                factory.GetCar(CarMaker.Bugatti),
                factory.GetCar(CarMaker.Ferrari),
                factory.GetCar(CarMaker.Honda),
                factory.GetCar(CarMaker.Toyota),
            };

            Console.WriteLine("List of car manufacturers:");
            foreach (var car in carList)
            {
                Console.WriteLine(car.DisplayName);
            }

            Console.ReadKey();
        }
    }
}
