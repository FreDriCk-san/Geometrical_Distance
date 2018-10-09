using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class GeoPoint
    {
        public double Longtitude { get; }
        public double Latitude { get; }

        public GeoPoint(double latitude, double longtitude)
        {
            this.Latitude = latitude;
            this.Longtitude = Longtitude;
        }
    }
}
