using System.Collections.Generic;
using FactoryMethod.DataClasses.Enums;
using FactoryMethod.UserInterfaces;

namespace FactoryMethod.DataClasses
{
    //Concrete Product
    public class Toyota : Car
    {
        public Toyota()
        {
            Maker = CarMaker.Toyota;
            ModelList = new List<string>
            {
                "Fortuner",
                "Land Cruiser 200",
                "Prado",
                "Venza"
            };
        }        
    }
}
