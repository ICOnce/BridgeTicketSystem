using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseSystem
{
    public class MC :Vehicle
    {
        /// <summary>
        /// Method for getting the price of the motorcycle crossing the bridge
        /// </summary>
        /// 
        /// <returns>
        /// 230
        /// </returns>
        public override double Price()
        {
            if (WasBrobizzUsed) return 120 * 0.9;
            return 120;
        }

        /// <summary>
        /// Method for getting the vehicle type
        /// </summary>
        /// 
        /// <returns>
        /// "MC"
        /// </returns>
        public override string VehicleType()
        {
            return "MC";
        }


        /// <summary>
        /// Constructor that sets the values of Date and LicensePlate
        /// </summary>
        /// <param name="licensePlate">License plate of the motorcycle</param>
        /// <param name="date">Date the motorcycle crossed the bridge</param>
        public MC(string licensePlate, DateTime date) : base(licensePlate, date)
        {
        }

        /// <summary>
        /// Constructor for setting the date, licenseplate and Brobizz properties
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        /// <param name="brobizzUsed"></param>
        public MC(string licensePlate, DateTime date, bool brobizzUsed) : base(licensePlate, date, brobizzUsed)
        {
        }
    }
}
