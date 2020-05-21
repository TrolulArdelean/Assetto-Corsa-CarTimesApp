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
        public double TimeInSeconds { get; set; }
        public KeyValuePair<int, double> Time { get; private set; }

        public LapTime(SectionData personalBestIniSection, TrackLayout trackLayout)
        {
            Track = trackLayout;
            RawDate = Convert.ToInt64(personalBestIniSection.Keys.GetKeyData("DATE").Value);
            RawTime = Convert.ToInt64(personalBestIniSection.Keys.GetKeyData("TIME").Value);
            TimeInSeconds = CalculateLapTimeInSeconds(RawTime);
            Time = CalculateTimeInMinutes(TimeInSeconds);
        }

        private double CalculateLapTimeInSeconds(long rawTime)
        {
            return (double) rawTime / 1000;
        }

        private KeyValuePair<int, double> CalculateTimeInMinutes(double timeInSeconds)
        {
            var minutes = (int) timeInSeconds / 60;
            var seconds = timeInSeconds - minutes * 60;

            return new KeyValuePair<int, double>(minutes, seconds);
        }
    }
}
