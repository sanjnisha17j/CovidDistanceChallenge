using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19VaccinationChallenge
{
    public class FileReadService : IFileReadService
    {
        public List<People> loadPeopleJson()
        {
            try
            {
                string peoplefilePath = JsonRead.GetFilePath(Constants.PEOPLE_JSON);

                return JsonRead.GetPeople(peoplefilePath);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error encountered while reading People json file " + ex.Message);
                return null;
            }
        }

        public List<VaccinationCentre> loadVaccinationCentresJson()
        {
            try
            {
                string vaccDrivePath = JsonRead.GetFilePath(Constants.VACCINATION_CENTRE);

                return JsonRead.GetVaccinationCentres(vaccDrivePath);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error encountered while reading from Vaccination centre json " + ex.Message);
                return null;
            }
        }
    }
}
