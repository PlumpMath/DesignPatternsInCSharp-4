using System.Collections.Generic;
using FactoryMethod.DataClasses.Enums;

namespace FactoryMethod.UserInterfaces
{
    //Product
    public abstract class Car
    {
        public CarMaker Maker { get; set; }
        public List<string> ModelList { get; set; }
    }
}
