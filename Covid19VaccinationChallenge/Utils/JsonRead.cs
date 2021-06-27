using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Covid19VaccinationChallenge
{
    public static class JsonRead
    {
        public static List<People> GetPeople(string filePath)
        {
            try
            {
                var stream = "";
                try
                {
                    stream = File.ReadAllText(filePath);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("FilePath for reading People json incorrect" + ex.Message);
                    return null;
                }
                var serializeOptions = new JsonSerializerOptions();

                serializeOptions.Converters.Add(new Int32Converter());
                serializeOptions.Converters.Add(new DoubleConverter());


                return JsonSerializer.Deserialize<List<People>>(stream, serializeOptions);
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error encountered while reading people json " + ex.Message);
                return null;
            }

        }

        public static string GetFilePath(String jsonFile)
        {
            string strExeFilePath = AppDomain.CurrentDomain.BaseDirectory;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);

            string filePath = strWorkPath + jsonFile;
            return filePath;
        }

        public static List<VaccinationCentre> GetVaccinationCentres(string filePath)
        {
            try
            {
                var stream = "";
                try
                {
                    stream = File.ReadAllText(filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("FilePath for reading Vaccination centre json incorrect" + ex.Message);
                    return null;
                }
                var serializeOptions = new JsonSerializerOptions();

                serializeOptions.Converters.Add(new DoubleConverter());

                return JsonSerializer.Deserialize<List<VaccinationCentre>>(stream, serializeOptions);
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error encountered while reading vaccination centres json " + ex.Message);
                return null;
            }

        }
    }
}
