using BaseSystem;
namespace OreSundBron
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
            return WasBrobizzUsed ? 178 : 460;
        }

        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
