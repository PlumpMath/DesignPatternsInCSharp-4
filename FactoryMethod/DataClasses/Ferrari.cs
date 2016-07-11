using FactoryMethod.DataClasses.Enums;
using FactoryMethod.UserInterfaces;

namespace FactoryMethod.DataClasses
{
    //Concrete Product
    public class Ferrari : ICar
    {
        public Ferrari()
        {
            Maker = CarMaker.Ferrari;
        }

        public CarMaker Maker { get; set; }

        public string DisplayName => $"Name = {Maker}";
    }
}
