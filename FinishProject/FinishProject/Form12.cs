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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label17.Visible = true;
            groupBox5.Visible = true;

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
            double f_0 = Convert.ToDouble(f.Text);

            double x_00 = Convert.ToDouble(x0.Text);
            double y_00 = Convert.ToDouble(y0.Text);
            double z_00 = Convert.ToDouble(z0.Text);

            double e_x = Convert.ToDouble(ep_x.Text);
            double e_y = Convert.ToDouble(ep_y.Text);
            double e_z = Convert.ToDouble(ep_z.Text);
            if (Second.Checked == true)
            {
                e_x = (e_x * Math.PI) / (180 * 3600);
                e_y = (e_y * Math.PI) / (180 * 3600);
                e_z = (e_z * Math.PI) / (180 * 3600);
            }

            double X_pole = Convert.ToDouble(x_pole.Text);
            double Y_pole = Convert.ToDouble(y_pole.Text);
            if (radioButton3.Checked == true)
            {
                X_pole = (Math.PI * X_pole) / (180 * 3600);
                Y_pole = (Math.PI * Y_pole) / (180 * 3600);
            }

            double x_av = x_coor + z_coor * X_pole;
            double y_av = y_coor - z_coor * Y_pole;
            double z_av = -(x_coor * X_pole) + y_coor * Y_pole + z_coor;

            double x_a, y_a, z_a, x_x0, y_y0, z_z0;
            x_x0 = x_av - x_00;
            y_y0 = y_av - y_00;
            z_z0 = z_av - z_00;

            x_a = x_x0 / (1 + f_0) - y_y0 * e_z + z_z0 * e_y;
            y_a = x_x0 * e_z + y_y0 / (1 + f_0) - z_z0 * e_x;
            z_a = y_y0 * e_x - x_x0 * e_y + z_z0 / (1 + f_0);

            x_cartesian.Text = Convert.ToString(x_a);
            y_cartesian.Text = Convert.ToString(y_a);
            z_cartesian.Text = Convert.ToString(z_a);
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
