using System;
using System.Web.UI;

namespace Congestion_Charge
{
    public partial class Default : Page
    {
        private int rate = 2;
        private double rate2 = 2.5;
        private int rate3 = 1;

        protected void Select_Click(object sender, EventArgs e)
        {
            if (vehicleList.SelectedValue == "Car")
            {
                CarRateCount();
            }
            else if (vehicleList.SelectedValue == "Motorbike")
            {
                MotorbikeRateCount();
            }
            else if (vehicleList.SelectedValue == "Van")
            {
                VanRateCount();
            }
            else
            {
                return;
            }
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            if (vehicleList.SelectedValue == "Car")
            {
                TextIDCar.Text = string.Empty;
                TextIDCar2.Text = string.Empty;
            }
            else if (vehicleList.SelectedValue == "Motorbike")
            {
                TextIDMoto.Text = string.Empty;
                TextIDMoto2.Text = string.Empty;
            }
            else if (vehicleList.SelectedValue == "Van")
            {
                TextIDVan.Text = string.Empty;
                TextIDVan2.Text = string.Empty;
            }
            else
            {
                return;
            }
        }

        //Car rate
        public void CarRateCount()
        {
            TimeSpan duration1 = TimeSpan.Parse("00:28:00");
            TimeSpan duration2 = TimeSpan.Parse("2:42:00");

            var result = (duration1.Hours + ((double)duration1.Minutes / 60)) * rate;
            var result2 = (duration2.Hours + ((double)duration2.Minutes / 60)) * rate2;

            TextIDCar.Text = RoundDownToNearest((double)result, 0.10).ToString("C");
            TextIDCar2.Text = RoundDownToNearest((double)result2, 0.10).ToString("C");
        }

        //Motorbike rate
        public void MotorbikeRateCount()
        {
            TimeSpan duration1 = TimeSpan.Parse("00:00:00");
            TimeSpan duration2 = TimeSpan.Parse("2:00:00");

            var result = (duration1.Hours + ((double)duration1.Minutes / 60)) * rate3;
            var result2 = (duration2.Hours + ((double)duration2.Minutes / 60)) * rate3;

            TextIDMoto.Text = RoundDownToNearest((double)result, 0.10).ToString("C");
            TextIDMoto2.Text = RoundDownToNearest((double)result2, 0.10).ToString("C");
        }

        //Van rate
        public void VanRateCount()
        {
            TimeSpan duration1 = TimeSpan.Parse("3:39:00");
            TimeSpan duration2 = TimeSpan.Parse("7:00:00");

            var result = (duration1.Hours + ((double)duration1.Minutes / 60)) * rate;
            var result2 = (duration2.Hours + ((double)duration2.Minutes / 60)) * rate2;

            TextIDVan.Text = RoundDownToNearest((double)result, 0.10).ToString("C");
            TextIDVan2.Text = RoundDownToNearest((double)result2, 0.10).ToString("C");
        }

        public static double RoundDownToNearest(double passednumber, double roundto)
        {
            if (roundto == 0)
            {
                return passednumber;
            }
            else
            {
                return Math.Floor(passednumber / roundto) * roundto;
            }
        }

    }
}