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

        #region Globalization
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


        #endregion

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
    }
}
