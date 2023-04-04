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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            label17.Visible = true;

            double a, b, c, e_sqr, e2_sqr, V, W, N;
            a = 2;
            b = 2;
            if (Clarke1866.Checked == true)
            {
                a = 6378206.4;
                b = 6356583.8;
                //divide_f = 294.9786982;           
            }
            if(Bassel1841.Checked == true)
            {
                a = 6377397.155;
                b = 6356078.965;
                //divide_f = 299.1528434;
            }
            if(International1924.Checked == true)
            {
                a = 6378388;
                b = 6356911.9461;
                //divide_f = 296.9993621;
            }
            if(Krasovsky1940.Checked == true)
            {
                a = 6378245;
                b = 6356863;
                //divide_f = 298.2997381;
            }
            if(GRS1980.Checked == true)
            {
                a = 6378137;
                b = 6356752.3141;
                //divide_f = 298.257222101;
            }
            if(WGS1984.Checked == true)
            {
                a = 6378137;
                b = 6356752.3142;
                //divide_f = 298.257223563;
            }

            double ellipsoidal_latitude = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) / 60 + Convert.ToDouble(textBox3.Text) / 3600;
            double ellipsoidal_longitude = Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox5.Text) / 60 + Convert.ToDouble(textBox6.Text) / 3600;
            double height = Convert.ToDouble(textBox7.Text);

            c = (a * a) /b;
            e_sqr = (a * a - b * b) / (a * a);
            e2_sqr = (a * a - b * b) / (b * b);
            V=Math.Sqrt(1 + e2_sqr * Math.Cos(ellipsoidal_latitude*(Math.PI/180)) * Math.Cos(ellipsoidal_latitude * (Math.PI / 180)));
            W=Math.Sqrt(1 - e_sqr * Math.Sin(ellipsoidal_latitude * (Math.PI / 180)) * Math.Sin(ellipsoidal_latitude * (Math.PI / 180)));
            N = a / W;


            double x,y,z;
            x = (N + height) * Math.Cos(ellipsoidal_latitude * (Math.PI / 180)) * Math.Cos(ellipsoidal_longitude * (Math.PI / 180));
            y = (N + height) * Math.Cos(ellipsoidal_latitude * (Math.PI / 180)) * Math.Sin(ellipsoidal_longitude * (Math.PI / 180));
            z = Math.Sin(ellipsoidal_latitude * (Math.PI / 180))*(N-N*e_sqr+height);

            x_cartesian.Text=Convert.ToString(x);
            y_cartesian.Text=Convert.ToString(y);
            z_cartesian.Text=Convert.ToString(z);

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
