using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Avioneta : Aviao
    {
        public double MinimumTakeoffArea { get; set; }
        public double MinimumLandingArea { get; set; }
        public double FreightValue { get; set; }

        public Avioneta() : base()
        {
            MinimumTakeoffArea = 0.0;
            MinimumLandingArea = 0.0;
            FreightValue = 0.0;
        }

        public Avioneta(int id, string model, int capacity, int autonomy, string maintenanceDate,
                        string activity, int engineQuantity, string brand, int manufacturingYear,
                        double minimumTakeoffArea, double minimumLandingArea, double freightValue)
                        : base(id, model, capacity, autonomy, maintenanceDate, activity, engineQuantity, brand, manufacturingYear)
        {
            MinimumTakeoffArea = minimumTakeoffArea;
            MinimumLandingArea = minimumLandingArea;
            FreightValue = freightValue;
        }

        public override string ToString()
        {
            return base.ToString() + " Minimum Takeoff and Landing Area: " + MinimumLandingArea +
                   " Freight Value: " + FreightValue;
        }
    }
}
