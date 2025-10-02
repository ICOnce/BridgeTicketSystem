using StoreBaeltTicketLibrary;

namespace BridgeTests;

[TestClass]
public class StoreBaeltTests
{
    [DataTestMethod]
    [DataRow("2025-10-2", false, 230)]
    [DataRow("2025-10-2", true, 207)]
    [DataRow("2025-10-4", false, 195.5)]
    [DataRow("2025-10-4", true, 175.95)]
    public void SpecificPriceTest(string date, bool brobizz, double expected)
    {
        Car car = new Car("", DateTime.Parse(date), brobizz);

        Assert.AreEqual(expected, car.Price(),0.001);
    }
}
