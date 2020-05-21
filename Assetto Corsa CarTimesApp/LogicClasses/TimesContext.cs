using Assetto_Corsa_CarTimesApp.Models;
using IniParser;
using IniParser.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assetto_Corsa_CarTimesApp.LogicClasses
{
    public class TimesContext
    {
        public FileIniDataParser parser = new FileIniDataParser();

        private AssettoCorsaProperties AssettoCorsaProperties { get; set; }

        private List<SectionData> IniSections { get; set; }

        public List<TrackLayout> TrackLayouts = new List<TrackLayout>();

        public TimesContext(AssettoCorsaProperties assettoCorsaProperties)
        {
            AssettoCorsaProperties = assettoCorsaProperties;
            ReadPersonalBestIni();
            GetTrackLayouts();
        }

        private void ReadPersonalBestIni()
        {
            var iniData = parser.ReadFile(AssettoCorsaProperties.PersonalBestIniPath + "\\personalbest.ini");
            IniSections = iniData.Sections.ToList();
        }

        private string GetTrackNameInPersonalBestIni(SectionData section)
        {
            return section.SectionName.Substring(section.SectionName.IndexOf("@") + 1);
        }

        private void GetTrackLayouts()
        {
            TrackLayout trackLayout;
            var trackFolders = Directory.GetDirectories(AssettoCorsaProperties.TracksFolder);

            foreach (var trackFolder in trackFolders)
            {
                var trackSubFolders = Directory.GetDirectories(trackFolder).ToList();

                foreach (var trackSubFolder in trackSubFolders)
                {
                    if (trackSubFolder.EndsWith("\\ui"))
                    {
                        if (Directory.GetDirectories(trackSubFolder).Length > 0)
                        {
                            var trackUiVariants = Directory.GetDirectories(trackSubFolder).ToList();

                            foreach (var variant in trackUiVariants)
                            {
                                if (!Directory.GetFiles(variant).Contains(string.Concat(variant, "\\ui_track.json")))
                                {
                                    continue;
                                }

                                trackLayout = JsonConvert.DeserializeObject<TrackLayout>(File.ReadAllText(string.Concat(variant, "\\ui_track.json")));
                                trackLayout.TrackNameInPersonalBestIni = string.Concat(trackFolder.Substring(trackFolder.LastIndexOf("\\") + 1),
                                    "-", variant.Substring(variant.LastIndexOf("\\") + 1)).ToUpper();
                                TrackLayouts.Add(trackLayout);
                            }

                            continue;
                        }

                        trackLayout = JsonConvert.DeserializeObject<TrackLayout>(File.ReadAllText(string.Concat(trackSubFolder, "\\ui_track.json")));
                        trackLayout.TrackNameInPersonalBestIni = trackFolder.Substring(trackFolder.LastIndexOf("\\") + 1).ToUpper();
                        TrackLayouts.Add(trackLayout);
                    }
                }
            }
        }

        public List<LapTime> GetLapTimesForCar(Car car)
        {
            var lapTimes = new List<LapTime>();

            var sectionsForCarInIni = IniSections.FindAll(s => s.SectionName.Contains(string.Concat(car.CarNameInPersonalBestIni, "@")));

            foreach (var section in sectionsForCarInIni)
            {
                var trackLayout = TrackLayouts.Find(t => t.TrackNameInPersonalBestIni.Equals(GetTrackNameInPersonalBestIni(section)));

                if (trackLayout == null)
                {
                    continue;
                }

                lapTimes.Add(new LapTime(section, trackLayout));
            }

            return lapTimes;
        }
    }
}
