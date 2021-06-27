using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19VaccinationChallenge
{
    public interface IFileReadService
    {
        public List<People> loadPeopleJson();

        public List<VaccinationCentre> loadVaccinationCentresJson();
    }
}
