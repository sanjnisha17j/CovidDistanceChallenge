using Covid19VaccinationChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CovidVaccinationChallengeTest
{
    [TestClass]
    public class DistanceCalculatorTest
    {
        List<VaccinationCentre> vaccList;
        List<People> peopleList;

        [TestInitialize]
        public void Initialize()
        {
            VaccinationCentre centre1 = StubVacinnationCentre();
            People person = StubPeople();
            vaccList = new List<VaccinationCentre>();
            vaccList.Add(centre1);
            peopleList = new List<People>();
            peopleList.Add(person);
        }

        private People StubPeople()
        {
            People people = new People();
            people.Name = "Richard Parker";
            people.Age = 29;
            people.Latitude = 53.09402405506328;
            people.Longitude = -8.020019531250002;
            return people;
        }
        private VaccinationCentre StubVacinnationCentre()
        {
            VaccinationCentre centre = new VaccinationCentre();
            centre.Name = "My vac center";
            centre.Latitude = 53.28603418885669;
            centre.Longitude = -6.4444477725802285;
            return centre;
        }
        [TestMethod]
        public void CalculateDistanceTest()
        {
            List<People> updatedList = DistanceCalculator.CalculateDistance(peopleList, vaccList);
            People person = updatedList.FirstOrDefault();
            Double distance = person.Distance.Values.ElementAtOrDefault(0);
            Assert.AreEqual(21.35058290305114, distance);
        }
        [TestMethod]
        public void CalculateDistanceNullTest()
        {
            Assert.IsNull(DistanceCalculator.CalculateDistance(null, null));

        }
    }
}
