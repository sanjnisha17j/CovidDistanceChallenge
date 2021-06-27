using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19VaccinationChallenge
{
    public class CalculationEngine
    {
        private readonly IFileReadService _fileReadService;

        private readonly IDisplayService _displayService;

        private readonly IDistanceCalculatorService _distanceCalculatorService;

        public CalculationEngine(IFileReadService fileReadService,
            IDistanceCalculatorService distanceCalculatorService,IDisplayService displayService)
        {
            _fileReadService = fileReadService;
            _displayService = displayService;
            _distanceCalculatorService = distanceCalculatorService;
        }

        public void CalculateDistance()
        {

            //Read People Json
            List<People> peopleList = _fileReadService.loadPeopleJson();

            //Read Vaccination Centre json
            List<VaccinationCentre> vaccCentres = _fileReadService.loadVaccinationCentresJson();

            //Calculate distance and update in the People object
            List<People> updatedPeopleList = _distanceCalculatorService.CalculateDistance(peopleList, vaccCentres);

            _displayService.DisplayPeople(updatedPeopleList);
        }
    }
}
