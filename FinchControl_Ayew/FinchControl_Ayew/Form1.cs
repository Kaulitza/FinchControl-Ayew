using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinchAPI;

namespace FinchControl_Ayew
{
    public partial class Form_FinchControl : Form
    {
        Finch Ayew = new Finch();
        public Form_FinchControl()
        {
            InitializeComponent();
            InitializeFinch();
            InitializeTimer();
        }
        #region get measurement for textboxes
        private void InitializeTimer()
        {
            Timer timer = new Timer
            {
                Interval = (200)
            };
            timer.Tick += new EventHandler(SetLightLevel);
            timer.Tick += new EventHandler(SetTemperatureLevel);
            timer.Start();
        }
        private void SetLightLevel(object sender, EventArgs e)
        {
            int[] lightlevels = Ayew.getLightSensors();
            double lightLevel = lightlevels.Average();

            txtBox_LightLevel.Text = lightLevel.ToString();
        }
        private void SetTemperatureLevel(object sender, EventArgs e)
        {
            double celsiusTemp = Ayew.getTemperature();
            txtBox_Celsius.Text = celsiusTemp.ToString();
            double fahrenheitTemp;
            fahrenheitTemp = ((celsiusTemp * 9 / 5 + 32));
            txtBox_Fahrenheit.Text = fahrenheitTemp.ToString();

        }
        #endregion
        private void InitializeFinch()
        {
            Ayew.connect();
        }
        #region Buttons to move Ayew
        private void btn_Forward_Click_1(object sender, EventArgs e)
        {
            Ayew.setMotors(255, 255);
        }

        private void btn_Backward_Click_1(object sender, EventArgs e)
        {
            Ayew.setMotors(-255, -255);
        }

        private void btn_Left_Click_1(object sender, EventArgs e)
        {
            Ayew.setMotors(100, 255);
        }

        private void btn_Right_Click_1(object sender, EventArgs e)
        {
            Ayew.setMotors(255, 0);
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Ayew.setMotors(0, 0);
        }
        #endregion
        #region Play songs with Finch Robot
        private void checkBox_BrotherJohn_CheckedChanged_1(object sender, EventArgs e)
        {
            Ayew.noteOn(523);
            Ayew.wait(500);
            Ayew.noteOn(587);
            Ayew.wait(500);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(523);
            Ayew.wait(500);
            Ayew.noteOn(523);
            Ayew.wait(500);
            Ayew.noteOn(587);
            Ayew.wait(500);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(523);
            Ayew.wait(1000);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(784);
            Ayew.wait(1000);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(784);
            Ayew.wait(1000);
            Ayew.noteOn(784);
            Ayew.wait(200);
            Ayew.noteOn(880);
            Ayew.wait(200);
            Ayew.noteOn(784);
            Ayew.wait(200);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(525);
            Ayew.wait(1000);
            Ayew.noteOn(784);
            Ayew.wait(200);
            Ayew.noteOn(880);
            Ayew.wait(200);
            Ayew.noteOn(784);
            Ayew.wait(200);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(525);
            Ayew.wait(1000);
            Ayew.noteOn(525);
            Ayew.wait(500);
            Ayew.noteOn(525);
            Ayew.wait(698);
            Ayew.noteOn(525);
            Ayew.wait(500);
            Ayew.noteOff();
        }

        private void checkBox_Falling_CheckedChanged_1(object sender, EventArgs e)
        {
            Ayew.noteOn(587);
            Ayew.wait(1000);
            Ayew.noteOn(880);
            Ayew.wait(1000);
            Ayew.noteOn(587);
            Ayew.wait(1000);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(784);
            Ayew.wait(1000);
            Ayew.noteOn(698);
            Ayew.wait(1000);
            Ayew.noteOn(659);
            Ayew.wait(1000);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(382);
            Ayew.wait(1000);
            Ayew.noteOn(523);
            Ayew.wait(1000);
            Ayew.noteOn(587);
            Ayew.wait(1000);
            Ayew.noteOn(659);
            Ayew.wait(750);
            Ayew.noteOn(698);
            Ayew.wait(750);
            Ayew.noteOn(784);
            Ayew.wait(750);
            Ayew.noteOn(698);
            Ayew.wait(1000);
            Ayew.noteOn(659);
            Ayew.wait(1000);
            Ayew.noteOn(587);
            Ayew.wait(1000);
            Ayew.noteOff();
        }

