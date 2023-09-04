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

namespace AstroClient
{
    public partial class AstroForm : Form
    {
        #region Initialisation
        int starID = 0;
        private IAstroContract channel;
       
        public AstroForm()
        {
            InitializeComponent();
        }
        
        // Initialize Channel to Endpoint set up by server
        private void InitializeChannel()
        {
        string address = "net.pipe://localhost/astromath";
        NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
        EndpointAddress ep = new EndpointAddress(address);
        channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
        }
        #endregion

        #region Utility
        private void clearDisplay()
        {
            textBoxCelcius.Clear();
            textBoxMassExponent.Clear();
            textBoxMassOfStar.Clear();
            textBoxObservedWavelength.Clear();
            textBoxParallaxAngle.Clear();
            textBoxRestWavelength.Clear();
        }
        
        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            InitializeChannel();
            starID += 1;

            List<string> starList = new List<string>();

            starList.Add(starID.ToString());
            starList.Add(calculateStarVelocity(textBoxObservedWavelength, textBoxRestWavelength, channel.StarVelocity));
            starList.Add(calculateStarDistance(textBoxParallaxAngle, channel.StarDistance));
            starList.Add(calculateTemperature(textBoxCelcius, channel.TemperatureInKelvin));
            starList.Add(calculateEventHorizon(textBoxMassOfStar, textBoxMassExponent, channel.EventHorizon));


            ListViewItem lvi = new ListViewItem(starList.ToArray());
            listView.Items.Add(lvi);

            clearDisplay();
        }
        #endregion

        #region DLL Function
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
        private void ChangeLanguage(string language)
        {
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
            Controls.Clear();
            InitializeComponent();
        }

        private void toolStripMenuItemEnglishUK_Click(object sender, EventArgs e)
        {
            { ChangeLanguage("English"); }
        }

        private void toolStripMenuItemFrench_Click(object sender, EventArgs e)
        {
            { ChangeLanguage("French"); }
        }

        private void toolStripMenuItemGerman_Click(object sender, EventArgs e)
        {
            { ChangeLanguage("German"); }
        }
        #endregion

        #region Colour Selection
        private void toolStripMenuItemColour_Click(object sender, EventArgs e)
        {
            // Instance of ColorDialog
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                BackgroundImage = null;
                BackColor = colorDlg.Color;
                byte r = (byte)(255 - BackColor.R);
                byte g = (byte)(255 - BackColor.G);
                byte b = (byte)(255 - BackColor.B);
                ForeColor = Color.FromArgb(r, g, b);
                foreach (var button in Controls.OfType<Button>())
                {
                    button.BackColor = colorDlg.Color;
                }
                foreach (var textBox in Controls.OfType<TextBox>())
                {
                    textBox.ForeColor = Color.FromArgb(r, g, b);
                }

                foreach (var groupBox in Controls.OfType<GroupBox>())
                {
                    groupBox.ForeColor = Color.FromArgb(r, g, b);
                }
            }
        }

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

            if (listView != null)
            {
                listView.BackColor = Color.White;
                listView.ForeColor = Color.Black;
            }
        }

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
