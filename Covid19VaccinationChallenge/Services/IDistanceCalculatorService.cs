using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19VaccinationChallenge
{
    public interface IDistanceCalculatorService
    {
        public List<People> CalculateDistance(List<People> peopleList, List<VaccinationCentre> vaccinationList);
    }
}
