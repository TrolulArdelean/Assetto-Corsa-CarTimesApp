using IniParser.Model;
using System;

namespace Assetto_Corsa_CarTimesApp.Models
{
    public class LapTime
    {
        public TrackLayout Track { get; set; }
        public int Date { get; set; }
        public int Time { get; set; }

        public LapTime(SectionData personalBestIniSection, TrackLayout trackLayout)
        {
            Track = trackLayout;
            Date = Convert.ToInt32(personalBestIniSection.Keys.GetKeyData("DATE"));
            Time = Convert.ToInt32(personalBestIniSection.Keys.GetKeyData("TIME"));
        }
    }
}
