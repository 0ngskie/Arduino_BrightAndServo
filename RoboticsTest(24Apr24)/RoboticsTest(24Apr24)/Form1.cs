using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboticsTest_24Apr24_
{
    public partial class Form1 : Form
    {
        private String redBrightnessValue;
        private String yellowBrightnessValue;
        

        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void angleTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void angleApplyButton_Click(object sender, EventArgs e)
        {

            string applyCommand = "S" + angleTextBoxInput.Text;
            serialPort1.Write(applyCommand);
        }


        private void brightnessTracker_Scroll(object sender, EventArgs e)
        {
            redBrightnessValue = "R" + brightnessTracker.Value;
        }

        private void ledConfirmButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(redBrightnessValue)) {
                redBrightnessValue = "R0";
            }
                serialPort1.Write(redBrightnessValue);
        }

        private void yellowBrightnessTracker_Scroll(object sender, EventArgs e)
        {
            yellowBrightnessValue = "Y" + yellowBrightnessTracker.Value;
        }

        private void yellowConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(yellowBrightnessValue))
            {
                yellowBrightnessValue = "Y0";
            }
            serialPort1.Write(yellowBrightnessValue);
        }
    }
}   
