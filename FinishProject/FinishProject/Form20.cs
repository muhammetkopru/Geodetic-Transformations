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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            label26.Visible = true;
            groupBox6.Visible = true;   

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
            double p1 = Convert.ToDouble(parameters1.Text);
            double p2 = Convert.ToDouble(parameters2.Text);

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
                        
            if (Second.Checked == true)
            {
                p1 = p1/ 3600;
                p2 = p2/ 3600;
            }
            if (Radian.Checked == true)
            {
                p1 = p1 * (180 / Math.PI);
                p2 = p2 * (180 / Math.PI);
            }

            double re_duzelt = duzelt + (p1* Math.Cos(astronomical_azimuth * (Math.PI / 180)) + p2* Math.Sin(astronomical_azimuth * (Math.PI / 180)));

            double x_lg, y_lg, z_lg;
            x_lg = length * Math.Sin(re_duzelt * (Math.PI / 180)) * Math.Cos(astronomical_azimuth * (Math.PI / 180));
            y_lg = length * Math.Sin(re_duzelt * (Math.PI / 180)) * Math.Sin(astronomical_azimuth * (Math.PI / 180));
            z_lg = length * Math.Cos(re_duzelt * (Math.PI / 180));

            x_cartesian.Text = Convert.ToString(x_lg);
            y_cartesian.Text = Convert.ToString(y_lg);
            z_cartesian.Text = Convert.ToString(z_lg);

            xl.Text = Convert.ToString(x_p - x_lg * Math.Sin(astronomical_latitude * (Math.PI / 180)) * Math.Cos(astronomical_longitude * (Math.PI / 180)) - y_lg * Math.Sin(astronomical_longitude * (Math.PI / 180)) + z_lg * Math.Cos(astronomical_latitude * (Math.PI / 180)) * Math.Cos(astronomical_longitude * (Math.PI / 180)));
            yl.Text = Convert.ToString(y_p - x_lg * Math.Sin(astronomical_latitude * (Math.PI / 180)) * Math.Sin(astronomical_longitude * (Math.PI / 180)) + y_lg * Math.Cos(astronomical_longitude * (Math.PI / 180)) + z_lg * Math.Cos(astronomical_latitude * (Math.PI / 180)) * Math.Sin(astronomical_longitude * (Math.PI / 180)));
            zl.Text = Convert.ToString(z_p + x_lg * Math.Cos(astronomical_latitude * (Math.PI / 180)) + z_lg * Math.Sin(astronomical_latitude * (Math.PI / 180)));



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
            this.Hide();
        }
    }
}
