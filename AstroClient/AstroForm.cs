using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.ServiceModel;
using System.Globalization;
using System.Threading;

// Name: Derrick Choong
// ID: 30066568
// Date: 04/09/2023

namespace AstroClient
{
    public partial class AstroForm : Form
    {
        #region Initialisation
        int starID = 0; // Initialize StarID.
        private IAstroContract channel; // Initialize instance IAstroContract.
       
        public AstroForm()
        {
            InitializeComponent();
        }
        
        // Initialize Channel to Endpoint set up by server.
        private void InitializeChannel()
        {
        string address = "net.pipe://localhost/astromath";
        NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
        EndpointAddress ep = new EndpointAddress(address);
        channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
        }
        #endregion

        #region Utility
        // Method to clear display on all textBox.
        private void clearDisplay()
        {
            textBoxCelcius.Clear();
            textBoxMassExponent.Clear();
            textBoxMassOfStar.Clear();
            textBoxObservedWavelength.Clear();
            textBoxParallaxAngle.Clear();
            textBoxRestWavelength.Clear();
        }
        
        // Event handler for the "Calculate" button.
        // Calculate all the inputs with respective formulas and output to the ListView.
        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            InitializeChannel(); // Initialize Channel to AstroServer for implmentation of AstronomicalFormula
            starID += 1;    // Increment the starID to keep track of each calculation.


            List<string> starList = new List<string>();

            starList.Add(starID.ToString());
            starList.Add(calculateStarVelocity(textBoxObservedWavelength, textBoxRestWavelength, channel.StarVelocity));
            starList.Add(calculateStarDistance(textBoxParallaxAngle, channel.StarDistance));
            starList.Add(calculateTemperature(textBoxCelcius, channel.TemperatureInKelvin));
            starList.Add(calculateEventHorizon(textBoxMassOfStar, textBoxMassExponent, channel.EventHorizon));

            // Create a ListView Item from the starList and add it to the listView.
            ListViewItem lvi = new ListViewItem(starList.ToArray());
            listView.Items.Add(lvi);

            clearDisplay();
        }
        #endregion

        #region DLL Function
        // Calculate Star Velocity based on user input.
        private string calculateStarVelocity(TextBox textBoxObservedWavelength, TextBox textBoxRestWavelength, Func<double, double, double> Formula)
        {
            if (textBoxObservedWavelength.Text == "" || textBoxRestWavelength.Text == "")
            {
                return "";
            }
            try
            {
                double input1 = double.Parse(textBoxObservedWavelength.Text);
                double input2 = double.Parse(textBoxRestWavelength.Text);
                string output = (input2 == 0) ? "Error: Zero Division" : Formula(input1, input2).ToString("0.##") + " m/s";
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error!";
            }
        }

        // Calculate Star Distance based on user input.
        private string calculateStarDistance(TextBox textBoxParallaxAngle, Func<double, double> Formula)
        {
            if (textBoxParallaxAngle.Text == ""){
                return "";
            }
            try
            {
                double input = double.Parse(textBoxParallaxAngle.Text);
                string result = (input == 0) ? "Error! Zero Division" : Formula(input).ToString("0.##") + " pc";
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error!";
            }
        }

        // Calculate Temperature based on user input.
        private string calculateTemperature(TextBox textBoxCelcius, Func<double, double> Formula)
        {
            if (textBoxCelcius.Text == "")
            {
                return "";
            }
            try
            {
                double input = double.Parse(textBoxCelcius.Text);
                string result = (input < -273) ? "Error! Input < -273" : Formula(input).ToString("0.##") + " °K";
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error!";
            }
        }
        
        // Calculate Event Horizon based on user input.
        private string calculateEventHorizon(TextBox textBoxMassOfStar, TextBox textBoxMassExponent, Func<double, double> Formula)
        {
            if (textBoxMassOfStar.Text == "")
            {
                return "";
            }
            try
            {
                double input1 = double.Parse(textBoxMassOfStar.Text);
                int input2 = int.Parse(textBoxMassExponent.Text);
                double massOfStar = input1 * Math.Pow(10, input2);
                double output = Formula(massOfStar);
                return output.ToString("0.##E+00") + " m";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error!";
            }
        }
        #endregion

