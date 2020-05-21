using Assetto_Corsa_CarTimesApp.Models;

namespace Assetto_Corsa_CarTimesApp.LogicClasses.ComparrisonTypes
{
    public class TwoCarComparisson
    {
        public TwoCarComparisson(TimesContext timesContext, Car carOne, Car carTwo)
        {
            CarOneData = new ComparrisonData(carOne, timesContext.GetLapTimesForCar(carOne));

            CarTwoData = new ComparrisonData(carTwo, timesContext.GetLapTimesForCar(carTwo));
        }

        public ComparrisonData CarOneData { get; private set; }
        public ComparrisonData CarTwoData { get; private set; }
    }
}
