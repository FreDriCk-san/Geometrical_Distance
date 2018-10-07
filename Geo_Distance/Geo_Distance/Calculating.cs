using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo_Distance
{
    public class Calculating
    {
        public Point start;
        public Point end;

        public Calculating(Point start, Point end)
        {
            if (PointCheck(start) && PointCheck(end))
            {
                this.start = start;
                this.end = end;
            }
        }



        public double Distance()
        {
            try
            {
                var radius = 6371e3;

                var sLatitude = ToRadians(start.X);
                var eLatitude = ToRadians(end.X);

                var sLongtitude = ToRadians(end.X - start.X);
                var eLongtitude = ToRadians(end.Y - start.Y);

                var temp = Math.Sin(sLongtitude / 2) * Math.Sin(sLongtitude / 2) +
                Math.Cos(sLatitude) * Math.Cos(eLatitude) *
                Math.Sin(eLongtitude / 2) * Math.Sin(eLongtitude / 2);

                var angle = 2 * Math.Atan2(Math.Sqrt(temp), Math.Sqrt(1 - temp));

                // Divide by 1000 for km
                return radius * angle / 1000;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Distance Error: " + exception.Message);
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
                Console.WriteLine("ToRadians Error: " + exception.Message);
            }

            return 0;
        }



        private static bool PointCheck(Point point)
        {
            try
            {
                // Latitude must be more than -90 degrees and less than 90 degress
                if (point.X <= 90 && point.X >= -90)
                {
                    // Longtitude must be more than -180 degrees and less than 180 degress
                    if (point.Y <= 180 && point.Y >= -180)
                    {
                        return true;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("PointCheck Error: " + exception.Message);
            }

            return false;
        }

    }
}
