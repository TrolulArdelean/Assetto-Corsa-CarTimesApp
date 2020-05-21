using System.Collections.Generic;

namespace Assetto_Corsa_CarTimesApp.Models
{
    public class ComparrisonData
    {
        public Car Car { get; set; }
        public List<LapTime> LapTimes { get; set; }

        public ComparrisonData(Car car, List<LapTime> lapTimes)
        {
            Car = car;
            LapTimes = lapTimes;
        }
    }
}
