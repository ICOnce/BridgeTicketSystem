using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseSystem;

namespace OreSundBron
{
    public class MC : BaseSystem.MC
    {
        public MC(string licensePlate, DateTime date) : base(licensePlate, date)
        {
        }

        public MC(string licensePlate, DateTime date, bool brobizzUsed) : base(licensePlate, date, brobizzUsed)
        {
        }

        public override double Price()
        {
            return WasBrobizzUsed ? 92 : 235;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
