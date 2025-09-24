using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseSystem
{
    public interface Vehicle
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        public double Price();
        public string VehicleType();
    }
}

