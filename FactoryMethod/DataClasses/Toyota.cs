using FactoryMethod.DataClasses.Enums;
using FactoryMethod.UserInterfaces;

namespace FactoryMethod.DataClasses
{
    //Concrete Product
    public class Toyota : ICar
    {
        public Toyota()
        {
            Maker = CarMaker.Toyota;
        }

        public CarMaker Maker { get; set; }

        public string DisplayName => $"Name = {Maker}";
    }
}
