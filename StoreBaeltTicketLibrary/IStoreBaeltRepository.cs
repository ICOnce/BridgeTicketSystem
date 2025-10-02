using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseSystem;

namespace StoreBaeltTicketLibrary
{
    public interface IStoreBaeltRepository
    {
        /// <summary>
        /// Method for buying a ticket (adding it to the static list)
        /// </summary>
        /// <param name="vehicle"></param>
        public void BuyTicket(Vehicle vehicle);

        /// <summary>
        /// Method for getting a list of all the tickets
        /// </summary>
        /// <returns></returns>
        public List<Vehicle> GetTickets();

        /// <summary>
        /// Method for getting all tickets from a specific license plate
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <returns></returns>
        public List<Vehicle> GetTicketsByLicensePlate(string licensePlate);
    }
}
