using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19VaccinationChallenge
{
    class Program
    {
        public static void Main(string[] args)
        {
            var engine = new CalculationEngine(new FileReadService(),
                new DistanceCalculatorService(), new DisplayService());

            engine.CalculateDistance();
        }

    }
}
