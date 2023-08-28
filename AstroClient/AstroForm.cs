using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.ServiceModel;

namespace AstroClient
{
    public partial class AstroForm : Form
    {
        string address = "net.pipe://localhost/astromath";
        NetNamedPipeBinding binding;
        EndpointAddress ep;
        IAstroContract channel;
        int initialRow = 0;

        public AstroForm()
        {
            InitializeComponent();
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
        }


        private void buttonCalculation_Click(object sender, EventArgs e)
        {            
            int currentRow = initialRow + 1;

            ListViewItem lvi = new ListViewItem(currentRow.ToString());
            lvi.SubItems.Add(calculateStarVelocity(textBoxObservedWavelength, textBoxRestWavelength, channel.StarVelocity));
            lvi.SubItems.Add(calculateStarDistance(textBoxParallaxAngle, channel.StarDistance));
            lvi.SubItems.Add(calculateTemperature(textBoxCelcius, channel.TemperatureInKelvin));
            lvi.SubItems.Add(calculateEventHorizon(textBoxMassOfStar, textBoxMassExponent, channel.EventHorizon));
            listView.Items.Add(lvi);
        }

        private string calculateStarVelocity(TextBox textBox1, TextBox textBox2, Func<double, double, double> Formula)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return "";
            }
            try
            {
                double input1 = double.Parse(textBox1.Text);
                double input2 = double.Parse(textBox2.Text);
                double output = Formula(input1, input2);
                return output.ToString("0.##E+00") + " m/s";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error!";
            }
        }

        private string calculateStarDistance(TextBox textBox ,Func<double, double> Formula)
        {
            if (textBox.Text == ""){
                return "";
            }
            try
            {
                double input = double.Parse(textBox.Text);
                string result = (input <= 0) ? "Error! Invalid Input" : Formula(input).ToString("0.##E+00") + " pc";
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error!";
            }
        }

        private string calculateTemperature(TextBox textBox, Func<double, double> Formula)
        {
            if (textBox.Text == "")
            {
                return "";
            }
            try
            {
                double input = double.Parse(textBox.Text);
                string result = (input < -273) ? "Error! Input must larger than -273" : Formula(input).ToString() + " °K";
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error!";
            }
        }

        private string calculateEventHorizon(TextBox textBox1, TextBox textBox2, Func<double, double> Formula)
        {
            if (textBox1.Text == "")
            {
                return "";
            }
            try
            {
                double input1 = double.Parse(textBox1.Text);
                int input2 = int.Parse(textBox2.Text);
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
    }
}
