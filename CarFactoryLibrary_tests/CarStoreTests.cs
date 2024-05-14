using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_tests
{
    public class CarStoreTests
    {
        #region Collection Assertions
        [Fact]
        public void AddCar_AddToyotaAndBMW_ListContainObject()
        {
            // Arrange
            CarStore carStore = new CarStore();
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Forward };
            BMW bMW = new BMW();

            // Act
            carStore.AddCar(toyota);
            carStore.AddCar(bMW);

            // Collection Asserts
            Assert.NotEmpty(carStore.cars);

            Assert.Contains<Car>(toyota, carStore.cars);

            Assert.Contains<Car>(bMW, carStore.cars);

            Assert.DoesNotContain<Car>(carStore.cars, c => c.velocity == 50);
        }
    } 
    #endregion
}
