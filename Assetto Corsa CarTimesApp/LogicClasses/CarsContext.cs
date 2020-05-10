using System.Collections.Generic;
using System.IO;
using System.Linq;
using Assetto_Corsa_CarTimesApp.Models;

namespace Assetto_Corsa_CarTimesApp.LogicClasses
{
    public class CarsContext
    {
        public List<Car> AllCars { get; private set; }

        public CarsContext() 
        {

        }

        private List<Car> GetAllCars(string carsFolder)
        {
            var cars = new List<Car>();

            var carFolderPaths = Directory.GetDirectories(carsFolder).ToList();

            foreach(var carPath in carFolderPaths)
            {
                var folders = Directory.GetDirectories(carPath).ToList();

                foreach (var folder in folders)
                {
                    if (!folder.EndsWith("\\ui"))
                    {
                        continue;
                    }

                    cars.Add(new Car(carPath));
                }
            }

            return cars;
        }

        public void SetAllCars(string carsFolder)
        {
            this.AllCars = GetAllCars(carsFolder);
        }
    }
}
