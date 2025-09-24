using BaseSystem;

namespace BridgeTests
{
    [TestClass]
    public sealed class BaseCarTests
    {
        [TestMethod]
        public void BaseCarLicensePlateEmptyTest()
        {
            //Arrange
            Car car = new Car();

            //Act

            //Assert
            Assert.AreEqual("", car.LicensePlate);
        }

        [TestMethod]
        public void BaseCarLicensePlateTest()
        {
            //Arrange
            Car car = new Car("LA 123 12", new DateTime());

            //Act
            string licensePlate = "LA 123 12";

            //Assert
            Assert.AreEqual(licensePlate, car.LicensePlate);
        }

        [TestMethod]
        public void BaseCarDateTest()
        {
            //Arrange
            Car car = new Car("LA 123 12", new DateTime(25, 9, 24));

            //Act
            DateTime date = new DateTime(25, 9, 24);

            //Assert
            Assert.AreEqual(date, car.Date);
        }

        [TestMethod]
        public void BaseCarPriceTest()
        {
            //Arrange
            Car car = new Car();

            //Act
            double price = car.Price();

            //Assert
            Assert.AreEqual(230, price);
        }

        [TestMethod]
        public void BaseCarVehicleTypeTest()
        {
            //Arrange
            Car car = new Car();

            //Act
            string type = car.VehicleType();

            //Assert
            Assert.AreEqual("Car", type);
        }
    }
}
