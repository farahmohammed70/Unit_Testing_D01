using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_tests
{
    public class CarFactoryTests
    {
        #region Type Assertion
        [Fact]
        public void NewCar_AskForToyota_ToyotaObject()
        {
            // Act
            Car? result = CarFactory.NewCar(CarTypes.Toyota);

            // Type Assert
            Assert.IsType<Toyota>(result);
            Assert.IsNotType<BMW>(result);

            Assert.IsAssignableFrom<Car>(result);
        }
        #endregion

        #region Exception Assertion
        [Fact]
        public void NewCar_AskForHonda_Exception()
        {
            // Exception Assert
            Assert.Throws<NotImplementedException>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
            Assert.ThrowsAny<Exception>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });

        } 
        #endregion
    }
}
