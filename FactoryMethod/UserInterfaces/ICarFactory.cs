using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.DataClasses.Enums;

namespace FactoryMethod.UserInterfaces
{
    //Creator
    public interface ICarFactory
    {
        Car GetCar(CarMaker maker);
    }
}
