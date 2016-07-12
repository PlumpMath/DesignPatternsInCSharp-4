using System.Collections.Generic;
using FactoryMethod.DataClasses.Enums;
using FactoryMethod.UserInterfaces;

namespace FactoryMethod.DataClasses
{
    //Concrete Product
    public class Honda : Car
    {
        public Honda()
        {
            Maker = CarMaker.Honda;
            ModelList = new List<string>
            {
                "Honda City",
                "Honda Vamos",
                "Honda ZEST",
                "Honda Civic"
            };
        }       
    }
}
