using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Assetto_Corsa_CarTimesApp.LogicClasses;
using Newtonsoft.Json;

namespace Assetto_Corsa_CarTimesApp
{
    public partial class MainForm : Form
    {
        private AssettoCorsaProperties assettoCorsaProperties = new AssettoCorsaProperties();
        private CarsContext carsContext = new CarsContext();
        private TimesContext timesContext = new TimesContext();
        private Config config = new Config();
        private const string exeNotFound = "AssettoCorsa.exe was not found in the specified directory!";
        private const string exeFound = "AssettoCorsa.exe was found.";

        public MainForm()
        {
            InitializeComponent();
            config.ReadConfigFile();
            SetExeStatusForLabels();
            SetIniStatusForLabels();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            var selectFolder = new FolderBrowserDialog();
            selectFolder.ShowDialog();
            config.SetAssettoCorsaRootPath(selectFolder.SelectedPath);
            SetExeStatusForLabels();
            assettoCorsaProperties.SetCarsPath(config.AssettoCorsaRootPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text.Equals(exeNotFound))
            {
                textBox2.Text = "AssettoCorsa.exe is not in the currently selected folder. Please select the correct folder in order to continue.";
                textBox2.ForeColor = Color.Red;
            }
            else
            {
                carsContext.SetAllCars(assettoCorsaProperties.CarsFolder);
                textBox2.Text = string.Concat("Found ", carsContext.AllCars.Count, " cars.");
                textBox2.ForeColor = Color.Green;
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            var selectFolder = new FolderBrowserDialog();
            selectFolder.ShowDialog();
            config.SetAssettoCrosaMyDocumentsPath(selectFolder.SelectedPath);
            SetIniStatusForLabels();
            assettoCorsaProperties.SetPersonalBestPath(config.AssettoCrosaMyDocumentsPath);
        }

        public void SetExeStatusForLabels() 
        {
            var exeStatus = config.isAssettoCorsaExeFound();
            label2.Text = exeStatus.Key;
            label2.ForeColor = exeStatus.Value;
            label4.Text = string.Concat("Current Path: ", config.AssettoCorsaRootPath);
        }

        public void SetIniStatusForLabels()
        {
            var iniStatus = config.isPersonalBestIniFound();
            label3.Text = iniStatus.Key;
            label3.ForeColor = iniStatus.Value;
            label5.Text = string.Concat("Current Path: ", config.AssettoCrosaMyDocumentsPath);
        }
    }
}
