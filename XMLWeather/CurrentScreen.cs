using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        { 
            cityOutput.Text = Form1.days[0].location;
            dateOutput.Text = DateTime.Now.ToString("dddd MMMM d ");
            currentTemp.Text = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp)) + "°";
            minOutput.Text = Form1.days[0].tempLow + "°";
            maxOutput.Text = Form1.days[0].tempHigh + "°";
            // conditionOutput.Text = Form1.days[0].condition;
            if (Convert.ToInt16(Form1.days[0].identity) >= 200 && Convert.ToInt16(Form1.days[0].identity) <= 232)
            {
                conditionImage.BackgroundImage = Properties.Resources.Thunder;
            }
            if (Convert.ToInt16(Form1.days[0].identity) >= 300 && Convert.ToInt16(Form1.days[0].identity) <= 321)
            {
                conditionImage.BackgroundImage = Properties.Resources.Rain;
            }
            if ( Convert.ToInt16(Form1.days[0].identity) >=500 && Convert.ToInt16(Form1.days[0].identity) <= 531)
            {
                conditionImage.BackgroundImage = Properties.Resources.Rain;
            }
            if (Convert.ToInt16(Form1.days[0].identity) == 600)
            {
                conditionImage.BackgroundImage = Properties.Resources.Sunny;
            }
            if (Convert.ToInt16(Form1.days[0].identity) >= 900 && Convert.ToInt16(Form1.days[0].identity) <= 962)
            {
                conditionImage.BackgroundImage = Properties.Resources.Windy;
            }
            if (Convert.ToInt16(Form1.days[0].identity) >= 801 && Convert.ToInt16(Form1.days[0].identity) <= 804)
            {
                conditionImage.BackgroundImage = Properties.Resources.Cloudy;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
