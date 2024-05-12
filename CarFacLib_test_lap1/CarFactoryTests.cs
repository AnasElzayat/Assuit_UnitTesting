using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFacLib_test_lap1
{
    public class CarFactoryTests
    {
        [Fact]
        public void NewCar_CarTypeToyota_Toyota()
        {
            
            Car? car = CarFactory.NewCar(CarTypes.Toyota);

            Assert.IsType<Toyota>(car);

        }

        [Fact]
        public void NewCar_CarTypeHonda_Exception()
        {
            Assert.Throws<NotImplementedException>(() =>
            {
                Car? result = CarFactory.NewCar(CarTypes.Kia);
            });
        }
    }
}
