using System.Collections.Generic;
using FactoryMethod.DataClasses.Enums;
using FactoryMethod.UserInterfaces;

namespace FactoryMethod.DataClasses
{
    //Concrete Product
    public class Ferrari : Car
    {
        public Ferrari()
        {
            Maker = CarMaker.Ferrari;
            ModelList = new List<string>
            {
                "Ferrari Barchetta",
                "Ferrari F12 Berlinetta",
                "Ferrari Testa Rossa",
                "Ferrari 458 Italia"
            };
        }
    }
}
