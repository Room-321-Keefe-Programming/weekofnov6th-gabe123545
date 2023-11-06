using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            var input = txtInput1.Text;

            if (rdoTempConverter1.Checked)
            {
                rtbOutput.Text += (float.Parse(input) * 9 / 5) + 32 + " Degrees Fahrenheit" + Environment.NewLine;
            }
            else
            {
                rtbOutput.Text += (float.Parse(input) - 32) * 5 / 9 + " Degrees celsious" + Environment.NewLine;
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            var input2 = txtInput2.Text;

            if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar to Yen")
            {
                rtbOutput.Text += (float.Parse(input2) * 149.81) + "Yen" + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Yen to Dollar")
            {
                rtbOutput.Text += (float.Parse(input2) * 0.0067) + "Dollars" + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar to Reais")
            {
                rtbOutput.Text += (float.Parse(input2) * 4.91) + "Reais" + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Reais to Dollar")
            {
                rtbOutput.Text += (float.Parse(input2) * 0.20) + "Dollars" + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Rupees to Dollar ")
            {
                rtbOutput.Text += (float.Parse(input2) * 0.012) + "Dollars" + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar to Rupees")
            {
                rtbOutput.Text += (float.Parse(input2) * 83.22) + "Rupees" + Environment.NewLine;
            }
        }

        private void btnDistance_Click(object sender, EventArgs e)
        {
            var input2 = txtInput2.Text;

            if (chkMileToKilo.Checked)
            {
                rtbOutput.Text += (float.Parse(input2) * 1.60934) + " Km" + Environment.NewLine; 
            }
            else if (chkMeterToInch.Checked)
            {
                rtbOutput.Text += (float.Parse(input2) * 39.37006655984252) + " In" + Environment.NewLine;
            }
        }

        private void btnDistance2_Click(object sender, EventArgs e)
        {
            var input2 = txtInput2.Text;
            if (chkKiloToMiles.Checked)
            {
                rtbOutput.Text += (float.Parse(input2) * 0.621371) + " Miles" + Environment.NewLine;
            }
            else if (chkInchToMeter.Checked)
            {
                rtbOutput.Text += (float.Parse(input2) * 0.025399992141747998464) + " Meters" + Environment.NewLine;
            }
        }
    }
}
