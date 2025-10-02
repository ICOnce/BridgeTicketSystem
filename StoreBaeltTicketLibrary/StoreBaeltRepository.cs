using BaseSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltRepository
    {
        private static List<Vehicle> vehicles = new List<Vehicle>();

        /// <summary>
        /// Method for buying a ticket (adding it to the static list)
        /// </summary>
        /// <param name="vehicle"></param>
        public void BuyTicket(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        /// <summary>
        /// Method for getting a list of all the tickets
        /// </summary>
        /// <returns></returns>
        public List<Vehicle> GetTickets()
        {
            return vehicles;
        }

        /// <summary>
        /// Method for getting all tickets from a specific license plate
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <returns></returns>
        public List<Vehicle> GetTicketsByLicensePlate(string licensePlate)
        {
            List<Vehicle> result = new List<Vehicle>();
            foreach(Vehicle vehicle in vehicles)
            {
                if (vehicle.LicensePlate == licensePlate) result.Add(vehicle);
            }
            return result;
        }
    }
}
