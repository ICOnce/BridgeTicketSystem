using BaseSystem;

namespace BridgeTests;

[TestClass]
public class BaseMCTests
{
    [TestMethod]
    public void BaseMCLicensePlateEmptyTest()
    {
        //Arrange
        MC MC = new MC();

        //Act

        //Assert
        Assert.AreEqual("", MC.LicensePlate);
    }

    [TestMethod]
    public void BaseMCLicensePlateTest()
    {
        //Arrange
        MC mc = new MC("LA 123 12", new DateTime());

        //Act
        string licensePlate = "LA 123 12";

        //Assert
        Assert.AreEqual(licensePlate, mc.LicensePlate);
    }

    [TestMethod]
    public void BaseMCDateTest()
    {
        //Arrange
        MC mc = new MC("LA 123 12", new DateTime(25, 9, 24));

        //Act
        DateTime date = new DateTime(25, 9, 24);

        //Assert
        Assert.AreEqual(date, mc.Date);
    }

    [TestMethod]
    public void BaseMCPriceTest()
    {
        //Arrange
        MC mc = new MC();

        //Act
        double price = mc.Price();

        //Assert
        Assert.AreEqual(120, price);
    }

    [TestMethod]
    public void BaseMCVehicleTypeTest()
    {
        //Arrange
        MC mc = new MC();

        //Act
        string type = mc.VehicleType();

        //Assert
        Assert.AreEqual("MC", type);
    }
}
