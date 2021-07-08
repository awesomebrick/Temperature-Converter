using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void celsiusToFahrenheit_Click(object sender, EventArgs e)
        {
            // (°C × 9/5) + 32 = °F

            //INPUT
            bool success = double.TryParse(inputText.Text, out double inputTemp);
            //PROCESS
            if (success)
            {
                double outputTemp = (inputTemp * 9.0 / 5.0) + 32.0;
                //OUTPUT
                this.outputText.Text = outputTemp + " °F";
            }
            else
            {
                this.outputText.Text = "Please input a numerical value.";
            }
        }

        private void fahrenheitToCelsius_Click(object sender, EventArgs e)
        {
            // (°F − 32) × 5 / 9 = °C

            //INPUT
            bool success = double.TryParse(inputText.Text, out double inputTemp);
            //PROCESS
            if (success)
            {
                double outputTemp = (inputTemp - 32.0) * 5.0 / 9.0;
                //OUTPUT
                this.outputText.Text = outputTemp + " °C";
            }
            else
            {
                this.outputText.Text = "Please input a numerical value.";
            }
        }
    }
}
