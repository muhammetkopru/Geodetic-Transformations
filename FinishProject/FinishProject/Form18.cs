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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            label26.Visible = true;

            double a, b, c, e_sqr, e2_sqr, V, M, N, Rpk, gama, omega, duzelt;
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

            double astronomical_latitude = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) / 60 + Convert.ToDouble(textBox3.Text) / 3600;
            double astronomical_longitude = Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox5.Text) / 60 + Convert.ToDouble(textBox6.Text) / 3600;
            double astronomical_azimuth = Convert.ToDouble(textBox7.Text) + Convert.ToDouble(textBox8.Text) / 60 + Convert.ToDouble(textBox9.Text) / 3600;
            double astronomical_height = Convert.ToDouble(textBox10.Text);
            double measured_zenith = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox12.Text) / 60 + Convert.ToDouble(textBox13.Text) / 3600;
            double length = Convert.ToDouble(textBox14.Text);
            double coeff = Convert.ToDouble(textBox15.Text);
            double x_p = Convert.ToDouble(x.Text);
            double y_p = Convert.ToDouble(y.Text);
            double z_p = Convert.ToDouble(z.Text);

            c = (a * a) / b;
            e_sqr = (a * a - b * b) / (a * a);
            e2_sqr = (a * a - b * b) / (b * b);
            V = Math.Sqrt(1 + e2_sqr * Math.Cos(astronomical_latitude * (Math.PI / 180)) * Math.Cos(astronomical_latitude * (Math.PI / 180)));
            M = c / (V * V * V);
            N = c / V;
            Rpk = (M * N) / (N * Math.Cos(astronomical_azimuth * (Math.PI / 180)) * Math.Cos(astronomical_azimuth * (Math.PI / 180)) + M * Math.Sin(astronomical_azimuth * (Math.PI / 180)) * Math.Sin(astronomical_azimuth * (Math.PI / 180)));
            gama = length / (2 * Rpk);
            omega = gama * coeff;
            duzelt = measured_zenith + omega;

            double x_l, y_l, z_l;
            x_l = (length * Math.Sin(duzelt * (Math.PI / 180)) * Math.Cos(astronomical_azimuth * (Math.PI / 180)));
            y_l = (length * Math.Sin(duzelt * (Math.PI / 180)) * Math.Sin(astronomical_azimuth * (Math.PI / 180)));
            z_l = (length * Math.Cos(duzelt * (Math.PI / 180)));

            double x_at, y_at, z_at;
            x_at = x_p - x_l * Math.Sin(astronomical_latitude * (Math.PI / 180)) * Math.Cos(astronomical_longitude * (Math.PI / 180)) - y_l * Math.Sin(astronomical_longitude * (Math.PI / 180)) + z_l * Math.Cos(astronomical_latitude * (Math.PI / 180)) * Math.Cos(astronomical_longitude * (Math.PI / 180));
            y_at = y_p - x_l * Math.Sin(astronomical_latitude * (Math.PI / 180)) * Math.Sin(astronomical_longitude * (Math.PI / 180)) + y_l * Math.Cos(astronomical_longitude * (Math.PI / 180)) + z_l * Math.Cos(astronomical_latitude * (Math.PI / 180)) * Math.Sin(astronomical_longitude * (Math.PI / 180));
            z_at = z_p + x_l * Math.Cos(astronomical_latitude * (Math.PI / 180)) + z_l * Math.Sin(astronomical_latitude * (Math.PI / 180));

            x_cartesian.Text = Convert.ToString(x_at);
            y_cartesian.Text = Convert.ToString(y_at);
            z_cartesian.Text = Convert.ToString(z_at);
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
