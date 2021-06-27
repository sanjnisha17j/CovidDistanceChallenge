using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19VaccinationChallenge
{
    public class People
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string VacCentre { get; set; }

        public Dictionary<string,double> Distance { get; set; }

    }
}
