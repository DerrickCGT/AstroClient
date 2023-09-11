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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstroForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEnglishUK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFrench = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBackgroundMode = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonLanguageGerman = new System.Windows.Forms.Button();
            this.buttonLanguageFrench = new System.Windows.Forms.Button();
            this.buttonLanguageEnglish = new System.Windows.Forms.Button();
            this.groupBoxLanguage = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCustomizeMode = new System.Windows.Forms.Button();
            this.buttonDarkMode = new System.Windows.Forms.Button();
            this.buttonLightMode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxStarVelocity.SuspendLayout();
            this.groupBoxStarDistance.SuspendLayout();
            this.groupBoxCelcius.SuspendLayout();
            this.groupBoxEventHorizon.SuspendLayout();
            this.groupBoxLanguage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLanguage,
            this.toolStripMenuItemTheme});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItemLanguage
            // 
            this.toolStripMenuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEnglishUK,
            this.toolStripMenuItemFrench,
            this.toolStripMenuItemGerman});
            this.toolStripMenuItemLanguage.Name = "toolStripMenuItemLanguage";
            resources.ApplyResources(this.toolStripMenuItemLanguage, "toolStripMenuItemLanguage");
            // 
            // toolStripMenuItemEnglishUK
            // 
            resources.ApplyResources(this.toolStripMenuItemEnglishUK, "toolStripMenuItemEnglishUK");
            this.toolStripMenuItemEnglishUK.Name = "toolStripMenuItemEnglishUK";
            this.toolStripMenuItemEnglishUK.Click += new System.EventHandler(this.toolStripMenuItemEnglishUK_Click);
            // 
            // toolStripMenuItemFrench
            // 
            resources.ApplyResources(this.toolStripMenuItemFrench, "toolStripMenuItemFrench");
            this.toolStripMenuItemFrench.Name = "toolStripMenuItemFrench";
            this.toolStripMenuItemFrench.Click += new System.EventHandler(this.toolStripMenuItemFrench_Click);
            // 
            // toolStripMenuItemGerman
            // 
            resources.ApplyResources(this.toolStripMenuItemGerman, "toolStripMenuItemGerman");
            this.toolStripMenuItemGerman.Name = "toolStripMenuItemGerman";
            this.toolStripMenuItemGerman.Click += new System.EventHandler(this.toolStripMenuItemGerman_Click);
            // 
            // toolStripMenuItemTheme
            // 
            this.toolStripMenuItemTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBackgroundMode,
            this.toolStripMenuItemColour});
            this.toolStripMenuItemTheme.Name = "toolStripMenuItemTheme";
            resources.ApplyResources(this.toolStripMenuItemTheme, "toolStripMenuItemTheme");
            // 
            // toolStripMenuItemBackgroundMode
            // 
            this.toolStripMenuItemBackgroundMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightModeToolStripMenuItem,
            this.darkModeToolStripMenuItem});
            this.toolStripMenuItemBackgroundMode.Name = "toolStripMenuItemBackgroundMode";
            resources.ApplyResources(this.toolStripMenuItemBackgroundMode, "toolStripMenuItemBackgroundMode");
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            resources.ApplyResources(this.lightModeToolStripMenuItem, "lightModeToolStripMenuItem");
            this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            resources.ApplyResources(this.darkModeToolStripMenuItem, "darkModeToolStripMenuItem");
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // toolStripMenuItemColour
            // 
            this.toolStripMenuItemColour.Name = "toolStripMenuItemColour";
            resources.ApplyResources(this.toolStripMenuItemColour, "toolStripMenuItemColour");
            this.toolStripMenuItemColour.Click += new System.EventHandler(this.toolStripMenuItemColour_Click);
            // 
            // groupBoxStarVelocity
            // 
            this.groupBoxStarVelocity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxStarVelocity.Controls.Add(this.labelObservedWavelength);
            this.groupBoxStarVelocity.Controls.Add(this.labelNM1);
            this.groupBoxStarVelocity.Controls.Add(this.textBoxObservedWavelength);
            this.groupBoxStarVelocity.Controls.Add(this.labelNM2);
            this.groupBoxStarVelocity.Controls.Add(this.textBoxRestWavelength);
            this.groupBoxStarVelocity.Controls.Add(this.labelRestWavelength);
            resources.ApplyResources(this.groupBoxStarVelocity, "groupBoxStarVelocity");
            this.groupBoxStarVelocity.Name = "groupBoxStarVelocity";
            this.groupBoxStarVelocity.TabStop = false;
            // 
            // labelObservedWavelength
            // 
            resources.ApplyResources(this.labelObservedWavelength, "labelObservedWavelength");
            this.labelObservedWavelength.Name = "labelObservedWavelength";
            // 
            // labelNM1
            // 
            resources.ApplyResources(this.labelNM1, "labelNM1");
            this.labelNM1.Name = "labelNM1";
            // 
            // textBoxObservedWavelength
            // 
            resources.ApplyResources(this.textBoxObservedWavelength, "textBoxObservedWavelength");
            this.textBoxObservedWavelength.Name = "textBoxObservedWavelength";
            this.toolTip1.SetToolTip(this.textBoxObservedWavelength, resources.GetString("textBoxObservedWavelength.ToolTip"));
            this.textBoxObservedWavelength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxObservedWavelength_KeyPress);
            // 
            // labelNM2
            // 
            resources.ApplyResources(this.labelNM2, "labelNM2");
            this.labelNM2.Name = "labelNM2";
            // 
            // textBoxRestWavelength
            // 
            resources.ApplyResources(this.textBoxRestWavelength, "textBoxRestWavelength");
            this.textBoxRestWavelength.Name = "textBoxRestWavelength";
            this.toolTip1.SetToolTip(this.textBoxRestWavelength, resources.GetString("textBoxRestWavelength.ToolTip"));
            this.textBoxRestWavelength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRestWavelength_KeyPress);
            // 
            // labelRestWavelength
            // 
            resources.ApplyResources(this.labelRestWavelength, "labelRestWavelength");
            this.labelRestWavelength.Name = "labelRestWavelength";
            // 
            // groupBoxStarDistance
            // 
            this.groupBoxStarDistance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxStarDistance.Controls.Add(this.labelParallaxAngle);
            this.groupBoxStarDistance.Controls.Add(this.labelArcSeconds);
            this.groupBoxStarDistance.Controls.Add(this.textBoxParallaxAngle);
            resources.ApplyResources(this.groupBoxStarDistance, "groupBoxStarDistance");
            this.groupBoxStarDistance.Name = "groupBoxStarDistance";
            this.groupBoxStarDistance.TabStop = false;
            // 
            // labelParallaxAngle
            // 
            resources.ApplyResources(this.labelParallaxAngle, "labelParallaxAngle");
            this.labelParallaxAngle.Name = "labelParallaxAngle";
            // 
            // labelArcSeconds
            // 
            resources.ApplyResources(this.labelArcSeconds, "labelArcSeconds");
            this.labelArcSeconds.Name = "labelArcSeconds";
            // 
            // textBoxParallaxAngle
            // 
            resources.ApplyResources(this.textBoxParallaxAngle, "textBoxParallaxAngle");
            this.textBoxParallaxAngle.Name = "textBoxParallaxAngle";
            this.toolTip1.SetToolTip(this.textBoxParallaxAngle, resources.GetString("textBoxParallaxAngle.ToolTip"));
            this.textBoxParallaxAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxParallaxAngle_KeyPress);
            // 
            // groupBoxCelcius
            // 
            this.groupBoxCelcius.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxCelcius.Controls.Add(this.labelCelcius);
            this.groupBoxCelcius.Controls.Add(this.labelSymbolCelcius);
            this.groupBoxCelcius.Controls.Add(this.textBoxCelcius);
            resources.ApplyResources(this.groupBoxCelcius, "groupBoxCelcius");
            this.groupBoxCelcius.Name = "groupBoxCelcius";
            this.groupBoxCelcius.TabStop = false;
            // 
            // labelCelcius
            // 
            resources.ApplyResources(this.labelCelcius, "labelCelcius");
            this.labelCelcius.Name = "labelCelcius";
            // 
            // labelSymbolCelcius
            // 
            resources.ApplyResources(this.labelSymbolCelcius, "labelSymbolCelcius");
            this.labelSymbolCelcius.Name = "labelSymbolCelcius";
            // 
            // textBoxCelcius
            // 
            resources.ApplyResources(this.textBoxCelcius, "textBoxCelcius");
            this.textBoxCelcius.Name = "textBoxCelcius";
            this.toolTip1.SetToolTip(this.textBoxCelcius, resources.GetString("textBoxCelcius.ToolTip"));
            this.textBoxCelcius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCelcius_KeyPress);
            // 
            // groupBoxEventHorizon
            // 
            this.groupBoxEventHorizon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxEventHorizon.Controls.Add(this.labelKilogram);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxMassExponent);
            this.groupBoxEventHorizon.Controls.Add(this.labelMassOfStar);
            this.groupBoxEventHorizon.Controls.Add(this.labelExponent);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxMassOfStar);
            resources.ApplyResources(this.groupBoxEventHorizon, "groupBoxEventHorizon");
            this.groupBoxEventHorizon.Name = "groupBoxEventHorizon";
            this.groupBoxEventHorizon.TabStop = false;
            // 
            // labelKilogram
            // 
            resources.ApplyResources(this.labelKilogram, "labelKilogram");
            this.labelKilogram.Name = "labelKilogram";
            // 
            // textBoxMassExponent
            // 
            resources.ApplyResources(this.textBoxMassExponent, "textBoxMassExponent");
            this.textBoxMassExponent.Name = "textBoxMassExponent";
            this.toolTip1.SetToolTip(this.textBoxMassExponent, resources.GetString("textBoxMassExponent.ToolTip"));
            this.textBoxMassExponent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMassExponent_KeyPress);
            // 
            // labelMassOfStar
            // 
            resources.ApplyResources(this.labelMassOfStar, "labelMassOfStar");
            this.labelMassOfStar.Name = "labelMassOfStar";
            // 
            // labelExponent
            // 
            resources.ApplyResources(this.labelExponent, "labelExponent");
            this.labelExponent.Name = "labelExponent";
            // 
            // textBoxMassOfStar
            // 
            resources.ApplyResources(this.textBoxMassOfStar, "textBoxMassOfStar");
            this.textBoxMassOfStar.Name = "textBoxMassOfStar";
            this.toolTip1.SetToolTip(this.textBoxMassOfStar, resources.GetString("textBoxMassOfStar.ToolTip"));
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
            resources.ApplyResources(this.listView, "listView");
            this.listView.Name = "listView";
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderStarNo
            // 
            resources.ApplyResources(this.columnHeaderStarNo, "columnHeaderStarNo");
            // 
            // columnHeaderStarVelocity
            // 
            resources.ApplyResources(this.columnHeaderStarVelocity, "columnHeaderStarVelocity");
            // 
            // columnHeaderStarDistance
            // 
            resources.ApplyResources(this.columnHeaderStarDistance, "columnHeaderStarDistance");
            // 
            // columnHeaderTemperature
            // 
            resources.ApplyResources(this.columnHeaderTemperature, "columnHeaderTemperature");
            // 
            // columnHeaderEventHorizon
            // 
            resources.ApplyResources(this.columnHeaderEventHorizon, "columnHeaderEventHorizon");
            // 
            // buttonCalculation
            // 
            this.buttonCalculation.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.buttonCalculation, "buttonCalculation");
            this.buttonCalculation.Name = "buttonCalculation";
            this.buttonCalculation.UseVisualStyleBackColor = false;
            this.buttonCalculation.Click += new System.EventHandler(this.buttonCalculation_Click);
            // 
            // buttonLanguageGerman
            // 
            resources.ApplyResources(this.buttonLanguageGerman, "buttonLanguageGerman");
            this.buttonLanguageGerman.Name = "buttonLanguageGerman";
            this.buttonLanguageGerman.UseVisualStyleBackColor = true;
            this.buttonLanguageGerman.Click += new System.EventHandler(this.buttonLanguageGerman_Click);
            // 
            // buttonLanguageFrench
            // 
            resources.ApplyResources(this.buttonLanguageFrench, "buttonLanguageFrench");
            this.buttonLanguageFrench.Name = "buttonLanguageFrench";
            this.buttonLanguageFrench.UseVisualStyleBackColor = true;
            this.buttonLanguageFrench.Click += new System.EventHandler(this.buttonLanguageFrench_Click);
            // 
            // buttonLanguageEnglish
            // 
            resources.ApplyResources(this.buttonLanguageEnglish, "buttonLanguageEnglish");
            this.buttonLanguageEnglish.Name = "buttonLanguageEnglish";
            this.buttonLanguageEnglish.UseVisualStyleBackColor = true;
            this.buttonLanguageEnglish.Click += new System.EventHandler(this.buttonLanguageEnglish_Click);
            // 
            // groupBoxLanguage
            // 
            this.groupBoxLanguage.Controls.Add(this.buttonLanguageEnglish);
            this.groupBoxLanguage.Controls.Add(this.buttonLanguageGerman);
            this.groupBoxLanguage.Controls.Add(this.buttonLanguageFrench);
            resources.ApplyResources(this.groupBoxLanguage, "groupBoxLanguage");
            this.groupBoxLanguage.Name = "groupBoxLanguage";
            this.groupBoxLanguage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCustomizeMode);
            this.groupBox1.Controls.Add(this.buttonDarkMode);
            this.groupBox1.Controls.Add(this.buttonLightMode);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // buttonCustomizeMode
            // 
            this.buttonCustomizeMode.BackColor = System.Drawing.Color.Red;
            this.buttonCustomizeMode.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.buttonCustomizeMode, "buttonCustomizeMode");
            this.buttonCustomizeMode.Name = "buttonCustomizeMode";
            this.buttonCustomizeMode.UseVisualStyleBackColor = false;
            this.buttonCustomizeMode.Click += new System.EventHandler(this.buttonCustomizeMode_Click);
            // 
            // buttonDarkMode
            // 
            this.buttonDarkMode.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonDarkMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.buttonDarkMode, "buttonDarkMode");
            this.buttonDarkMode.Name = "buttonDarkMode";
            this.buttonDarkMode.UseVisualStyleBackColor = false;
            this.buttonDarkMode.Click += new System.EventHandler(this.buttonDarkMode_Click);
            // 
            // buttonLightMode
            // 
            this.buttonLightMode.BackColor = System.Drawing.SystemColors.Window;
            this.buttonLightMode.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.buttonLightMode, "buttonLightMode");
            this.buttonLightMode.Name = "buttonLightMode";
            this.buttonLightMode.UseVisualStyleBackColor = false;
            this.buttonLightMode.Click += new System.EventHandler(this.buttonLightMode_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // AstroForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxLanguage);
            this.Controls.Add(this.buttonCalculation);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBoxEventHorizon);
            this.Controls.Add(this.groupBoxCelcius);
            this.Controls.Add(this.groupBoxStarDistance);
            this.Controls.Add(this.groupBoxStarVelocity);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AstroForm";
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
            this.groupBoxLanguage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonLanguageGerman;
        private System.Windows.Forms.Button buttonLanguageFrench;
        private System.Windows.Forms.Button buttonLanguageEnglish;
        private System.Windows.Forms.GroupBox groupBoxLanguage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDarkMode;
        private System.Windows.Forms.Button buttonLightMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCustomizeMode;
        private System.Windows.Forms.Label label1;
    }
}

