using System.Collections.Generic;
using System.IO;
using System.Linq;
using Assetto_Corsa_CarTimesApp.Models;

namespace Assetto_Corsa_CarTimesApp.LogicClasses
{
    public class CarsContext
    {
        public List<Car> AllCars { get; private set; }

        public List<string> CarBrands { get; private set; }

        public CarsContext() 
        {
            AllCars = new List<Car>();
            CarBrands = new List<string>();
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
            AllCars = GetAllCars(carsFolder);
            SetAllCarBrands();
        }

        public void SetAllCarBrands()
        {
            foreach(var car in AllCars)
            {
                string brand = car.UiProperties.Brand;

                if(!CarBrands.Contains(brand))
                {
                    CarBrands.Add(brand);
                }
            }

            CarBrands.Sort();
        }

        public string[] GetCarsByBrandName(string brandName)
        {
            var modelNames = new List<string>();
            var selectedCars = AllCars.FindAll(cars => cars.UiProperties.Brand.Equals(brandName));

            foreach (var car in selectedCars)
            {
                modelNames.Add(car.UiProperties.Name);
            }

            return modelNames.ToArray();
        }
    }
}
