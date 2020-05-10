using Assetto_Corsa_CarTimesApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Ini;
using System.Collections.Generic;

namespace Assetto_Corsa_CarTimesApp.LogicClasses
{
    class TimesContext
    {
        public List<LapTime> lapTimes = new List<LapTime>();

        public IniConfigurationSource personalBest = new IniConfigurationSource();

        public IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

        public TimesContext()
        {

        }

        public void SetPersonalBestIni(string personalBestPath)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            personalBest.Path = personalBestPath;
            var builded = personalBest.Build(configurationBuilder);
        }
    }
}
