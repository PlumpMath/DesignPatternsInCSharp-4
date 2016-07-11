using FactoryMethod.DataClasses.Enums;
using FactoryMethod.UserInterfaces;

namespace FactoryMethod.DataClasses
{
    //Concrete Product
    public class Honda : ICar
    {
        public Honda()
        {
            Maker = CarMaker.Honda;
        }

        public CarMaker Maker { get; set; }

        public string DisplayName => $"Name = {Maker}";
    }
}
