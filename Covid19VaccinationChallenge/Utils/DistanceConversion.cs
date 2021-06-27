using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19VaccinationChallenge
{
    public static class DistanceConversion
    {
        // Convert the degrees into radians.
        private static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        public static double calculateDistance(double lat1,
                               double lat2,
                               double lon1,
                               double lon2)
        {

            //convert degress to radians
            lon1 = DegreesToRadians(lon1);
            lon2 = DegreesToRadians(lon2);
            lat1 = DegreesToRadians(lat1);
            lat2 = DegreesToRadians(lat2);

            // Haversine formula
            double dlon = lon2 - lon1;
            double dlat = lat2 - lat1;
            double value = Math.Pow(Math.Sin(dlat / 2), 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Pow(Math.Sin(dlon / 2), 2);

            double dist = 2 * Math.Asin(Math.Sqrt(value));

            // calculate the result by multiplying radius of earth in km
            return (dist * Constants.RADIUS);
        }


    }
}
