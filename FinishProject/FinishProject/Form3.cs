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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            groupBox1.Visible = true;
            double Xp = Convert.ToDouble(xp.Text);
            double Yp = Convert.ToDouble(yp.Text);
            double Zp = Convert.ToDouble(zp.Text);

            double X_pole = Convert.ToDouble(x_pole.Text);
            double Y_pole = Convert.ToDouble(y_pole.Text);

            if (radioButton1.Checked == true)
            {
                X_pole = (Math.PI * X_pole) / (180 * 3600);
                Y_pole = (Math.PI * Y_pole) / (180 * 3600);
            }

            double x_a = Xp - Zp * X_pole;
            double y_a = Yp + Zp * Y_pole;
            double z_a = Xp * X_pole - Yp * Y_pole + Zp;

            av_xp.Text = x_a.ToString();
            av_yp.Text = y_a.ToString();
            av_zp.Text = z_a.ToString();
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
