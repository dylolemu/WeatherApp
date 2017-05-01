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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();

        }

        public void displayForecast()
        {
           minOutput1.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempLow)) + "°";
           maxOutput1.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempHigh)) + "°";
            min2.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempLow)) + "°";
            max2.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempHigh)) + "°";
            min3.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempLow)) + "°";
            max3.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempHigh)) + "°";
            min4.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempLow)) + "°";
            max4.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempHigh)) + "°";
            min5.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempLow)) + "°";
            max5.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempHigh)) + "°";
            min6.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempLow)) + "°";
            max6.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempHigh)) + "°";
            day1.Text = Convert.ToDateTime(Form1.days[1].date).ToString("dddd");
            day2.Text = Convert.ToDateTime(Form1.days[2].date).ToString("dddd");
            day3.Text = Convert.ToDateTime(Form1.days[3].date).ToString("dddd");
            day4.Text = Convert.ToDateTime(Form1.days[4].date).ToString("dddd");
            day5.Text = Convert.ToDateTime(Form1.days[5].date).ToString("dddd");
            day6.Text = Convert.ToDateTime(Form1.days[6].date).ToString("dddd");

            if (Convert.ToInt16(Form1.days[1].identity) >= 200 && Convert.ToInt16(Form1.days[1].identity) <= 232)
            {
                icon1.BackgroundImage = Properties.Resources.Thunder;
            }
            if (Convert.ToInt16(Form1.days[1].identity) >= 300 && Convert.ToInt16(Form1.days[1].identity) <= 321)
            {
                icon1.BackgroundImage = Properties.Resources.Rain;
            }
            if (Convert.ToInt16(Form1.days[1].identity) >= 500 && Convert.ToInt16(Form1.days[1].identity) <= 531)
            {
                icon1.BackgroundImage = Properties.Resources.Rain;
            }
            if (Convert.ToInt16(Form1.days[1].identity) == 600)
            {
                icon1.BackgroundImage = Properties.Resources.Sunny;
            }
            if (Convert.ToInt16(Form1.days[1].identity) >= 900 && Convert.ToInt16(Form1.days[1].identity) <= 962)
            {
                icon1.BackgroundImage = Properties.Resources.Windy;
            }
            if (Convert.ToInt16(Form1.days[1].identity) >= 801 && Convert.ToInt16(Form1.days[1].identity) <= 804)
            {
                icon1.BackgroundImage = Properties.Resources.Cloudy;
            }
            if (Convert.ToInt16(Form1.days[2].identity) >= 200 && Convert.ToInt16(Form1.days[2].identity) <= 232)
            {
                icon2.BackgroundImage = Properties.Resources.Thunder;
            }
            if (Convert.ToInt16(Form1.days[2].identity) >= 300 && Convert.ToInt16(Form1.days[2].identity) <= 321)
            {
                icon2.BackgroundImage = Properties.Resources.Rain;
            }
            if (Convert.ToInt16(Form1.days[2].identity) >= 500 && Convert.ToInt16(Form1.days[2].identity) <= 531)
            {
                icon2.BackgroundImage = Properties.Resources.Rain;
            }
            if (Convert.ToInt16(Form1.days[2].identity) == 600)
            {
                icon2.BackgroundImage = Properties.Resources.Sunny;
            }
            if (Convert.ToInt16(Form1.days[2].identity) >= 900 && Convert.ToInt16(Form1.days[2].identity) <= 962)
            {
                icon2.BackgroundImage = Properties.Resources.Windy;
            }
            if (Convert.ToInt16(Form1.days[2].identity) >= 801 && Convert.ToInt16(Form1.days[2].identity) <= 804)
            {
                icon2.BackgroundImage = Properties.Resources.Cloudy;
            }
            if (Convert.ToInt16(Form1.days[3].identity) >= 200 && Convert.ToInt16(Form1.days[3].identity) <= 232)
            {
                icon3.BackgroundImage = Properties.Resources.Thunder;
            }
            if (Convert.ToInt16(Form1.days[3].identity) >= 300 && Convert.ToInt16(Form1.days[3].identity) <= 321)
            {
                icon3.BackgroundImage = Properties.Resources.Rain;
            }
            if (Convert.ToInt16(Form1.days[3].identity) >= 500 && Convert.ToInt16(Form1.days[3].identity) <= 531)
            {
                icon3.BackgroundImage = Properties.Resources.Rain;
            }
            if (Convert.ToInt16(Form1.days[3].identity) == 600)
            {
                icon3.BackgroundImage = Properties.Resources.Sunny;
            }
            if (Convert.ToInt16(Form1.days[3].identity) >= 900 && Convert.ToInt16(Form1.days[3].identity) <= 962)
            {
                icon3.BackgroundImage = Properties.Resources.Windy;
            }
            if (Convert.ToInt16(Form1.days[3].identity) >= 801 && Convert.ToInt16(Form1.days[3].identity) <= 804)
            {
                icon3.BackgroundImage = Properties.Resources.Cloudy;
            }
            if (Convert.ToInt16(Form1.days[4].identity) >= 200 && Convert.ToInt16(Form1.days[4].identity) <= 232)
            {
                icon4.BackgroundImage = Properties.Resources.Thunder;
            }
            if (Convert.ToInt16(Form1.days[4].identity) >= 300 && Convert.ToInt16(Form1.days[4].identity) <= 321)
            {
                icon4.BackgroundImage = Properties.Resources.Rain;
            }
            if (Convert.ToInt16(Form1.days[4].identity) >= 500 && Convert.ToInt16(Form1.days[4].identity) <= 531)
            {
                icon4.BackgroundImage = Properties.Resources.Rain;
            }
            if (Convert.ToInt16(Form1.days[4].identity) == 600)
            {
                icon4.BackgroundImage = Properties.Resources.Sunny;
            }
            if (Convert.ToInt16(Form1.days[4].identity) >= 900 && Convert.ToInt16(Form1.days[4].identity) <= 962)
            {
                icon4.BackgroundImage = Properties.Resources.Windy;
            }
            if (Convert.ToInt16(Form1.days[4].identity) >= 801 && Convert.ToInt16(Form1.days[4].identity) <= 804)
            {
                icon4.BackgroundImage = Properties.Resources.Cloudy;
            }
            if (Convert.ToInt16(Form1.days[5].identity) >= 200 && Convert.ToInt16(Form1.days[5].identity) <= 232)
            {
                icon5.BackgroundImage = Properties.Resources.Thunder;
            }
            if (Convert.ToInt16(Form1.days[5].identity) >= 300 && Convert.ToInt16(Form1.days[5].identity) <= 321)
            {
                icon5.BackgroundImage = Properties.Resources.Rain;
            }
            if (Convert.ToInt16(Form1.days[5].identity) >= 500 && Convert.ToInt16(Form1.days[5].identity) <= 531)
            {
                icon5.BackgroundImage = Properties.Resources.Rain;
            }
            if (Convert.ToInt16(Form1.days[5].identity) == 600)
            {
                icon5.BackgroundImage = Properties.Resources.Sunny;
            }
            if (Convert.ToInt16(Form1.days[5].identity) >= 900 && Convert.ToInt16(Form1.days[5].identity) <= 962)
            {
                icon5.BackgroundImage = Properties.Resources.Windy;
            }
            if (Convert.ToInt16(Form1.days[5].identity) >= 801 && Convert.ToInt16(Form1.days[5].identity) <= 804)
            {
                icon5.BackgroundImage = Properties.Resources.Cloudy;
            }
            if (Convert.ToInt16(Form1.days[6].identity) >= 200 && Convert.ToInt16(Form1.days[6].identity) <= 232)
            {
                icon6.BackgroundImage = Properties.Resources.Thunder;
            }
            if (Convert.ToInt16(Form1.days[6].identity) >= 300 && Convert.ToInt16(Form1.days[6].identity) <= 321)
            {
                icon6.BackgroundImage = Properties.Resources.Rain;
            }
            if (Convert.ToInt16(Form1.days[6].identity) >= 500 && Convert.ToInt16(Form1.days[6].identity) <= 531)
            {
                icon6.BackgroundImage = Properties.Resources.Rain;
            }
            if (Convert.ToInt16(Form1.days[6].identity) == 600)
            {
                icon6.BackgroundImage = Properties.Resources.Sunny;
            }
            if (Convert.ToInt16(Form1.days[6].identity) >= 900 && Convert.ToInt16(Form1.days[6].identity) <= 962)
            {
                icon6.BackgroundImage = Properties.Resources.Windy;
            }
            if (Convert.ToInt16(Form1.days[6].identity) >= 801 && Convert.ToInt16(Form1.days[6].identity) <= 804)
            {
                icon6.BackgroundImage = Properties.Resources.Cloudy;
            }
        }
   
    
        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
