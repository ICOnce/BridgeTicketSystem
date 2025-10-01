using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseSystem
{
    public abstract class Vehicle
    {
        /// <summary>
        /// License plate of the vehicle
        /// </summary>
        private string _licensePlate;
        public string LicensePlate {
            get
            {
                return _licensePlate;
            } 
            set 
            {
                if (!(value.Length > 7)) _licensePlate = value;
                else throw new ArgumentException("License plate cannot be longer than 7 characters");
            }
        }

        /// <summary>
        /// Date the vehicle crossed the bridge
        /// </summary>
        public DateTime Date { get; set; }

        public abstract double Price();
        public abstract string VehicleType();

        public Vehicle()
        {
            LicensePlate = "";
        }

        public Vehicle(string licensePlate, DateTime date)
        {
            try
            {
                LicensePlate = licensePlate;
                Date = date;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

