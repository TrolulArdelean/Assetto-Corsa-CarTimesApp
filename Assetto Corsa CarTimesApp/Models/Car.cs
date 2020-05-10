using Newtonsoft.Json;
using System.IO;

namespace Assetto_Corsa_CarTimesApp.Models
{
    public class Car
    {
        public string FolderName { get; set; }
        public CarUiJson UiProperties { get; set; }

        public Car(string folderName)
        {
            this.FolderName = folderName;
            this.UiProperties = SetCarUiProperties(FolderName);
        }

        private CarUiJson SetCarUiProperties(string carFolderPath)
        {
            var jsonPath = string.Concat(carFolderPath, "\\", "ui", "\\", "ui_car.json");
            var json = JsonConvert.DeserializeObject<CarUiJson>(File.ReadAllText(jsonPath));

            return json;
        }
    }
}
