using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Project3
{
    public class FileIOHelper : IIOHelper
    {
        private string pathandfile;

        public FileIOHelper(string pathAndFile)
        {
            pathandfile = pathAndFile;
        }

        public void AddMortgages(string formattedTempString)
        {

            try
            {
                string fileLocation = pathandfile; //HttpContext.Current.Server.MapPath("~/app_data/log.txt");
                using (var fileStream = File.AppendText(fileLocation))
                {
                    fileStream.WriteLine(formattedTempString);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void ClearAllMortgages()
        {
            try
            {
                string fileLocation = pathandfile; //HttpContext.Current.Server.MapPath("~/app_data/log.txt");
                File.Delete(fileLocation);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<string> ListAllMortgages()
        {
            List<string> allData = new List<string>();
            string fileLocation = pathandfile; //HttpContext.Current.Server.MapPath("~/app_data/log.txt");

            if (File.Exists(fileLocation))
            {
                string[] allTempStringArray = File.ReadAllLines(fileLocation);

                allData = new List<string>(allTempStringArray);
            }

            return allData;
        }
    }
}