using BaseSystem;
namespace StoreBaeltTicketLibrary
{
    public class Car : BaseSystem.Car
    {
        public Car(string licensePlate, DateTime date) : base(licensePlate, date)
        {
        }

        public Car(string licensePlate, DateTime date, bool brobizzUsed) : base(licensePlate, date, brobizzUsed)
        {
        }

        public override double Price()
        {
            double price = 230;
            if (Date.DayOfWeek == DayOfWeek.Saturday ||Date.DayOfWeek == DayOfWeek.Sunday)
            {
                price *= 0.85;
            }
            if (WasBrobizzUsed) price *= 0.9;
            return price;
        }
    }
}


