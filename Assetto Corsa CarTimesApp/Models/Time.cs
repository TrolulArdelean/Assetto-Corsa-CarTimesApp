using System.Collections.Generic;

namespace Assetto_Corsa_CarTimesApp.Models
{
    public class Time
    {
        public int Minutes { get; private set; }
        public double Seconds { get; private set; }
        public double FullLapSeconds { get; private set; }


        public Time(long rawTimeMilis)
        {
            FullLapSeconds = CalculateLapTimeInSeconds(rawTimeMilis);
            Minutes = CalculateTimeInMinutes(FullLapSeconds).Key;
            Seconds = CalculateTimeInMinutes(FullLapSeconds).Value;
        }

        private double CalculateLapTimeInSeconds(long rawTimeMilis)
        {
            return (double)rawTimeMilis / 1000;
        }

        private KeyValuePair<int, double> CalculateTimeInMinutes(double timeInSeconds)
        {
            var minutes = (int)timeInSeconds / 60;
            var seconds = timeInSeconds - minutes * 60;

            return new KeyValuePair<int, double>(minutes, seconds);
        }
    }
}
