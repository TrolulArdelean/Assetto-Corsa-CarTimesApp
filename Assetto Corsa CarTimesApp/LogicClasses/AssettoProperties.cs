using System.Collections.Generic;

namespace Assetto_Corsa_CarTimesApp.LogicClasses
{
    public class AssettoCorsaProperties
    {
        public string AssettoCorsaPath { get; private set; }
        private string ContentFolder { get; set; }
        public string CarsFolder { get; private set; }
        public string personalBestIniPath { get; private set; }

        public AssettoCorsaProperties()
        {

        }

        public void SetCarsPath(string path)
        {
            AssettoCorsaPath = path;
            ContentFolder = string.Concat(AssettoCorsaPath, "\\content");
            CarsFolder = string.Concat(ContentFolder, "\\cars");
        }

        public void SetPersonalBestPath(string path)
        {
            personalBestIniPath = path;
        }
    }
}
