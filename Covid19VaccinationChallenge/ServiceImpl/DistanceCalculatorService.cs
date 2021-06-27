using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19VaccinationChallenge
{
    public class DistanceCalculatorService : IDistanceCalculatorService
    {
        public List<People> CalculateDistance(List<People> peopleList, List<VaccinationCentre> vaccinationList)
        {
            try
            {
                return DistanceCalculator.CalculateDistance(peopleList, vaccinationList);
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error encountered in DistanceCalculatorService" + ex.Message);
                return null;
            }
        }
    }
}
