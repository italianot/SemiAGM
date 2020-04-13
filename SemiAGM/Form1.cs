using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemiAGM
{
    public partial class Form1 : Form
    {
        List<Weather> weatherList = new List<Weather>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.weatherList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.weatherList.Add(Sun.Generate());
                        break;
                    case 1:
                        this.weatherList.Add(Rain.Generate());
                        break;
                    case 2:
                        this.weatherList.Add(Snow.Generate());
                        break;
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int sunCount = 0;
            int rainCount = 0;
            int snowCount = 0;

            foreach (var weather in this.weatherList)
            {
                if (weather is Sun)
                {
                    sunCount += 1;
                }
                else if (weather is Rain)
                {
                    rainCount += 1;
                }
                else if (weather is Snow)
                {
                    snowCount += 1;
                }
            }

            txtInfo.Text = "Солнце\tДождь\tСнег";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", sunCount, rainCount, snowCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.weatherList.Count == 0)
            {
                txtOut.Text = "Прогноза не будет (ಥ﹏ಥ)";
                return;
            }

            var weather = this.weatherList[0];
            this.weatherList.RemoveAt(0);

            txtOut.Text = weather.GetInfo();

            ShowInfo();
        }
    }
}
