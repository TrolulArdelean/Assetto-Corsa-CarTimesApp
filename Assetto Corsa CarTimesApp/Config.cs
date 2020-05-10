using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Assetto_Corsa_CarTimesApp
{
    public class Config
    {
        [JsonProperty("assettoCorsaRootPath")]
        public string AssettoCorsaRootPath { get; private set; }

        [JsonProperty("assettoCrosaMyDocumentsPath")]
        public string AssettoCrosaMyDocumentsPath { get; private set; }

        public void ReadConfigFile()
        {
            var currentConfig = JsonConvert.DeserializeObject<Config>(File.ReadAllText(string.Concat(Directory.GetCurrentDirectory(), "\\ConfigFile.json")));

            this.AssettoCorsaRootPath = currentConfig.AssettoCorsaRootPath;
            this.AssettoCrosaMyDocumentsPath = currentConfig.AssettoCrosaMyDocumentsPath;
        }

        public KeyValuePair<string, Color> isAssettoCorsaExeFound()
        {
            var exeStatus = "AssettoCorsa.exe was not found in the specified directory!";
            var color = Color.Red;

            if (Directory.Exists(this.AssettoCorsaRootPath))
            {
                var files = Directory.GetFiles(this.AssettoCorsaRootPath);
                string path = string.Concat(this.AssettoCorsaRootPath, "\\AssettoCorsa.exe");

                if (files.Contains(path))
                {
                    exeStatus = "AssettoCorsa.exe was found.";
                    color = Color.Green;
                }
            }

            return new KeyValuePair<string, Color>(exeStatus, color);
        }

        public KeyValuePair<string, Color> isPersonalBestIniFound()
        {
            var iniStatus = "personalbest.ini was not found in the specified directory!";
            var color = Color.Red;

            if (Directory.Exists(this.AssettoCrosaMyDocumentsPath))
            {
                var files = Directory.GetFiles(this.AssettoCrosaMyDocumentsPath);
                string path = string.Concat(this.AssettoCrosaMyDocumentsPath, "\\personalbest.ini");

                if (files.Contains(path))
                {
                    iniStatus = "personalbest.ini was found.";
                    color = Color.Green;
                }
            }

            return new KeyValuePair<string, Color>(iniStatus, color);
        }

        public void SetAssettoCorsaRootPath(string newPath)
        {
            this.AssettoCorsaRootPath = newPath;
        }

        public void SetAssettoCrosaMyDocumentsPath(string newPath)
        {
            this.AssettoCrosaMyDocumentsPath = newPath;
        }
    }
}
