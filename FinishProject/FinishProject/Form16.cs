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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label31.Visible = true;
            groupBox5.Visible = true;

            double a_lat, a_long, a_azi, a_h, e_lat, e_long, e_azi, e_h;
            a_lat = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) / 60 + Convert.ToDouble(textBox3.Text) / 3600;
            a_long = Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox5.Text) / 60 + Convert.ToDouble(textBox6.Text) / 3600;
            a_azi = Convert.ToDouble(textBox7.Text) + Convert.ToDouble(textBox8.Text) / 60 + Convert.ToDouble(textBox9.Text) / 3600;
            a_h = Convert.ToDouble(textBox10.Text);
            e_lat = Convert.ToDouble(textBox20.Text) + Convert.ToDouble(textBox19.Text) / 60 + Convert.ToDouble(textBox18.Text) / 3600;
            e_long = Convert.ToDouble(textBox17.Text) + Convert.ToDouble(textBox16.Text) / 60 + Convert.ToDouble(textBox15.Text) / 3600;
            e_azi = Convert.ToDouble(textBox14.Text) + Convert.ToDouble(textBox13.Text) / 60 + Convert.ToDouble(textBox12.Text) / 3600;
            e_h = Convert.ToDouble(textBox11.Text);

            double first = Math.Abs(a_lat - e_lat);
            double deg_1 = Math.Floor(first);
            double min_1 = (first - Math.Floor(first)) * 60;
            double sec_1 = (min_1 - Math.Floor(min_1)) * 60;

            double sec = Math.Abs((a_long - e_long) * Math.Cos(e_lat * ((Math.PI / 180))));
            double deg_2 = Math.Floor(sec);
            double min_2 = (sec - Math.Floor(sec)) * 60;
            double sec_2 = (min_2 - Math.Floor(min_2)) * 60;

            double thi = Math.Abs((a_azi-e_azi)/Math.Tan((Math.PI / 180)*e_lat));
            double deg_3 = Math.Floor(thi);
            double min_3 = (sec - Math.Floor(thi)) * 60;
            double sec_3 = (min_3 - Math.Floor(min_3)) * 60;


            label32.Text = Convert.ToString(deg_1) + "°" + Convert.ToString(Math.Floor(min_1)) + "'" + Convert.ToString(Math.Floor(sec_1)) + ".''" + Convert.ToString(Math.Floor(10000 * (sec_1 - Math.Floor(sec_1))));
            label33.Text = Convert.ToString(deg_2) + "°" + Convert.ToString(Math.Floor(min_2)) + "'" + Convert.ToString(Math.Floor(sec_2)) + ".''" + Convert.ToString(Math.Floor(10000 * (sec_2 - Math.Floor(sec_2))));
            label34.Text = Convert.ToString(deg_3) + "°" + Convert.ToString(Math.Floor(min_3)) + "'" + Convert.ToString(Math.Floor(sec_3)) + ".''" + Convert.ToString(Math.Floor(10000 * (sec_3 - Math.Floor(sec_3))));
            label35.Text = Convert.ToString(e_h - a_h);

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
