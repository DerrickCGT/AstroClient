namespace AstroClient
{
    partial class AstroForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEnglishUK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFrench = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBackgroundMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemColour = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxStarVelocity = new System.Windows.Forms.GroupBox();
            this.labelObservedWavelength = new System.Windows.Forms.Label();
            this.labelNM1 = new System.Windows.Forms.Label();
            this.textBoxObservedWavelength = new System.Windows.Forms.TextBox();
            this.labelNM2 = new System.Windows.Forms.Label();
            this.textBoxRestWavelength = new System.Windows.Forms.TextBox();
            this.labelRestWavelength = new System.Windows.Forms.Label();
            this.groupBoxStarDistance = new System.Windows.Forms.GroupBox();
            this.labelParallaxAngle = new System.Windows.Forms.Label();
            this.labelArcSeconds = new System.Windows.Forms.Label();
            this.textBoxParallaxAngle = new System.Windows.Forms.TextBox();
            this.groupBoxCelcius = new System.Windows.Forms.GroupBox();
            this.labelCelcius = new System.Windows.Forms.Label();
            this.labelSymbolCelcius = new System.Windows.Forms.Label();
            this.textBoxCelcius = new System.Windows.Forms.TextBox();
            this.groupBoxEventHorizon = new System.Windows.Forms.GroupBox();
            this.labelKilogram = new System.Windows.Forms.Label();
            this.textBoxMassExponent = new System.Windows.Forms.TextBox();
            this.labelMassOfStar = new System.Windows.Forms.Label();
            this.labelExponent = new System.Windows.Forms.Label();
            this.textBoxMassOfStar = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderStarNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStarVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStarDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTemperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCalculation = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxStarVelocity.SuspendLayout();
            this.groupBoxStarDistance.SuspendLayout();
            this.groupBoxCelcius.SuspendLayout();
            this.groupBoxEventHorizon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLanguage,
            this.toolStripMenuItemTheme});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(992, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemLanguage
            // 
            this.toolStripMenuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEnglishUK,
            this.toolStripMenuItemFrench,
            this.toolStripMenuItemGerman});
            this.toolStripMenuItemLanguage.Name = "toolStripMenuItemLanguage";
            this.toolStripMenuItemLanguage.Size = new System.Drawing.Size(88, 24);
            this.toolStripMenuItemLanguage.Text = "Language";
            // 
            // toolStripMenuItemEnglishUK
            // 
            this.toolStripMenuItemEnglishUK.Name = "toolStripMenuItemEnglishUK";
            this.toolStripMenuItemEnglishUK.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemEnglishUK.Text = "English UK";
            this.toolStripMenuItemEnglishUK.Click += new System.EventHandler(this.toolStripMenuItemEnglishUK_Click);
            // 
            // toolStripMenuItemFrench
            // 
            this.toolStripMenuItemFrench.Name = "toolStripMenuItemFrench";
            this.toolStripMenuItemFrench.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemFrench.Text = "Français";
            this.toolStripMenuItemFrench.Click += new System.EventHandler(this.toolStripMenuItemFrench_Click);
            // 
            // toolStripMenuItemGerman
            // 
            this.toolStripMenuItemGerman.Name = "toolStripMenuItemGerman";
            this.toolStripMenuItemGerman.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemGerman.Text = "Deutsch";
            this.toolStripMenuItemGerman.Click += new System.EventHandler(this.toolStripMenuItemGerman_Click);
            // 
            // toolStripMenuItemTheme
            // 
            this.toolStripMenuItemTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBackgroundMode,
            this.toolStripMenuItemColour});
            this.toolStripMenuItemTheme.Name = "toolStripMenuItemTheme";
            this.toolStripMenuItemTheme.Size = new System.Drawing.Size(68, 24);
            this.toolStripMenuItemTheme.Text = "Theme";
            // 
            // toolStripMenuItemBackgroundMode
            // 
            this.toolStripMenuItemBackgroundMode.Name = "toolStripMenuItemBackgroundMode";
            this.toolStripMenuItemBackgroundMode.Size = new System.Drawing.Size(211, 26);
            this.toolStripMenuItemBackgroundMode.Text = "Light/Dark Theme";
            // 
            // toolStripMenuItemColour
            // 
            this.toolStripMenuItemColour.Name = "toolStripMenuItemColour";
            this.toolStripMenuItemColour.Size = new System.Drawing.Size(211, 26);
            this.toolStripMenuItemColour.Text = "Select Colour";
            // 
            // groupBoxStarVelocity
            // 
            this.groupBoxStarVelocity.Controls.Add(this.labelObservedWavelength);
            this.groupBoxStarVelocity.Controls.Add(this.labelNM1);
            this.groupBoxStarVelocity.Controls.Add(this.textBoxObservedWavelength);
            this.groupBoxStarVelocity.Controls.Add(this.labelNM2);
            this.groupBoxStarVelocity.Controls.Add(this.textBoxRestWavelength);
            this.groupBoxStarVelocity.Controls.Add(this.labelRestWavelength);
            this.groupBoxStarVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStarVelocity.Location = new System.Drawing.Point(16, 33);
            this.groupBoxStarVelocity.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStarVelocity.Name = "groupBoxStarVelocity";
            this.groupBoxStarVelocity.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStarVelocity.Size = new System.Drawing.Size(180, 129);
            this.groupBoxStarVelocity.TabIndex = 1;
            this.groupBoxStarVelocity.TabStop = false;
            this.groupBoxStarVelocity.Text = "Star Velocity";
            // 
            // labelObservedWavelength
            // 
            this.labelObservedWavelength.AutoSize = true;
            this.labelObservedWavelength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.labelObservedWavelength.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelObservedWavelength.Location = new System.Drawing.Point(7, 20);
            this.labelObservedWavelength.Name = "labelObservedWavelength";
            this.labelObservedWavelength.Size = new System.Drawing.Size(149, 17);
            this.labelObservedWavelength.TabIndex = 8;
            this.labelObservedWavelength.Text = "Observed Wavelength";
            // 
            // labelNM1
            // 
            this.labelNM1.AutoSize = true;
            this.labelNM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.labelNM1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNM1.Location = new System.Drawing.Point(85, 42);
            this.labelNM1.Name = "labelNM1";
            this.labelNM1.Size = new System.Drawing.Size(27, 17);
            this.labelNM1.TabIndex = 9;
            this.labelNM1.Text = "nm";
            // 
            // textBoxObservedWavelength
            // 
            this.textBoxObservedWavelength.Location = new System.Drawing.Point(11, 38);
            this.textBoxObservedWavelength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxObservedWavelength.Name = "textBoxObservedWavelength";
            this.textBoxObservedWavelength.Size = new System.Drawing.Size(68, 23);
            this.textBoxObservedWavelength.TabIndex = 6;
            this.textBoxObservedWavelength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxObservedWavelength_KeyPress);
            // 
            // labelNM2
            // 
            this.labelNM2.AutoSize = true;
            this.labelNM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.labelNM2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNM2.Location = new System.Drawing.Point(85, 100);
            this.labelNM2.Name = "labelNM2";
            this.labelNM2.Size = new System.Drawing.Size(27, 17);
            this.labelNM2.TabIndex = 10;
            this.labelNM2.Text = "nm";
            // 
            // textBoxRestWavelength
            // 
            this.textBoxRestWavelength.Location = new System.Drawing.Point(11, 96);
            this.textBoxRestWavelength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRestWavelength.Name = "textBoxRestWavelength";
            this.textBoxRestWavelength.Size = new System.Drawing.Size(68, 23);
            this.textBoxRestWavelength.TabIndex = 7;
            this.textBoxRestWavelength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRestWavelength_KeyPress);
            // 
            // labelRestWavelength
            // 
            this.labelRestWavelength.AutoSize = true;
            this.labelRestWavelength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.labelRestWavelength.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRestWavelength.Location = new System.Drawing.Point(7, 78);
            this.labelRestWavelength.Name = "labelRestWavelength";
            this.labelRestWavelength.Size = new System.Drawing.Size(116, 17);
            this.labelRestWavelength.TabIndex = 11;
            this.labelRestWavelength.Text = "Rest Wavelength";
            // 
            // groupBoxStarDistance
            // 
            this.groupBoxStarDistance.Controls.Add(this.labelParallaxAngle);
            this.groupBoxStarDistance.Controls.Add(this.labelArcSeconds);
            this.groupBoxStarDistance.Controls.Add(this.textBoxParallaxAngle);
            this.groupBoxStarDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStarDistance.Location = new System.Drawing.Point(16, 170);
            this.groupBoxStarDistance.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStarDistance.Name = "groupBoxStarDistance";
            this.groupBoxStarDistance.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStarDistance.Size = new System.Drawing.Size(180, 110);
            this.groupBoxStarDistance.TabIndex = 2;
            this.groupBoxStarDistance.TabStop = false;
            this.groupBoxStarDistance.Text = "Star Distance";
            // 
            // labelParallaxAngle
            // 
            this.labelParallaxAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.labelParallaxAngle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelParallaxAngle.Location = new System.Drawing.Point(7, 20);
            this.labelParallaxAngle.Name = "labelParallaxAngle";
            this.labelParallaxAngle.Size = new System.Drawing.Size(152, 38);
            this.labelParallaxAngle.TabIndex = 8;
            this.labelParallaxAngle.Text = "Parallax Angle in Arch Seconds";
            // 
            // labelArcSeconds
            // 
            this.labelArcSeconds.AutoSize = true;
            this.labelArcSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.labelArcSeconds.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelArcSeconds.Location = new System.Drawing.Point(85, 64);
            this.labelArcSeconds.Name = "labelArcSeconds";
            this.labelArcSeconds.Size = new System.Drawing.Size(13, 17);
            this.labelArcSeconds.TabIndex = 9;
            this.labelArcSeconds.Text = "\"";
            // 
            // textBoxParallaxAngle
            // 
            this.textBoxParallaxAngle.Location = new System.Drawing.Point(11, 60);
            this.textBoxParallaxAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxParallaxAngle.Name = "textBoxParallaxAngle";
            this.textBoxParallaxAngle.Size = new System.Drawing.Size(68, 23);
            this.textBoxParallaxAngle.TabIndex = 6;
            this.textBoxParallaxAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxParallaxAngle_KeyPress);
            // 
            // groupBoxCelcius
            // 
            this.groupBoxCelcius.Controls.Add(this.labelCelcius);
            this.groupBoxCelcius.Controls.Add(this.labelSymbolCelcius);
            this.groupBoxCelcius.Controls.Add(this.textBoxCelcius);
            this.groupBoxCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCelcius.Location = new System.Drawing.Point(16, 287);
            this.groupBoxCelcius.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCelcius.Name = "groupBoxCelcius";
            this.groupBoxCelcius.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCelcius.Size = new System.Drawing.Size(180, 129);
            this.groupBoxCelcius.TabIndex = 3;
            this.groupBoxCelcius.TabStop = false;
            this.groupBoxCelcius.Text = "Tempearture Conversion (Kelvin)";
            // 
            // labelCelcius
            // 
            this.labelCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.labelCelcius.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCelcius.Location = new System.Drawing.Point(7, 37);
            this.labelCelcius.Name = "labelCelcius";
            this.labelCelcius.Size = new System.Drawing.Size(152, 38);
            this.labelCelcius.TabIndex = 8;
            this.labelCelcius.Text = "Initial temperature in Celcius";
            // 
            // labelSymbolCelcius
            // 
            this.labelSymbolCelcius.AutoSize = true;
            this.labelSymbolCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.labelSymbolCelcius.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSymbolCelcius.Location = new System.Drawing.Point(85, 81);
            this.labelSymbolCelcius.Name = "labelSymbolCelcius";
            this.labelSymbolCelcius.Size = new System.Drawing.Size(23, 17);
            this.labelSymbolCelcius.TabIndex = 9;
            this.labelSymbolCelcius.Text = "°C";
            // 
            // textBoxCelcius
            // 
            this.textBoxCelcius.Location = new System.Drawing.Point(11, 78);
            this.textBoxCelcius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCelcius.Name = "textBoxCelcius";
            this.textBoxCelcius.Size = new System.Drawing.Size(68, 23);
            this.textBoxCelcius.TabIndex = 6;
            this.textBoxCelcius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCelcius_KeyPress);
            // 
            // groupBoxEventHorizon
            // 
            this.groupBoxEventHorizon.Controls.Add(this.labelKilogram);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxMassExponent);
            this.groupBoxEventHorizon.Controls.Add(this.labelMassOfStar);
            this.groupBoxEventHorizon.Controls.Add(this.labelExponent);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxMassOfStar);
            this.groupBoxEventHorizon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEventHorizon.Location = new System.Drawing.Point(16, 423);
            this.groupBoxEventHorizon.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEventHorizon.Name = "groupBoxEventHorizon";
            this.groupBoxEventHorizon.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEventHorizon.Size = new System.Drawing.Size(180, 129);
            this.groupBoxEventHorizon.TabIndex = 10;
            this.groupBoxEventHorizon.TabStop = false;
            this.groupBoxEventHorizon.Text = "Event Horizon";
            // 
            // labelKilogram
            // 
            this.labelKilogram.AutoSize = true;
            this.labelKilogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.labelKilogram.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKilogram.Location = new System.Drawing.Point(148, 65);
            this.labelKilogram.Name = "labelKilogram";
            this.labelKilogram.Size = new System.Drawing.Size(23, 17);
            this.labelKilogram.TabIndex = 11;
            this.labelKilogram.Text = "kg";
            // 
            // textBoxMassExponent
            // 
            this.textBoxMassExponent.Location = new System.Drawing.Point(111, 60);
            this.textBoxMassExponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMassExponent.Name = "textBoxMassExponent";
            this.textBoxMassExponent.Size = new System.Drawing.Size(33, 23);
            this.textBoxMassExponent.TabIndex = 10;
            this.textBoxMassExponent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMassExponent_KeyPress);
            // 
            // labelMassOfStar
            // 
            this.labelMassOfStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.labelMassOfStar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMassOfStar.Location = new System.Drawing.Point(7, 20);
            this.labelMassOfStar.Name = "labelMassOfStar";
            this.labelMassOfStar.Size = new System.Drawing.Size(152, 38);
            this.labelMassOfStar.TabIndex = 8;
            this.labelMassOfStar.Text = "Mass of Star in Kg";
            // 
            // labelExponent
            // 
            this.labelExponent.AutoSize = true;
            this.labelExponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.labelExponent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelExponent.Location = new System.Drawing.Point(65, 65);
            this.labelExponent.Name = "labelExponent";
            this.labelExponent.Size = new System.Drawing.Size(37, 17);
            this.labelExponent.TabIndex = 9;
            this.labelExponent.Text = "x10^";
            // 
            // textBoxMassOfStar
            // 
            this.textBoxMassOfStar.Location = new System.Drawing.Point(11, 60);
            this.textBoxMassOfStar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMassOfStar.Name = "textBoxMassOfStar";
            this.textBoxMassOfStar.Size = new System.Drawing.Size(48, 23);
            this.textBoxMassOfStar.TabIndex = 6;
            this.textBoxMassOfStar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMassOfStar_KeyPress);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderStarNo,
            this.columnHeaderStarVelocity,
            this.columnHeaderStarDistance,
            this.columnHeaderTemperature,
            this.columnHeaderEventHorizon});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(213, 33);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(764, 565);
            this.listView.TabIndex = 11;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderStarNo
            // 
            this.columnHeaderStarNo.Text = "Star No.";
            this.columnHeaderStarNo.Width = 61;
            // 
            // columnHeaderStarVelocity
            // 
            this.columnHeaderStarVelocity.Text = "Star Velocity";
            this.columnHeaderStarVelocity.Width = 130;
            // 
            // columnHeaderStarDistance
            // 
            this.columnHeaderStarDistance.Text = "Star Distance";
            this.columnHeaderStarDistance.Width = 129;
            // 
            // columnHeaderTemperature
            // 
            this.columnHeaderTemperature.Text = "Temperature (°K)";
            this.columnHeaderTemperature.Width = 104;
            // 
            // columnHeaderEventHorizon
            // 
            this.columnHeaderEventHorizon.Text = " Schwarzschild Radius ";
            this.columnHeaderEventHorizon.Width = 144;
            // 
            // buttonCalculation
            // 
            this.buttonCalculation.Location = new System.Drawing.Point(13, 560);
            this.buttonCalculation.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculation.Name = "buttonCalculation";
            this.buttonCalculation.Size = new System.Drawing.Size(183, 38);
            this.buttonCalculation.TabIndex = 12;
            this.buttonCalculation.Text = "Calculate";
            this.buttonCalculation.UseVisualStyleBackColor = true;
            this.buttonCalculation.Click += new System.EventHandler(this.buttonCalculation_Click);
            // 
            // AstroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 612);
            this.Controls.Add(this.buttonCalculation);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBoxEventHorizon);
            this.Controls.Add(this.groupBoxCelcius);
            this.Controls.Add(this.groupBoxStarDistance);
            this.Controls.Add(this.groupBoxStarVelocity);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AstroForm";
            this.Text = "Astronomical Processing App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxStarVelocity.ResumeLayout(false);
            this.groupBoxStarVelocity.PerformLayout();
            this.groupBoxStarDistance.ResumeLayout(false);
            this.groupBoxStarDistance.PerformLayout();
            this.groupBoxCelcius.ResumeLayout(false);
            this.groupBoxCelcius.PerformLayout();
            this.groupBoxEventHorizon.ResumeLayout(false);
            this.groupBoxEventHorizon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLanguage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEnglishUK;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFrench;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGerman;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTheme;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBackgroundMode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemColour;
        private System.Windows.Forms.GroupBox groupBoxStarVelocity;
        private System.Windows.Forms.Label labelObservedWavelength;
        private System.Windows.Forms.Label labelNM1;
        private System.Windows.Forms.TextBox textBoxObservedWavelength;
        private System.Windows.Forms.Label labelNM2;
        private System.Windows.Forms.TextBox textBoxRestWavelength;
        private System.Windows.Forms.Label labelRestWavelength;
        private System.Windows.Forms.GroupBox groupBoxStarDistance;
        private System.Windows.Forms.Label labelParallaxAngle;
        private System.Windows.Forms.Label labelArcSeconds;
        private System.Windows.Forms.TextBox textBoxParallaxAngle;
        private System.Windows.Forms.GroupBox groupBoxCelcius;
        private System.Windows.Forms.Label labelCelcius;
        private System.Windows.Forms.Label labelSymbolCelcius;
        private System.Windows.Forms.TextBox textBoxCelcius;
        private System.Windows.Forms.GroupBox groupBoxEventHorizon;
        private System.Windows.Forms.Label labelMassOfStar;
        private System.Windows.Forms.Label labelExponent;
        private System.Windows.Forms.TextBox textBoxMassOfStar;
        private System.Windows.Forms.TextBox textBoxMassExponent;
        private System.Windows.Forms.Label labelKilogram;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeaderStarNo;
        private System.Windows.Forms.ColumnHeader columnHeaderStarVelocity;
        private System.Windows.Forms.ColumnHeader columnHeaderStarDistance;
        private System.Windows.Forms.ColumnHeader columnHeaderTemperature;
        private System.Windows.Forms.ColumnHeader columnHeaderEventHorizon;
        private System.Windows.Forms.Button buttonCalculation;
    }
}

