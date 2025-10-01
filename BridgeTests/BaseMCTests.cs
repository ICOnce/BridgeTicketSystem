using BaseSystem;

namespace BridgeTests;

[TestClass]
public class BaseMCTests
{
    [DataTestMethod]
    [DataRow("AB12123", false)]
    [DataRow("AB121234", true)]
    public void BaseMCLicensePlateTest(string licensePlate, bool throwsError)
    {
        //Arrange
        Action action = () =>
        {
            new MC(licensePlate, new DateTime());
        };
        //Act

        //Assert
        if (throwsError) Assert.ThrowsException<ArgumentException>(action);
        else
        {
            MC mc = new MC(licensePlate, new DateTime());
            Assert.AreEqual(licensePlate, mc.LicensePlate);
        }

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

    [DataTestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public void BaseMCPriceTest(bool brobizzUsed)
    {
        //Arrange
        MC mc = new MC("",new DateTime(), brobizzUsed);

        //Act
        double price = mc.Price();

        //Assert
        if (brobizzUsed)
        {
            Assert.AreEqual(108, price);
        }
        else Assert.AreEqual(120, price);
    }

    [TestMethod]
    public void BaseMCVehicleTypeTest()
    {
        //Arrange
        MC mc = new MC("", new DateTime());

        //Act
        string type = mc.VehicleType();

        //Assert
        Assert.AreEqual("MC", type);
    }
}
