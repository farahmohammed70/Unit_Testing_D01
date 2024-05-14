using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_tests
{
    public class ToyotaTests
    {
        #region Boolean Assertions
        [Fact]
        public void IsStopped_Velocity0_true()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 0;

            // Act
            bool actualResult = toyota.IsStopped();

            // Boolean Assert
            Assert.True(actualResult);
        }

        [Fact]
        public void IsStopped_Velocity10_false()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 10;

            // Act
            bool actualResult = toyota.IsStopped();

            // Boolean Assert
            Assert.False(actualResult);
        }

        [Fact]
        public void IsStopped_VelocityNegative5_false()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = -5;

            // Act
            bool actualResult = toyota.IsStopped();

            // Assert
            Assert.False(actualResult);
        }

        [Fact]
        public void IsStopped_NearZeroVelocity_false()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 0.00001;

            // Act
            bool actualResult = toyota.IsStopped();

            // Assert
            Assert.False(actualResult);
        }


        #endregion

        #region Numeric Assertions
        [Fact]
        public void IncreaseVelocity_PositiveAddedVelocity_IncreasesVelocity()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 10;
            double addedVelocity = 5;

            // Act
            toyota.IncreaseVelocity(addedVelocity);

            // Assert
            Assert.Equal(15, toyota.velocity);
        }

        [Fact]
        public void IncreaseVelocity_NegativeAddedVelocity_DecreasesVelocity()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 20;
            double addedVelocity = -3;

            // Act
            toyota.IncreaseVelocity(addedVelocity);

            // Assert
            Assert.Equal(17, toyota.velocity);
        }

        [Fact]
        public void IncreaseVelocity_ZeroAddedVelocity_NoChange()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 30;
            double addedVelocity = 0;

            // Act
            toyota.IncreaseVelocity(addedVelocity);

            // Assert
            Assert.Equal(30, toyota.velocity);
        }
        #endregion

        #region String Assertions
        [Fact]
        public void GetDirection_DirectionBackward_Backward()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Backward };

            // Act
            string result = toyota.GetDirection();

            // String Assert
            Assert.Equal("Backward", result);

            Assert.StartsWith("B", result);

            Assert.EndsWith("rd", result);

            Assert.Contains("kw", result);

            Assert.DoesNotContain("xyz", result);

            Assert.Matches("B[a-z]{7}", result);

            Assert.DoesNotMatch("B[a-z]{10}", result);
        }
        #endregion

        #region Reference Assertions
        [Fact]
        public void GetMyCar_AskForRefrence_Same()
        {
            // Arrange
            Toyota toyota1 = new Toyota();
            Toyota toyota2 = new Toyota();
            Car? result2 = CarFactory.NewCar(CarTypes.Toyota);

            // Act
            Car result = toyota1.GetMyCar();

            // Reference Assert
            Assert.Same(toyota1, result);

            Assert.NotSame(toyota2, result);

            Assert.NotNull(result2);
        } 
        #endregion
    }
}
