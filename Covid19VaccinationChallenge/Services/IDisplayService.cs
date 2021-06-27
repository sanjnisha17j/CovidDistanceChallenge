using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19VaccinationChallenge
{
    public interface IDisplayService
    {
        public void DisplayPeople(List<People> peopleList);
    }
}
