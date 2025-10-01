namespace BaseSystem
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Method for getting the price of the car crossing the bridge
        /// </summary>
        /// 
        /// <returns>
        /// 230
        /// </returns>
        public override double Price()
        {
            if (WasBrobizzUsed) return 230 * 0.9;
            return 230;
        }

        /// <summary>
        /// Method for getting the vehicle type
        /// </summary>
        /// 
        /// <returns>
        /// "Car"
        /// </returns>
        public override string VehicleType()
        {
            return "Car";
        }


        /// <summary>
        /// Constructor that sets the values of Date and LicensePlate
        /// </summary>
        /// <param name="licensePlate">License plate of the car</param>
        /// <param name="date">Date the car crossed the bridge</param>
        public Car(string licensePlate, DateTime date): base(licensePlate, date)
        {
        }

        /// <summary>
        /// Constructor for setting the date, licenseplate and Brobizz properties
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        /// <param name="brobizzUsed"></param>
        public Car(string licensePlate, DateTime date, bool brobizzUsed) : base(licensePlate, date, brobizzUsed)
        {
        }
    }
}
