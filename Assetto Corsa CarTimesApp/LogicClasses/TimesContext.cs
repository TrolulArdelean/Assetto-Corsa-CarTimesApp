using Assetto_Corsa_CarTimesApp.Models;
using IniParser;
using IniParser.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assetto_Corsa_CarTimesApp.LogicClasses
{
    class TimesContext
    {
        public FileIniDataParser parser = new FileIniDataParser();

        private AssettoCorsaProperties AssettoCorsaProperties { get; set; }

        public List<string> TracksInIni { get; private set; }

        public List<TrackLayout> TrackLayouts = new List<TrackLayout>();

        public TimesContext(AssettoCorsaProperties assettoCorsaProperties)
        {
            AssettoCorsaProperties = assettoCorsaProperties;
            SetPersonalBestIni();
            GetTrackLayouts();
        }

        private void SetPersonalBestIni()
        {
            var iniData = parser.ReadFile(AssettoCorsaProperties.PersonalBestIniPath + "\\personalbest.ini");
            var iniSections = iniData.Sections.ToList();

            TracksInIni = GetTrackNamesInPersonalBestIni(iniSections);
        }

        private List<string> GetTrackNamesInPersonalBestIni(List<SectionData> iniSections)
        {
            List<string> trackNames = new List<string>();

            foreach (var section in iniSections)
            {
                var trackName = section.SectionName.Substring(section.SectionName.IndexOf("@"));

                if (!trackNames.Contains(trackName))
                {
                    trackNames.Add(trackName);
                }
            }

            return trackNames;
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
    }
}
