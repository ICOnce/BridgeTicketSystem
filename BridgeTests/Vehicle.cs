using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseSystem
{
    public abstract class Vehicle
    {
        private string _licensePlate;
        /// <summary>
        /// License plate of the vehicle
        /// </summary>
        public string LicensePlate {
            get
            {
                return _licensePlate;
            } 
            set 
            {
                if (!(value.Replace(" ", "").Length > 7)) _licensePlate = value;
                else throw new ArgumentException("License plate cannot be longer than 7 characters");
            }
        }

        /// <summary>
        /// Specifies whether or not a Brobizz was used when crossing the bridge
        /// </summary>
        public bool WasBrobizzUsed { get; private set; }

        /// <summary>
        /// Date the vehicle crossed the bridge
        /// </summary>
        public DateTime Date { get; private set; }

        public abstract double Price();
        public abstract string VehicleType();

        public Vehicle(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
            WasBrobizzUsed = false;
        }
        public Vehicle(string licensePlate, DateTime date, bool brobizzUsed)
        {
            LicensePlate = licensePlate;
            Date = date;
            WasBrobizzUsed = brobizzUsed;
        }

    }
}

