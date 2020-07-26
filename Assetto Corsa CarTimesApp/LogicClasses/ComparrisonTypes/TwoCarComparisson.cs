using Assetto_Corsa_CarTimesApp.Models;
using System.Collections.Generic;

namespace Assetto_Corsa_CarTimesApp.LogicClasses.ComparrisonTypes
{
    public class TwoCarComparisson
    {
        public TwoCarComparisson(TimesContext timesContext, Car carOne, Car carTwo)
        {
            CarOneData = new ComparrisonData(carOne, timesContext.GetLapTimesForCar(carOne));

            CarTwoData = new ComparrisonData(carTwo, timesContext.GetLapTimesForCar(carTwo));

            CommonTrackLapTimes = GetCommonLapTimes();

            CommonTracksFound = CommonTrackLapTimes.Count;

            TotalDifference = CalculateDifferencesForAllLaptimes();

            PerTrackDifferences = CaluclateDifferencesForEachIndividualTrack();
        }

        public ComparrisonData CarOneData { get; private set; }
        public ComparrisonData CarTwoData { get; private set; }
        public List<KeyValuePair<LapTime, LapTime>> CommonTrackLapTimes { get; private set; }
        public int CommonTracksFound { get; private set; }
        public double TotalDifference { get; private set; }
        public List<KeyValuePair<TrackLayout, double>> PerTrackDifferences { get; private set; }

        private List<KeyValuePair<LapTime, LapTime>> GetCommonLapTimes()
        {
            List<KeyValuePair<LapTime, LapTime>> commonTracks = new List<KeyValuePair<LapTime, LapTime>>();

            foreach (var carOneLap in CarOneData.LapTimes)
            {
                foreach (var carTwoLap in CarTwoData.LapTimes)
                {
                    if (carOneLap.Track == carTwoLap.Track) 
                    {
                        commonTracks.Add(new KeyValuePair<LapTime, LapTime>(carOneLap, carTwoLap));
                    }
                }
            }

            return commonTracks;
        }

        private double CalculateDifferencesForAllLaptimes()
        {
            double carOneSum = 0;
            double carTwoSum = 0;

            foreach (var lap in CommonTrackLapTimes)
            {
                carOneSum += lap.Key.Time.FullLapSeconds;
            }

            foreach (var lap in CommonTrackLapTimes)
            {
                carTwoSum += lap.Value.Time.FullLapSeconds;
            }

            return carOneSum - carTwoSum;
        }

        private List<KeyValuePair<TrackLayout, double>> CaluclateDifferencesForEachIndividualTrack()
        {
            List<KeyValuePair<TrackLayout, double>> differences = new List<KeyValuePair<TrackLayout, double>>();

            foreach(var track in CommonTrackLapTimes)
            {
                double difference = track.Key.Time.FullLapSeconds - track.Value.Time.FullLapSeconds;
                differences.Add(new KeyValuePair<TrackLayout, double>(track.Key.Track, difference));
            }

            return differences;
        }
    }
}
