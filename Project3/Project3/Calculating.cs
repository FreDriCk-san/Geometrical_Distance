using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class Calculating
    {
        public GeoPoint Start;
        public GeoPoint End;

        public Calculating(GeoPoint start, GeoPoint end)
        {
            if (PointCheck(start) && PointCheck(end))
            {
                this.Start = start;
                this.End = end;
            }
        }



        public double Distance()
        {
            try
            {
                var radius = 6371e3;

                var sLatitude = ToRadians(Start.Longtitude);
                var eLatitude = ToRadians(End.Longtitude);

                var sLongtitude = ToRadians(End.Longtitude - Start.Longtitude);
                var eLongtitude = ToRadians(End.Latitude - Start.Latitude);

                var temp = Math.Sin(sLongtitude / 2) * Math.Sin(sLongtitude / 2) +
                Math.Cos(sLatitude) * Math.Cos(eLatitude) *
                Math.Sin(eLongtitude / 2) * Math.Sin(eLongtitude / 2);

                var angle = 2 * Math.Atan2(Math.Sqrt(temp), Math.Sqrt(1 - temp));

                // Divide by 1000 for km
                return radius * angle / 1000;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Distance Error: {exception.Message}");
            }

            return 0;
        }



        private static double ToRadians(double value)
        {
            try
            {
                return (Math.PI / 180) * value;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"ToRadians Error: {exception.Message}");
            }

            return 0;
        }



        private static bool PointCheck(GeoPoint point)
        {
            try
            {
                // Latitude must be more than -90 degrees and less than 90 degress
                if (Math.Abs(point.Latitude) <= 90.0)
                {
                    // Longtitude must be more than -180 degrees and less than 180 degress
                    if (Math.Abs(point.Longtitude) <= 180.0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"PointCheck Error: {exception.Message}");
            }

            return false;
        }

    }
}