        private void checkBox_GameOfThrones_CheckedChanged_1(object sender, EventArgs e)
        {
            Ayew.noteOn(784);
            Ayew.wait(1000);
            Ayew.noteOn(523);
            Ayew.wait(1000);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(784);
            Ayew.wait(1000);
            Ayew.noteOn(523);
            Ayew.wait(1000);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(784);
            Ayew.wait(1000);
            Ayew.noteOn(523);
            Ayew.wait(1000);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(784);
            Ayew.wait(1000);
            Ayew.noteOn(523);
            Ayew.wait(1000);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(784);
            Ayew.wait(1000);
            Ayew.noteOn(523);
            Ayew.wait(1000);
            Ayew.noteOn(677);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(784);
            Ayew.wait(1000);
            Ayew.noteOn(523);
            Ayew.wait(1000);
            Ayew.noteOn(677);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(784);
            Ayew.wait(1000);
            Ayew.noteOn(523);
            Ayew.wait(1000);
            Ayew.noteOn(677);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(784);
            Ayew.wait(1000);
            Ayew.noteOn(523);
            Ayew.wait(1000);
            Ayew.noteOn(677);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(784);
            Ayew.wait(3000);
            Ayew.noteOn(523);
            Ayew.wait(3000);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(784);
            Ayew.wait(2000);
            Ayew.noteOn(523);
            Ayew.wait(2000);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(500);
            Ayew.noteOn(587);
            Ayew.wait(3000);
            Ayew.noteOn(587);
            Ayew.wait(3000);
            Ayew.noteOn(587);
            Ayew.wait(3000);
            Ayew.noteOn(587);
            Ayew.wait(3000);
            Ayew.noteOn(698);
            Ayew.wait(3000);
            Ayew.noteOn(587);
            Ayew.wait(3000);
            Ayew.noteOn(498);
            Ayew.wait(3000);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(587);
            Ayew.wait(500);
            Ayew.noteOn(698);
            Ayew.wait(2000);
            Ayew.noteOn(498);
            Ayew.wait(3000);
            Ayew.noteOn(659);
            Ayew.wait(500);
            Ayew.noteOn(587);
            Ayew.wait(500);
            Ayew.noteOn(523);
            Ayew.wait(2000);
            Ayew.noteOff();
        }
        private void checkBox_Birthday_CheckedChanged(object sender, EventArgs e)
        {
            Ayew.noteOn(523);
            Ayew.wait(1500);
            Ayew.noteOn(523);
            Ayew.wait(500);
            Ayew.noteOn(587);
            Ayew.wait(1000);
            Ayew.noteOn(523);
            Ayew.wait(1000);
            Ayew.noteOn(698);
            Ayew.wait(1000);
            Ayew.noteOn(659);
            Ayew.wait(2000);
            Ayew.noteOn(523);
            Ayew.wait(1500);
            Ayew.noteOn(523);
            Ayew.wait(500);
            Ayew.noteOn(587);
            Ayew.wait(1000);
            Ayew.noteOn(523);
            Ayew.wait(1000);
            Ayew.noteOn(785);
            Ayew.wait(1000);
            Ayew.noteOn(698);
            Ayew.wait(2000);
            Ayew.noteOn(523);
            Ayew.wait(1500);
            Ayew.noteOn(523);
            Ayew.wait(500);
            Ayew.noteOn(1047);
            Ayew.wait(1000);
            Ayew.noteOn(880);
            Ayew.wait(1000);
            Ayew.noteOn(698);
            Ayew.wait(1000);
            Ayew.noteOn(659);
            Ayew.wait(1000);
            Ayew.noteOn(587);
            Ayew.wait(1000);
            Ayew.noteOn(988);
            Ayew.wait(1500);
            Ayew.noteOn(988);
            Ayew.wait(500);
            Ayew.noteOn(880);
            Ayew.wait(1000);
            Ayew.noteOn(698);
            Ayew.wait(1000);
            Ayew.noteOn(784);
            Ayew.wait(1000);
            Ayew.noteOn(698);
            Ayew.wait(2000);
        }
        #endregion
        #region Checkboxes for lights
        private void checkBox_Red_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_Red.Checked)
            {
                Ayew.setLED(255, 0, 0);
            }
            else
            {
                Ayew.setLED(0, 0, 0);
            }
        }

        private void checkBox_Blue_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_Blue.Checked)
            {
                Ayew.setLED(0, 0, 255);
            }
            else
            {
                Ayew.setLED(0, 0, 0);
            }
        }

        private void checkBox_Green_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_Green.Checked)
            {
                Ayew.setLED(0, 255, 0);
            }
            else
            {
                Ayew.setLED(0, 0, 0);
            }
        }

        private void checkBox_White_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_White.Checked)
            {
                Ayew.setLED(255, 255, 255);
            }
            else
            {
                Ayew.setLED(0, 0, 0);
            }
        }
        #endregion

        private void btn_Stopmusic_Click(object sender, EventArgs e)
        {
            Ayew.noteOff();
        }
    }
}