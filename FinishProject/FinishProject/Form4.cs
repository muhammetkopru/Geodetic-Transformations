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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label17.Visible=true;
            groupBox5.Visible = true;

            double astra_latitude = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)  /60 + Convert.ToDouble(textBox3.Text)/3600;
            double astra_longitude = Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox5.Text) /60 + Convert.ToDouble(textBox6.Text)/3600;
            double astra_azimuth = Convert.ToDouble(textBox7.Text) + Convert.ToDouble(textBox8.Text)  / 60 + Convert.ToDouble(textBox9.Text)/3600;
            

            double X_pole = Convert.ToDouble(x_pole.Text);
            double Y_pole = Convert.ToDouble(y_pole.Text);
            if (radioButton4.Checked == true)
            {
                X_pole = (Math.PI * X_pole) * (180 * 3600);
                Y_pole = (Math.PI * Y_pole) * (180 * 3600);
            }

            double coord_3 = (X_pole * Math.Sin(astra_longitude *(Math.PI /180 )) + Y_pole * Math.Cos(astra_longitude *(Math.PI / 180))) / Math.Cos(astra_latitude * (Math.PI / 180));
            double coord_1 = Y_pole*Math.Sin(astra_longitude*(Math.PI/180)) - X_pole*Math.Cos(astra_longitude*(Math.PI/180));
            double coord_2 = (X_pole* Math.Sin(astra_longitude * (Math.PI/180)) + Y_pole* Math.Cos(astra_longitude*(Math.PI/180)))*Math.Tan(astra_latitude * (Math.PI/180));


            av_pole_xp.Text = textBox1.Text + "°" + textBox2.Text + "'" + Convert.ToString(Math.Floor(Convert.ToDouble(textBox3.Text) + coord_1)) + ".''" + Convert.ToString(Math.Floor(10000 * (coord_1 - Math.Floor(coord_1))));
            av_pole_yp.Text = textBox4.Text + "°" + textBox5.Text + "'" + Convert.ToString(Math.Floor(Convert.ToDouble(textBox6.Text) - coord_2)) + ".''" + Convert.ToString(Math.Floor(10000 * (coord_2 - Math.Floor(coord_2))));
            av_pole_zp.Text = textBox7.Text + "°" + textBox8.Text + "'" + Convert.ToString(Math.Floor(Convert.ToDouble(textBox9.Text) - coord_3)) + ".''" + Convert.ToString(Math.Floor(10000 * (coord_3 - Math.Floor(coord_3))));
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

