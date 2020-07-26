using IniParser.Model;
using System;
using System.Collections.Generic;

namespace Assetto_Corsa_CarTimesApp.Models
{
    public class LapTime
    {
        public TrackLayout Track { get; private set; }
        public long RawDate { get; private set; }
        public long RawTime { get; private set; }
        public Time Time { get; private set; }

        public LapTime(SectionData personalBestIniSection, TrackLayout trackLayout)
        {
            Track = trackLayout;
            RawDate = Convert.ToInt64(personalBestIniSection.Keys.GetKeyData("DATE").Value);
            RawTime = Convert.ToInt64(personalBestIniSection.Keys.GetKeyData("TIME").Value);
            Time = new Time(RawTime);
        }
    }
}
