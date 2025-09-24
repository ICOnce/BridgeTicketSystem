using BaseSystem;

namespace BridgeTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void BasePriceTest()
        {
            //Arrange
            Car car = new Car();

            //Act
            double price = car.Price();

            //Assert
            Assert.AreEqual(230, price);
        }
    }
}
