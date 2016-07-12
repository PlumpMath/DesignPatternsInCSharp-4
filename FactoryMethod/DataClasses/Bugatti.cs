using System.Collections.Generic;
using FactoryMethod.DataClasses.Enums;
using FactoryMethod.UserInterfaces;

namespace FactoryMethod.DataClasses
{
    //Concrete Product
    public class Bugatti : Car
    {
        public Bugatti()
        {
            Maker = CarMaker.Bugatti;
            ModelList = new List<string>
            {
                "Bugatti Type 35",
                "Bugatti Veyron EB16.4",
                "Bugatti Type 41 Royale",
                "Bugatti Type 18 Garros"
            };
        }
    }
}
