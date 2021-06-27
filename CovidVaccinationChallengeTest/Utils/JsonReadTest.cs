using Covid19VaccinationChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidVaccinationChallengeTest
{   
    [TestClass]
    public class JsonReadTest
    {
        [TestMethod]
        public void GetFilePathTest()
        {
            string strWorkPath = getExecutingAssembly();
            string filePath = JsonRead.GetFilePath("");
            string expectedFilePath = strWorkPath + "";
            Assert.AreEqual(expectedFilePath, filePath);
        }

        private string getExecutingAssembly()
        {

            string strExeFilePath = AppDomain.CurrentDomain.BaseDirectory;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);

            return strWorkPath;
        }

        [TestMethod]
        public void GetPeopleTest()
        {
            string strWorkPath = getExecutingAssembly();
            string filePath = JsonRead.GetFilePath(Constants.PEOPLE_JSON);
            List<People> peopleList = JsonRead.GetPeople(filePath);
            Assert.AreEqual(82, peopleList.Count);
        }
        [TestMethod]
        public void GetPeopleNullTest()
        {

            string strWorkPath = getExecutingAssembly();
            string filePath = JsonRead.GetFilePath("");
            Assert.IsNull(JsonRead.GetPeople(filePath));
        }

        [TestMethod]
        public void GetVacinnationCentreTest()
        {
            string strWorkPath = getExecutingAssembly();
            string filePath = JsonRead.GetFilePath(Constants.VACCINATION_CENTRE);
            List<VaccinationCentre> vaccList = JsonRead.GetVaccinationCentres(filePath);
            Assert.AreEqual(3, vaccList.Count);
        }
        [TestMethod]
        public void GetVaccinationCentreNullTest()
        {

            string strWorkPath = getExecutingAssembly();
            string filePath = JsonRead.GetFilePath("");
            Assert.IsNull(JsonRead.GetVaccinationCentres(filePath));
        }
    }
}
