using FactoryMethod.DataClasses.Enums;
using FactoryMethod.UserInterfaces;

namespace FactoryMethod.DataClasses
{
    //Concrete Product
    public class Bugatti : ICar
    {
        public Bugatti()
        {
            Maker = CarMaker.Bugatti;
        }

        public CarMaker Maker { get; set; }

        public string DisplayName => $"Name = {Maker}";
    }
}
