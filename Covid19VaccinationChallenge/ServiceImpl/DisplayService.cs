using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Covid19VaccinationChallenge
{
    public class DisplayService : IDisplayService
    {
        public void DisplayPeople(List<People> peopleList)
        {
            if ((peopleList == null || peopleList.Count == 0))
            {
                Console.WriteLine("People list unavailable");
            }
            try
            {
                //Group by vaccination centre
                var result = from people in peopleList
                             group people by people.VacCentre;


                foreach (var peopleGroup in result)
                {
                    Console.WriteLine("Vaccination Centre : " + peopleGroup.Key);
                    //Sort by age
                    var orderedSortGroup = peopleGroup.OrderByDescending(p => p.Age);
                    foreach (var people in orderedSortGroup)
                    {
                        if(people.Name.Length   < 10)
                            Console.Write("Name :\t" + people.Name);
                        else
                            Console.Write("Name :" + people.Name);
                        Console.Write("\t Age :" + people.Age.ToString());
                        Console.Write(String.Format("\t Latitude : {0:0.00}", people.Latitude));
                        Console.Write(String.Format("\t Longitude : {0:0.00}", people.Longitude));
                        Console.Write("\t Distance from centre :" + people.Distance.Values.FirstOrDefault());
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error encountered in DisplayService : " + ex.Message);
            }
        }
    }
}
