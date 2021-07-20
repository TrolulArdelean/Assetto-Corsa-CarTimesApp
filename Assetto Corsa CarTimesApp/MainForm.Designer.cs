namespace Assetto_Corsa_CarTimesApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TwoCarComparison_Panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ResultsOverview_Textbox = new System.Windows.Forms.TextBox();
            this.CarTwoName_Textbox = new System.Windows.Forms.TextBox();
            this.CarOneName_Textbox = new System.Windows.Forms.TextBox();
            this.TwoCarComparer_Disclaimer = new System.Windows.Forms.TextBox();
            this.commonTrackLapTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.twoCarComparissonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.TwoCarComparison_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonTrackLapTimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoCarComparissonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(308, 0);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Find All Cars";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backButton
            // 
            this.backButton.Enabled = false;
            this.backButton.Location = new System.Drawing.Point(771, 545);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set Assetto Corsa Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Use the button above to set the installation path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "AssettoCorsa.exe was not found in the specified directory!";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(389, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 38);
            this.textBox2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(677, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Set Path in My Documents";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button3_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(676, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PersonalBest.ini not found!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Path:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Current Path:";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(389, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(281, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Compare 2 cars";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(389, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Car Brand 1";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(389, 165);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(281, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "Select Car Brand first";
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(389, 217);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(281, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.Text = "Car Brand 2";
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged_1);
            // 
            // comboBox4
            // 
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(389, 244);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(281, 21);
            this.comboBox4.TabIndex = 14;
            this.comboBox4.Text = "Select Car Brand first";
            this.comboBox4.Visible = false;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(456, 280);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Compare selected cars";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(456, 309);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TwoCarComparison_Panel
            // 
            this.TwoCarComparison_Panel.Controls.Add(this.dataGridView1);
            this.TwoCarComparison_Panel.Controls.Add(this.ResultsOverview_Textbox);
            this.TwoCarComparison_Panel.Controls.Add(this.CarTwoName_Textbox);
            this.TwoCarComparison_Panel.Controls.Add(this.CarOneName_Textbox);
            this.TwoCarComparison_Panel.Controls.Add(this.TwoCarComparer_Disclaimer);
            this.TwoCarComparison_Panel.Location = new System.Drawing.Point(3, 0);
            this.TwoCarComparison_Panel.Name = "TwoCarComparison_Panel";
            this.TwoCarComparison_Panel.Size = new System.Drawing.Size(1078, 539);
            this.TwoCarComparison_Panel.TabIndex = 18;
            this.TwoCarComparison_Panel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(847, 401);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ResultsOverview_Textbox
            // 
            this.ResultsOverview_Textbox.Location = new System.Drawing.Point(246, 30);
            this.ResultsOverview_Textbox.Multiline = true;
            this.ResultsOverview_Textbox.Name = "ResultsOverview_Textbox";
            this.ResultsOverview_Textbox.Size = new System.Drawing.Size(560, 40);
            this.ResultsOverview_Textbox.TabIndex = 3;
            // 
            // CarTwoName_Textbox
            // 
            this.CarTwoName_Textbox.Location = new System.Drawing.Point(748, 76);
            this.CarTwoName_Textbox.Name = "CarTwoName_Textbox";
            this.CarTwoName_Textbox.Size = new System.Drawing.Size(211, 20);
            this.CarTwoName_Textbox.TabIndex = 2;
            // 
            // CarOneName_Textbox
            // 
            this.CarOneName_Textbox.Location = new System.Drawing.Point(112, 76);
            this.CarOneName_Textbox.Name = "CarOneName_Textbox";
            this.CarOneName_Textbox.Size = new System.Drawing.Size(211, 20);
            this.CarOneName_Textbox.TabIndex = 1;
            // 
            // TwoCarComparer_Disclaimer
            // 
            this.TwoCarComparer_Disclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.TwoCarComparer_Disclaimer.Location = new System.Drawing.Point(112, 7);
            this.TwoCarComparer_Disclaimer.Name = "TwoCarComparer_Disclaimer";
            this.TwoCarComparer_Disclaimer.Size = new System.Drawing.Size(847, 20);
            this.TwoCarComparer_Disclaimer.TabIndex = 0;
            this.TwoCarComparer_Disclaimer.Text = "Note: The times displayed for each track are relative to the first car selected, " +
    "meaning that if you see negative values Car 1 is faster and if you see positive " +
    "values Car 2 is faster.";
            // 
            // commonTrackLapTimesBindingSource
            // 
            this.commonTrackLapTimesBindingSource.DataMember = "CommonTrackLapTimes";
            this.commonTrackLapTimesBindingSource.DataSource = this.twoCarComparissonBindingSource;
            // 
            // twoCarComparissonBindingSource
            // 
            this.twoCarComparissonBindingSource.DataSource = typeof(Assetto_Corsa_CarTimesApp.LogicClasses.ComparrisonTypes.TwoCarComparisson);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.TwoCarComparison_Panel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.Text = "Assetto Corsa Car Performance App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TwoCarComparison_Panel.ResumeLayout(false);
            this.TwoCarComparison_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonTrackLapTimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoCarComparissonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel TwoCarComparison_Panel;
        private System.Windows.Forms.TextBox TwoCarComparer_Disclaimer;
        private System.Windows.Forms.BindingSource twoCarComparissonBindingSource;
        private System.Windows.Forms.TextBox ResultsOverview_Textbox;
        private System.Windows.Forms.TextBox CarTwoName_Textbox;
        private System.Windows.Forms.TextBox CarOneName_Textbox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.BindingSource commonTrackLapTimesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

