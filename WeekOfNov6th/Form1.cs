using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            var input = txtInput1.Text + Environment.NewLine;
            var input2 = txtInput2.Text + Environment.NewLine;

            if (input == "")
            {
                rtbOutput.Text += "please type something";
            }
            else if (input2 == "")
            {
                rtbOutput.Text += "please type something";
            }
            else if (rdoTempConverter1.Checked)
            {
                rtbOutput.Text += (float.Parse(input) * 9 / 5) + 32 + " Degrees Fahrenheit" + Environment.NewLine;
                rtbOutput.Text += (float.Parse(input2) * 9 / 5) + 32 + " Degrees Fahrenheit" + Environment.NewLine;
            }
            else if (rdoTempConverter2.Checked)
            {
                rtbOutput.Text += (float.Parse(input) - 32) * 5 / 9 + " Degrees celsious" + Environment.NewLine;
                rtbOutput.Text += (float.Parse(input2) - 32) * 5 / 9 + " Degrees celsious" + Environment.NewLine;
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            var input2 = txtInput2.Text;
            var input = txtInput1.Text;

            if (input == "" && input2 == "")
            {
                rtbOutput.Text += "please type something" + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar to Yen" && input != "" && input2 != "")
            {
                rtbOutput.Text += (float.Parse(input2) * 149.81) + "Yen" + Environment.NewLine;
                rtbOutput.Text += (float.Parse(input) * 149.81) + "Yen" + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Yen to Dollar" && input != "" && input2 != "")
            {
                rtbOutput.Text += (float.Parse(input2) * 0.0067) + "Dollars" + Environment.NewLine;
                rtbOutput.Text += (float.Parse(input) * 0.0067) + "Dollars" + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar to Reais" && input != "" && input2 != "")
            {
                rtbOutput.Text += (float.Parse(input2) * 4.91) + "Reais" + Environment.NewLine;
                rtbOutput.Text += (float.Parse(input) * 4.91) + "Reais" + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Reais to Dollar" && input != "" && input2 != "")
            {
                rtbOutput.Text += (float.Parse(input2) * 0.20) + "Dollars" + Environment.NewLine;
                rtbOutput.Text += (float.Parse(input) * 0.20) + "Dollars" + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Rupees to Dollar " && input != "" && input2 != "")
            {
                rtbOutput.Text += (float.Parse(input2) * 0.012) + "Dollars" + Environment.NewLine;
                rtbOutput.Text += (float.Parse(input) * 0.012) + "Dollars" + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar to Rupees" && input != "" && input2 != "")
            {
                rtbOutput.Text += (float.Parse(input2) * 83.22) + "Rupees" + Environment.NewLine;
                rtbOutput.Text += (float.Parse(input) * 83.22) + "Rupees" + Environment.NewLine;
            }
        }

        private void btnDistance_Click(object sender, EventArgs e)
        {
            var input2 = txtInput2.Text;
            var input = txtInput1.Text;

            if (input == "")
            {
                rtbOutput.Text += "type something";
            }
            else if (input2 == "")
            {
                rtbOutput.Text += "type something";
            }
            else if (chkMileToKilo.Checked)
            {
                rtbOutput.Text += (float.Parse(input2) * 1.61) + " Km" + Environment.NewLine;
                rtbOutput.Text += (float.Parse(input) * 1.61) + " Km" + Environment.NewLine;
            }
            else if (chkMeterToInch.Checked)
            {
                rtbOutput.Text += (float.Parse(input2) * 39.37) + " In" + Environment.NewLine;
                rtbOutput.Text += (float.Parse(input) * 39.37) + " In" + Environment.NewLine;
            }
        }

        private void btnDistance2_Click(object sender, EventArgs e)
        {
            var input = txtInput1.Text;
            var input2 = txtInput2.Text;

            if (input == "")
            {
                rtbOutput.Text += "type something";
            }
            else if (input2 == "")
            {
                rtbOutput.Text += "type something";
            }
            else if (chkKiloToMiles.Checked)
            {
                rtbOutput.Text += (float.Parse(input2) * 0.62) + " Miles" + Environment.NewLine;
                rtbOutput.Text += (float.Parse(input) * 0.62) + " Miles" + Environment.NewLine;
            }
            else if (chkInchToMeter.Checked)
            {
                rtbOutput.Text += (float.Parse(input2) * 0.025) + " Meters" + Environment.NewLine;
                rtbOutput.Text += (float.Parse(input) * 0.025) + " Meters" + Environment.NewLine;
            }
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            string FilePath = "C:\\Users\\gabe\\source\\repos\\weekofnov6th-gabe123545\\WeekOfNov6th\\bin\\test.txt";
            string FileContents = File.ReadAllText(FilePath);
            rtbOutput.Text += FileContents + Environment.NewLine;
        }

        private void btnWordCount_Click(object sender, EventArgs e)
        {
            string FilePath = "C:\\Users\\gabe\\source\\repos\\weekofnov6th-gabe123545\\WeekOfNov6th\\bin\\test.txt";
            string FileContents = File.ReadAllText(FilePath);
            string[] filewords = FileContents.Split(' ');
            string input = txtInput1.Text + txtInput2.Text;
            int input1int = int.Parse(input);

            rtbOutput.Text = "";

            for (int i = 0; i < filewords.Length; i+= input1int)
            {
                rtbOutput.Text += filewords[i] + " " + Environment.NewLine;
            }
        }

        private void btnArrayStuff_Click(object sender, EventArgs e)
        { 
            bool done = false;
            string alphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
            string[] array = alphabet.Split(' ');
            
            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0)
                {
                    rtbOutput.Text += ",";
                }
                rtbOutput.Text += array[i];
            }
            rtbOutput.Text += Environment.NewLine + "-------------" + Environment.NewLine;

            for (int i = 0; i < array.Length; i++)
            {

                if (i + 97 == 97 || i + 97 == 101 || i + 97 == 105 || i + 97 == 111 || i + 97 == 117)
                {
                    rtbOutput.Text += array[i].ToUpper();
                }
                else
                {
                    rtbOutput.Text += array[i];
                }
            }
            rtbOutput.Text += Environment.NewLine + "-------------" + Environment.NewLine;

            while (done != true)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (i != array.Length - 1)
                    {
                        rtbOutput.Text += ",";
                    }
                    rtbOutput.Text += array[i];
                    done = true;
                }
            }

            done = false;
            rtbOutput.Text += Environment.NewLine + "-------------" + Environment.NewLine;

            int count = 0;
            bool upper = false;

            while (count < 26)
            {
                if (upper)
                {
                    rtbOutput.Text += array[count].ToUpper();
                }
                else
                {
                    rtbOutput.Text += array[count].ToLower();
                }
                if ((count + 1) % 5 == 0 )
                {
                    rtbOutput.Text += ",";
                    upper = true;
                }
                if((count + 1) % 10 == 0)
                {
                    upper = false;
                }


                count++;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
        }
    }
}