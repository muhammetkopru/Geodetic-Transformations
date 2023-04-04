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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            label17.Visible = true;
            groupBox6.Visible = true;

            double a, b, c, e_sqr, e2_sqr;
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
            c = (a * a) / b;
            e_sqr = (a * a - b * b) / (a * a);
            e2_sqr = (a * a - b * b) / (b * b);
            
            double x_p, y_p, z_p, x_k, y_k, z_k;
            x_p = Convert.ToDouble(x.Text);
            y_p = Convert.ToDouble(y.Text);
            z_p = Convert.ToDouble(z.Text);
            x_k = Convert.ToDouble(kx.Text);
            y_k = Convert.ToDouble(ky.Text);
            z_k = Convert.ToDouble(kz.Text);

            double longitude_k = (180 / Math.PI) * (Math.Atan(y_k / x_k));
            double p_k = Math.Sqrt(x_k * x_k + y_p * y_k);
            double latitude_k, beta_k, latitude_degree_k, h_k, N_k;
            beta_k = Math.Atan((a * z_k) / (b * p_k));
            latitude_k = Math.Atan((z_k + e2_sqr * b * Math.Sin(beta_k) * Math.Sin(beta_k) * Math.Sin(beta_k)) / (p_k - e_sqr * a * Math.Cos(beta_k) * Math.Cos(beta_k) * Math.Cos(beta_k)));
            latitude_degree_k = (180 / Math.PI) * latitude_k;
            N_k = a / Math.Sqrt(1 - e_sqr * Math.Sin(latitude_k) * Math.Sin(latitude_k));
            h_k = (p_k / Math.Cos(latitude_k)) - N_k;

            double longitude_p = (180 / Math.PI) * (Math.Atan(y_p / x_p));
            double p_p = Math.Sqrt(x_p * x_p + y_p * y_p);
            double latitude_p, beta_p, latitude_degree_p, h_p, N_p;
            beta_p = Math.Atan((a * z_p) / (b * p_p));
            latitude_p = Math.Atan((z_p + e2_sqr * b * Math.Sin(beta_p) * Math.Sin(beta_p) * Math.Sin(beta_p)) / (p_p - e_sqr * a * Math.Cos(beta_p) * Math.Cos(beta_p) * Math.Cos(beta_p)));
            latitude_degree_p = (180 / Math.PI) * latitude_p;
            N_p = a / Math.Sqrt(1 - e_sqr * Math.Sin(latitude_p) * Math.Sin(latitude_p));
            h_p = (p_p / Math.Cos(latitude_p)) - N_p;


            double xk_local, yk_local, zk_local;
            xk_local = (x_p - x_k) * Math.Sin(latitude_degree_p * (Math.PI / 180)) * Math.Cos(longitude_p * (Math.PI / 180)) - (y_k - y_p) * Math.Sin(latitude_degree_p * (Math.PI / 180)) * Math.Sin(longitude_p * (Math.PI / 180)) + (z_k - z_p) * Math.Cos(latitude_degree_p * (Math.PI / 180));
            yk_local = (x_p - x_k) * Math.Sin(longitude_p * (Math.PI / 180)) + (y_k - y_p) * Math.Cos(longitude_p * (Math.PI / 180));
            zk_local = (x_k - x_p) * Math.Cos(latitude_degree_p * (Math.PI / 180)) * Math.Cos(longitude_p * (Math.PI / 180)) + (y_k - y_p) * Math.Cos(latitude_degree_p * (Math.PI / 180)) * Math.Sin(longitude_p * (Math.PI / 180)) + (z_k - z_p) * Math.Sin(latitude_degree_p * (Math.PI / 180));

            double a_tan = Math.Atan(yk_local / xk_local) * (180 / Math.PI);
            if (yk_local < 0 & xk_local < 0)
            {
                a_tan += 180;
            }
            else if (yk_local > 0 & xk_local < 0)
            {
                a_tan = 180 - a_tan;
            }
            else if (yk_local < 0 & xk_local > 0)
            {
                a_tan = 360 - a_tan;
            }

            double spatial_length = Math.Sqrt(xk_local * xk_local + yk_local * yk_local + zk_local * zk_local);
            double a_cos = Math.Acos(zk_local / spatial_length) * (180 / Math.PI);

            double deg_1 = Math.Floor(a_tan);
            double min_1 = (a_tan - Math.Floor(a_tan)) * 60;
            double sec_1 = (min_1 - Math.Floor(min_1)) * 60;

            double deg_2 = Math.Floor(a_cos);
            double min_2 = (a_cos - Math.Floor(a_cos)) * 60;
            double sec_2 = (min_2 - Math.Floor(min_2)) * 60;


            aa.Text = Convert.ToString(deg_1) + "°" + Convert.ToString(Math.Floor(min_1)) + "'" + Convert.ToString(Math.Floor(sec_1)) + ".''" + Convert.ToString(Math.Floor(10000 * (sec_1 - Math.Floor(sec_1))));
            ba.Text = Convert.ToString(spatial_length);
            ca.Text = Convert.ToString(deg_2) + "°" + Convert.ToString(Math.Floor(min_2)) + "'" + Convert.ToString(Math.Floor(sec_2)) + ".''" + Convert.ToString(Math.Floor(10000 * (sec_2 - Math.Floor(sec_2))));

            x_cartesian.Text = Convert.ToString(xk_local);
            y_cartesian.Text = Convert.ToString(yk_local);
            z_cartesian.Text = Convert.ToString(zk_local);
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
