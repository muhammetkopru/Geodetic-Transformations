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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            groupBox3.Visible = true;
            label26.Visible = true;

            double astronomical_latitude = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) / 60 + Convert.ToDouble(textBox3.Text) / 3600;
            double astronomical_longitude = Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox5.Text) / 60 + Convert.ToDouble(textBox6.Text) / 3600;
            double astronomical_height = Convert.ToDouble(textBox10.Text);
            double x_p = Convert.ToDouble(x.Text);
            double y_p = Convert.ToDouble(y.Text);
            double z_p = Convert.ToDouble(z.Text);
            double x_k = Convert.ToDouble(kx.Text);
            double y_k = Convert.ToDouble(ky.Text);
            double z_k = Convert.ToDouble(kz.Text);

            double xk_local, yk_local, zk_local;
            xk_local = (x_p - x_k) * Math.Sin(astronomical_latitude * (Math.PI / 180)) * Math.Cos(astronomical_longitude * (Math.PI / 180)) - (y_k - y_p) * Math.Sin(astronomical_latitude * (Math.PI / 180)) * Math.Sin(astronomical_longitude * (Math.PI / 180)) + (z_k - z_p) * Math.Cos(astronomical_latitude * (Math.PI / 180));
            yk_local = (x_p - x_k) * Math.Sin(astronomical_longitude * (Math.PI / 180)) + (y_k - y_p) * Math.Cos(astronomical_longitude * (Math.PI / 180));
            zk_local = (x_k - x_p) * Math.Cos(astronomical_latitude * (Math.PI / 180)) * Math.Cos(astronomical_longitude * (Math.PI / 180)) + (y_k - y_p) * Math.Cos(astronomical_latitude * (Math.PI / 180)) * Math.Sin(astronomical_longitude * (Math.PI / 180)) + (z_k - z_p) * Math.Sin(astronomical_latitude * (Math.PI / 180));

            double a_tan = Math.Atan(yk_local / xk_local) * (180 / Math.PI);
            if (yk_local < 0 & xk_local<0 )
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


            a.Text = Convert.ToString(deg_1) + "°" + Convert.ToString(Math.Floor(min_1)) + "'" + Convert.ToString(Math.Floor(sec_1)) + ".''" + Convert.ToString(Math.Floor(10000 * (sec_1 - Math.Floor(sec_1))));
            b.Text = Convert.ToString(spatial_length);
            c.Text = Convert.ToString(deg_2) + "°" + Convert.ToString(Math.Floor(min_2)) + "'" + Convert.ToString(Math.Floor(sec_2)) + ".''" + Convert.ToString(Math.Floor(10000 * (sec_2 - Math.Floor(sec_2))));

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
