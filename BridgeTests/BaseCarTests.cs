using BaseSystem;

namespace BridgeTests
{
    [TestClass]
    public sealed class BaseCarTests
    {
        [DataTestMethod]
        [DataRow("AB12123", false)]
        [DataRow("AB121234", true)]
        public void BaseCarLicensePlateTest(string licensePlate, bool throwsError)
        {
            //Arrange
            Action action = () =>
            {
                new Car(licensePlate, new DateTime());
            };
            //Act

            //Assert
            if (throwsError) Assert.ThrowsException<ArgumentException>(action);
            else
            {
                Car mc = new Car(licensePlate, new DateTime());
                Assert.AreEqual(licensePlate, mc.LicensePlate);
            }

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
            Car car = new Car("", new DateTime());

            //Act
            double price = car.Price();

            //Assert
            Assert.AreEqual(230, price);
        }

        [TestMethod]
        public void BaseCarVehicleTypeTest()
        {
            //Arrange
            Car car = new Car("", new DateTime());

            //Act
            string type = car.VehicleType();

            //Assert
            Assert.AreEqual("Car", type);
        }
    }
}
