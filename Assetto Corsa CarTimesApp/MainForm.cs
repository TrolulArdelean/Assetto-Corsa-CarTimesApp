using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Assetto_Corsa_CarTimesApp.LogicClasses;
using Assetto_Corsa_CarTimesApp.LogicClasses.ComparrisonTypes;
using Assetto_Corsa_CarTimesApp.Models;

namespace Assetto_Corsa_CarTimesApp
{
    public partial class MainForm : Form
    {
        private AssettoCorsaProperties assettoCorsaProperties = new AssettoCorsaProperties();
        private CarsContext carsContext = new CarsContext();
        private TimesContext timesContext;
        private Config config = new Config();
        private const string exeNotFound = "AssettoCorsa.exe was not found in the specified directory!";
        private const string exeFound = "AssettoCorsa.exe was found.";
        private List<Button> carActionsButtons = new List<Button>();
        private List<ComboBox> twoCarComparerComboBoxes = new List<ComboBox>();
        private List<Button> basicBeforeComparissonButtons = new List<Button>();
        private TwoCarComparisson twoCarComparisson;
        private List<Car> selectedCars;

        public MainForm()
        {
            InitializeComponent();

            // Initiate required objects
            SetCarActionButtons();
            SetBasicComparerButtons();
            SetTwoCarComparerComboBoxes();

            // Setup - read config
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
            assettoCorsaProperties.SetContentPaths(config.AssettoCorsaRootPath);
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
                CheckSetupStatus();
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

        private void button4_Click(object sender, EventArgs e)
        {
            selectedCars = new Car[2].ToList();
            EnableButtons(basicBeforeComparissonButtons);
            EnableComboBoxes(twoCarComparerComboBoxes);
            button5.Enabled = false;
            comboBox1.Items.AddRange(carsContext.CarBrands.ToArray());
            comboBox3.Items.AddRange(carsContext.CarBrands.ToArray());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisableComboBoxes(twoCarComparerComboBoxes);
            DisableButtons(basicBeforeComparissonButtons);
            selectedCars.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = null;
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(carsContext.GetCarsByBrandName(comboBox1.Text));
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox4.Text = null;
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(carsContext.GetCarsByBrandName(comboBox3.Text));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCars[0] = carsContext.FindCarByBrandAndModelName(comboBox1.Text, comboBox2.Text);

            if (CheckThatTheComboBoxesHaveValues(twoCarComparerComboBoxes) && CheckSelectedCarValues(selectedCars)) 
            {
                button5.Enabled = true;
            }
            else
            {
                button5.Enabled = false;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCars[1] = carsContext.FindCarByBrandAndModelName(comboBox3.Text, comboBox4.Text);

            if (CheckThatTheComboBoxesHaveValues(twoCarComparerComboBoxes) && CheckSelectedCarValues(selectedCars))
            {
                button5.Enabled = true;
            }
            else
            {
                button5.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisableButtons(basicBeforeComparissonButtons);
            DisableButton(button4);
            DisableComboBoxes(twoCarComparerComboBoxes);

            EnableButton(backButton);

            twoCarComparisson = new TwoCarComparisson(timesContext, selectedCars[0], selectedCars[1]);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            EnableButtons(basicBeforeComparissonButtons);
            EnableButton(button4);
            EnableComboBoxes(twoCarComparerComboBoxes);

            DisableButton(backButton);
        }

        public void SetExeStatusForLabels() 
        {
            var exeStatus = config.IsAssettoCorsaExeFound();
            label2.Text = exeStatus.Key;
            label2.ForeColor = exeStatus.Value;
            label4.Text = string.Concat("Current Path: ", config.AssettoCorsaRootPath);

            if (exeStatus.Key.Equals(exeFound))
            {
                assettoCorsaProperties.SetContentPaths(config.AssettoCorsaRootPath);
            }
        }

        public void SetIniStatusForLabels()
        {
            if (label2.Text.Equals(exeFound))
            {
                var iniStatus = config.IsPersonalBestIniFound();
                label3.Text = iniStatus.Key;
                label3.ForeColor = iniStatus.Value;
                label5.Text = string.Concat("Current Path: ", config.AssettoCrosaMyDocumentsPath);
                label5.ForeColor = iniStatus.Value;
                if (label2.Text.Equals(exeFound))
                {
                    if (iniStatus.Key.Equals("personalbest.ini was found."))
                    {
                        assettoCorsaProperties.SetPersonalBestPath(config.AssettoCrosaMyDocumentsPath);
                        timesContext = new TimesContext(assettoCorsaProperties);
                    }
                }
            }
            else
            {
                label5.Text = "Select the Assetto Corsa root instalation folder first!";
                label5.ForeColor = Color.Red;
                label3.ForeColor = Color.Red; 
            }
        }

        public void CheckSetupStatus()
        {
            if (label2.ForeColor == Color.Green && label5.ForeColor == Color.Green && textBox2.Text.Contains("Found"))
            {
                EnableButtons(carActionsButtons);
            }
            else
            {
                DisableButtons(carActionsButtons);
            }
        }

        public void EnableButtons(List<Button> requiredButtons)
        {
            foreach (var button in requiredButtons)
            {
                button.Enabled = true;
                button.Visible = true;
            }
        }

        public void EnableButton(Button requiredButton)
        {
            requiredButton.Visible = true;
            requiredButton.Enabled = true;
        }

        public void DisableButtons(List<Button> requiredButtons)
        {
            foreach (var button in requiredButtons)
            {
                button.Visible = false;
                button.Enabled = false;
            }
        }

        public void DisableButton(Button requiredButton)
        {
            requiredButton.Visible = false;
            requiredButton.Enabled = false;
        }

        public void EnableComboBoxes(List<ComboBox> requiredComboBoxes)
        {
            foreach (var comboBox in requiredComboBoxes)
            {
                comboBox.Enabled = true;
                comboBox.Visible = true;
            }
        }

        public void DisableComboBoxes(List<ComboBox> requiredComboBoxes)
        {
            foreach (var comboBox in requiredComboBoxes)
            {
                comboBox.Text = string.Empty;
                comboBox.Visible = false;
                comboBox.Enabled = false;
            }
        }

        public void SetCarActionButtons()
        {
            carActionsButtons.Add(button4);
        }

        public void SetBasicComparerButtons()
        {
            basicBeforeComparissonButtons.Add(button5);
            basicBeforeComparissonButtons.Add(button6);
        }

        public void SetTwoCarComparerComboBoxes()
        {
            twoCarComparerComboBoxes.Add(comboBox1);
            twoCarComparerComboBoxes.Add(comboBox2);
            twoCarComparerComboBoxes.Add(comboBox3);
            twoCarComparerComboBoxes.Add(comboBox4);
        }

        public bool CheckThatTheComboBoxesHaveValues(List<ComboBox> comboBoxes)
        {
            foreach (var comboBox in comboBoxes)
            {
                if (comboBox.Text.Equals(null) || comboBox.Text.Equals("Select Car Brand first"))
                {
                    return false;
                }
            }

            return true;
        }

        public bool CheckSelectedCarValues(List<Car> selectedCars)
        {
            foreach (var car in selectedCars)
            {
                if (car == null)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
