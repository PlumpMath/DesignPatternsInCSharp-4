using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.DataClasses.Enums;

namespace FactoryMethod.UserInterfaces
{
    //Product
    public interface ICar
    {
        CarMaker Maker { get; set; }

        string DisplayName { get; }
    }
}
