namespace BaseSystem
{
    public class Car
    {

        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Method for getting the price of the car crossing the bridge
        /// </summary>
        /// 
        /// <returns>
        /// 230
        /// </returns>
        public double Price()
        {
            return 230;
        }

        /// <summary>
        /// Method for getting the vehicle type
        /// </summary>
        /// 
        /// <returns>
        /// "Car"
        /// </returns>
        public string VehicleType()
        {
            return "Car";
        }

        /// <summary>
        /// Default constructor
        /// Sets LicensePlate to an empty string
        /// </summary>
        public Car()
        {
            LicensePlate = string.Empty;
        }


        /// <summary>
        /// Constructor that sets the values of Date and LicensePlate
        /// </summary>
        /// <param name="licensePlate">License plate of the car</param>
        /// <param name="date">Date the car crossed the bridge</param>
        public Car(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }
    }
}
