using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinishProject
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            label17.Visible = true;

            double a, b, e_sqr, e2_sqr;
            a = 2;
            b = 2;
            if (Clarke1866.Checked == true)
            {
                a = 6378206.4;
                b = 6356583.8;
                //divide_f = 294.9786982;           
            }
            if (Bassel1841.Checked == true)
            {
                a = 6377397.155;
                b = 6356078.965;
                //divide_f = 299.1528434;
            }
            if (International1924.Checked == true)
            {
                a = 6378388;
                b = 6356911.9461;
                //divide_f = 296.9993621;
            }
            if (Krasovsky1940.Checked == true)
            {
                a = 6378245;
                b = 6356863;
                //divide_f = 298.2997381;
            }
            if (GRS1980.Checked == true)
            {
                a = 6378137;
                b = 6356752.3141;
                //divide_f = 298.257222101;
            }
            if (WGS1984.Checked == true)
            {
                a = 6378137;
                b = 6356752.3142;
                //divide_f = 298.257223563;
            }
            e_sqr = (a * a - b * b) / (a * a);
            e2_sqr = (a * a - b * b) / (b * b);

            double x_coor = Convert.ToDouble(x.Text);
            double y_coor = Convert.ToDouble(y.Text);
            double z_coor = Convert.ToDouble(z.Text);

            double longitude = (180 / Math.PI) * (Math.Atan(y_coor / x_coor));
            double p = Math.Sqrt(x_coor * x_coor + y_coor * y_coor);

            double latitude, beta, latitude_degree, h, N;
            beta = Math.Atan((a*z_coor)/(b*p)) ;
            latitude = Math.Atan((z_coor+e2_sqr*b*Math.Sin(beta) * Math.Sin(beta) * Math.Sin(beta))/(p-e_sqr*a*Math.Cos(beta) * Math.Cos(beta) * Math.Cos(beta)));
            latitude_degree = (180 / Math.PI) * latitude;
            N= a / Math.Sqrt(1 - e_sqr * Math.Sin(latitude) * Math.Sin(latitude));
            h = (p/Math.Cos(latitude))-N;

            double deg_1 = Math.Floor(latitude_degree);
            double min_1 = (latitude_degree - Math.Floor(latitude_degree)) * 60;
            double sec_1 = (min_1 - Math.Floor(min_1)) * 60;

            double deg_2 = Math.Floor(longitude);
            double min_2 = (longitude - Math.Floor(longitude)) * 60;
            double sec_2 = (min_2 - Math.Floor(min_2)) * 60;


            x_cartesian.Text = Convert.ToString(deg_1) + "°" + Convert.ToString(Math.Floor(min_1)) + "'" + Convert.ToString(Math.Floor(sec_1)) + ".''" + Convert.ToString(Math.Floor(10000 * (sec_1 - Math.Floor(sec_1))));
            y_cartesian.Text = Convert.ToString(deg_2) + "°" + Convert.ToString(Math.Floor(min_2)) + "'" + Convert.ToString(Math.Floor(sec_2)) + ".''" + Convert.ToString(Math.Floor(10000 * (sec_2 - Math.Floor(sec_2))));
            z_cartesian.Text = Convert.ToString(h);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
