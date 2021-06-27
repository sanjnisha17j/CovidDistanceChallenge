using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Covid19VaccinationChallenge
{
    public static class DistanceCalculator
    {
        public static List<People> CalculateDistance(List<People> peopleList, List<VaccinationCentre> vacList)
        {
            if((peopleList == null || peopleList.Count == 0) ||
                (vacList == null || vacList.Count == 0))
            {
                Console.WriteLine("Either people json or vaccination centre json unavailable");
                return null;
            }
            List<People> updatedPeopleList = new List<People>();
            foreach(People person in peopleList)
            {
                People updatedPerson = CalculateDistanceFromEachCentre(person, vacList);
                updatedPeopleList.Add(updatedPerson);
            }
            return updatedPeopleList;
        }

        private static People CalculateDistanceFromEachCentre(People person,List<VaccinationCentre> vacList) 
        {
            double distance = 0d;
            Dictionary<string, double> distanceFromCentre = new Dictionary<string, double>();
            foreach(VaccinationCentre vac in vacList)
            {
                distance = DistanceConversion.calculateDistance(person.Latitude, vac.Latitude, person.Longitude, person.Longitude);
                distanceFromCentre.Add(vac.Name, distance);
            }
            person.Distance = distanceFromCentre.OrderBy(x=>x.Value).ToDictionary(x=>x.Key,x=>x.Value);
            person.VacCentre = person.Distance.Keys.FirstOrDefault();
            return person;
        }

    }
}
