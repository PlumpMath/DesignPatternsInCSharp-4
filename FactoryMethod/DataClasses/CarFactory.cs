using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.DataClasses.Enums;
using FactoryMethod.UserInterfaces;

namespace FactoryMethod.DataClasses
{
    public class CarFactory : ICarFactory
    {
        public Car GetCar(CarMaker maker)
        {
            switch (maker)
            {
                case CarMaker.Bugatti:
                    return new Bugatti();
                case CarMaker.Ferrari:
                    return new Ferrari();
                case CarMaker.Honda:
                    return new Honda();
                case CarMaker.Toyota:
                    return new Toyota();
                default:
                    throw new ArgumentOutOfRangeException(nameof(maker), maker, null);
            }
        }
    }
}
