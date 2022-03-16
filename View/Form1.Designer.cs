namespace View
{
    using CelestialsLib;
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private SolarSystem solarSystem;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Tuple<int, int> center;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.ObjectName = new System.Windows.Forms.Label();
            this.ObjectOrbits = new System.Windows.Forms.Label();
            this.ObjectRadius = new System.Windows.Forms.Label();
            this.OrbitalRadius = new System.Windows.Forms.Label();
            this.OrbitalPeriod = new System.Windows.Forms.Label();
            this.RotationalPeriod = new System.Windows.Forms.Label();
            this.ObjectMoons = new System.Windows.Forms.Label();
            this.TickRate = new System.Windows.Forms.Label();
            this.ElapsedTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(12, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Labels";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(12, 79);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 19);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Orbits";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(12, 100);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(120, 19);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Enable simulation";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // ObjectName
            // 
            this.ObjectName.AutoSize = true;
            this.ObjectName.BackColor = System.Drawing.Color.Transparent;
            this.ObjectName.Location = new System.Drawing.Point(1421, 12);
            this.ObjectName.Name = "ObjectName";
            this.ObjectName.Size = new System.Drawing.Size(13, 15);
            this.ObjectName.TabIndex = 5;
            this.ObjectName.Text = "T";
            // 
            // ObjectOrbits
            // 
            this.ObjectOrbits.AutoSize = true;
            this.ObjectOrbits.BackColor = System.Drawing.Color.Transparent;
            this.ObjectOrbits.Location = new System.Drawing.Point(1421, 35);
            this.ObjectOrbits.Name = "ObjectOrbits";
            this.ObjectOrbits.Size = new System.Drawing.Size(13, 15);
            this.ObjectOrbits.TabIndex = 6;
            this.ObjectOrbits.Text = "T";
            // 
            // ObjectRadius
            // 
            this.ObjectRadius.AutoSize = true;
            this.ObjectRadius.BackColor = System.Drawing.Color.Transparent;
            this.ObjectRadius.Location = new System.Drawing.Point(1421, 56);
            this.ObjectRadius.Name = "ObjectRadius";
            this.ObjectRadius.Size = new System.Drawing.Size(13, 15);
            this.ObjectRadius.TabIndex = 7;
            this.ObjectRadius.Text = "T";
            // 
            // OrbitalRadius
            // 
            this.OrbitalRadius.AutoSize = true;
            this.OrbitalRadius.BackColor = System.Drawing.Color.Transparent;
            this.OrbitalRadius.Location = new System.Drawing.Point(1421, 80);
            this.OrbitalRadius.Name = "OrbitalRadius";
            this.OrbitalRadius.Size = new System.Drawing.Size(13, 15);
            this.OrbitalRadius.TabIndex = 8;
            this.OrbitalRadius.Text = "T";
            // 
            // OrbitalPeriod
            // 
            this.OrbitalPeriod.AutoSize = true;
            this.OrbitalPeriod.BackColor = System.Drawing.Color.Transparent;
            this.OrbitalPeriod.Location = new System.Drawing.Point(1421, 105);
            this.OrbitalPeriod.Name = "OrbitalPeriod";
            this.OrbitalPeriod.Size = new System.Drawing.Size(13, 15);
            this.OrbitalPeriod.TabIndex = 9;
            this.OrbitalPeriod.Text = "T";
            // 
            // RotationalPeriod
            // 
            this.RotationalPeriod.AutoSize = true;
            this.RotationalPeriod.BackColor = System.Drawing.Color.Transparent;
            this.RotationalPeriod.Location = new System.Drawing.Point(1421, 131);
            this.RotationalPeriod.Name = "RotationalPeriod";
            this.RotationalPeriod.Size = new System.Drawing.Size(13, 15);
            this.RotationalPeriod.TabIndex = 10;
            this.RotationalPeriod.Text = "T";
            // 
            // ObjectMoons
            // 
            this.ObjectMoons.AutoSize = true;
            this.ObjectMoons.BackColor = System.Drawing.Color.Transparent;
            this.ObjectMoons.Location = new System.Drawing.Point(1421, 157);
            this.ObjectMoons.Name = "ObjectMoons";
            this.ObjectMoons.Size = new System.Drawing.Size(13, 15);
            this.ObjectMoons.TabIndex = 11;
            this.ObjectMoons.Text = "T";
            // 
            // TickRate
            // 
            this.TickRate.AutoSize = true;
            this.TickRate.BackColor = System.Drawing.Color.Transparent;
            this.TickRate.Location = new System.Drawing.Point(12, 9);
            this.TickRate.Name = "TickRate";
            this.TickRate.Size = new System.Drawing.Size(13, 15);
            this.TickRate.TabIndex = 12;
            this.TickRate.Text = "T";
            // 
            // ElapsedTime
            // 
            this.ElapsedTime.AutoSize = true;
            this.ElapsedTime.BackColor = System.Drawing.Color.Transparent;
            this.ElapsedTime.Location = new System.Drawing.Point(12, 34);
            this.ElapsedTime.Name = "ElapsedTime";
            this.ElapsedTime.Size = new System.Drawing.Size(13, 15);
            this.ElapsedTime.TabIndex = 13;
            this.ElapsedTime.Text = "T";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.ElapsedTime);
            this.Controls.Add(this.TickRate);
            this.Controls.Add(this.ObjectMoons);
            this.Controls.Add(this.RotationalPeriod);
            this.Controls.Add(this.OrbitalPeriod);
            this.Controls.Add(this.OrbitalRadius);
            this.Controls.Add(this.ObjectRadius);
            this.Controls.Add(this.ObjectOrbits);
            this.Controls.Add(this.ObjectName);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Solar System Explorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ObjectName;
        private Label ObjectOrbits;
        private Label ObjectRadius;
        private Label OrbitalRadius;
        private Label OrbitalPeriod;
        private Label RotationalPeriod;
        private Label ObjectMoons;
        private Label TickRate;
        private Label ElapsedTime;
    }            
}