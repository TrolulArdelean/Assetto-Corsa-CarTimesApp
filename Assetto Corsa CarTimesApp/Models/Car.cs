using Newtonsoft.Json;
using System.IO;

namespace Assetto_Corsa_CarTimesApp.Models
{
    public class Car
    {
        public string FullFolderName { get; private set; }
        public string CarNameInPersonalBestIni { get; private set; }
        public CarUiJson UiProperties { get; private set; }

        public Car(string folderName)
        {
            FullFolderName = folderName;
            CarNameInPersonalBestIni = FullFolderName.Substring(FullFolderName.LastIndexOf("\\") + 1).ToUpper();
            UiProperties = SetCarUiProperties(FullFolderName);
        }

        private CarUiJson SetCarUiProperties(string carFolderPath)
        {
            var jsonPath = string.Concat(carFolderPath, "\\", "ui", "\\", "ui_car.json");
            var json = JsonConvert.DeserializeObject<CarUiJson>(File.ReadAllText(jsonPath));

            return json;
        }
    }
}
