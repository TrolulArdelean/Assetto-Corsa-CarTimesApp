using Assetto_Corsa_CarTimesApp.Models;
using IniParser;
using System.Collections.Generic;

namespace Assetto_Corsa_CarTimesApp.LogicClasses
{
    class TimesContext
    {
        public List<LapTime> lapTimes = new List<LapTime>();

        public FileIniDataParser parser = new FileIniDataParser();

        public List<string> Tracks = new List<string>();

        public TimesContext()
        {

        }

        public void SetPersonalBestIni(string personalBestPath)
        {
            var data = parser.ReadFile(personalBestPath);
        }
    }
}