        #region KeyPress
        // Handle invalid keypress events for textboxes.
        private void InvalidKeyPress (object sender, KeyPressEventArgs e, TextBox textBox) 
        {
            // Regex only accept key: \d is numeric value, . is decimal, \b is backspace, - is negative
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d.\b-]"))
                e.Handled = true;
            // Check if only one decimal
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
                e.Handled = true;
            // Check if negative only apply on first index
            if (e.KeyChar == '-' && textBox.SelectionStart != 0)
                e.Handled = true;
        }

        private void textBoxObservedWavelength_KeyPress(object sender, KeyPressEventArgs e)
        {            InvalidKeyPress(sender, e, textBoxObservedWavelength);        }

        private void textBoxRestWavelength_KeyPress(object sender, KeyPressEventArgs e)
        {            InvalidKeyPress(sender, e, textBoxRestWavelength);        }

        private void textBoxParallaxAngle_KeyPress(object sender, KeyPressEventArgs e)
        {            InvalidKeyPress(sender, e, textBoxParallaxAngle);        }

        private void textBoxCelcius_KeyPress(object sender, KeyPressEventArgs e)
        {            InvalidKeyPress(sender, e, textBoxCelcius);        }

        private void textBoxMassOfStar_KeyPress(object sender, KeyPressEventArgs e)
        {            InvalidKeyPress(sender, e, textBoxMassOfStar);        }

        private void textBoxMassExponent_KeyPress(object sender, KeyPressEventArgs e)
        {            InvalidKeyPress(sender, e, textBoxMassExponent);        }

        #endregion

        #region Language Globalization 
        // This method changes the application's language based on the selected language parameter.
        private void ChangeLanguage(string language)
        {
            // Set the current UI culture to Selected Language.
            switch (language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                    break;
                case "French":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
                    break;
            }

            // Clear all controls in the form.
            Controls.Clear();

            // Reinitialize the form components to apply the selected language.
            InitializeComponent();
        }

        private void toolStripMenuItemEnglishUK_Click(object sender, EventArgs e)
        {            { ChangeLanguage("English"); }        }

        private void toolStripMenuItemFrench_Click(object sender, EventArgs e)
        {            { ChangeLanguage("French"); }        }

        private void toolStripMenuItemGerman_Click(object sender, EventArgs e)
        {            { ChangeLanguage("German"); } }
        #endregion

        #region Colour Selection
        // Event handler for the "Choose Colour" menu item.
        private void toolStripMenuItemColour_Click(object sender, EventArgs e)
        {
            // Create instance of ColorDialog to let the user choose a color.
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                BackgroundImage = null;
                BackColor = colorDlg.Color;

                // Calculate inverse text color based on the background color. 
                byte r = (byte)(255 - BackColor.R);
                byte g = (byte)(255 - BackColor.G);
                byte b = (byte)(255 - BackColor.B);

                ForeColor = Color.FromArgb(r, g, b);

                // Update button background colors.
                foreach (var button in Controls.OfType<Button>())
                {
                    button.BackColor = colorDlg.Color;
                }

                // Update text box text colors.
                foreach (var textBox in Controls.OfType<TextBox>())
                {
                    textBox.ForeColor = Color.FromArgb(r, g, b);
                }

                // Update group box text colors.
                foreach (var groupBox in Controls.OfType<GroupBox>())
                {
                    groupBox.ForeColor = Color.FromArgb(r, g, b);
                }
            }
        }

        // Event handler for the "Light Mode" menu item. 
        // User selection for Light Colour Theme for the application.
        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Background color
            BackColor = Color.White;

            // Foreground color
            ForeColor = Color.Black;

            // Buttons
            foreach (var button in Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.LightGray;
                button.ForeColor = Color.Black;
            }

            // Labels
            foreach (var label in Controls.OfType<Label>())
            {
                label.ForeColor = Color.Black;
            }

            // Textboxes
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ForeColor = Color.Black;
            }

            // GroupBoxes
            foreach (var groupBox in Controls.OfType<GroupBox>())
            {
                groupBox.ForeColor = Color.Black;
            }

            // ListView
            if (listView != null)
            {
                listView.BackColor = Color.White;
                listView.ForeColor = Color.Black;
            }
        }

        // Event handler for the "Dark Mode" menu item. 
        // User selection for Dark Colour Theme for the application.
        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            ForeColor = Color.White;

            // To apply color to columnheader, set OwnerDrawing in listView properties = true;
            // listView.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(listView_DrawColumnHeaderDark);
            foreach (var button in Controls.OfType<Button>())
            {
                button.BackColor = Color.FromArgb(38, 38, 38); // Dark gray
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66); // Slightly lighter gray
                button.ForeColor = Color.White;
            }

            foreach (var label in Controls.OfType<Label>())
            {
                label.ForeColor = Color.White;
            }

            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ForeColor = Color.White;
            }

            foreach (var groupBox in Controls.OfType<GroupBox>())
            {
                groupBox.ForeColor = Color.White;
            }

            if (listView != null)
            {
                listView.BackColor = Color.FromArgb(38, 38, 38); // Dark gray
                listView.ForeColor = Color.White;
            }

        }


        // To manually change the colour setting of column header in ListView
        //private void listView_DrawColumnHeaderDark(object sender, DrawListViewColumnHeaderEventArgs e)
        //{

        //    Console.WriteLine("DrawColumnHeader event handler executed.");
        //    e.Graphics.FillRectangle(Brushes.Black, e.Bounds); //Fill header with color

        //    //Adjust the position of the text to be vertically centered
        //    int yOffset = (e.Bounds.Height - e.Graphics.MeasureString(e.Header.Text, e.Font).ToSize().Height) / 2;
        //    Rectangle newBounds = new Rectangle(e.Bounds.X, e.Bounds.Y + yOffset, e.Bounds.Width, e.Bounds.Height - yOffset);

        //    e.Graphics.DrawString(e.Header.Text, e.Font, Brushes.White, newBounds);
        //}
        //private void listView_DrawColumnHeaderDefault (object sender, DrawListViewColumnHeaderEventArgs e)
        //{

        //    Console.WriteLine("DrawColumnHeader event handler executed.");
        //    e.Graphics.FillRectangle(Brushes.White, e.Bounds); //Fill header with color

        //    //Adjust the position of the text to be vertically centered
        //    int yOffset = (e.Bounds.Height - e.Graphics.MeasureString(e.Header.Text, e.Font).ToSize().Height) / 2;
        //    Rectangle newBounds = new Rectangle(e.Bounds.X, e.Bounds.Y + yOffset, e.Bounds.Width, e.Bounds.Height - yOffset);

        //    e.Graphics.DrawString(e.Header.Text, e.Font, Brushes.Black, newBounds);
        //}
        #endregion

    }
}
