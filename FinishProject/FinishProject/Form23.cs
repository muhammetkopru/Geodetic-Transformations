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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label26.Visible = true;
            groupBox5.Visible = true;

            double x_p = Convert.ToDouble(x.Text);
            double y_p = Convert.ToDouble(y.Text);
            double z_p = Convert.ToDouble(z.Text);

            double p1 = Convert.ToDouble(parameters1.Text);
            double p2 = Convert.ToDouble(parameters2.Text);
            double p3 = Convert.ToDouble(parameters3.Text);
            if (Second.Checked == true)
            {
                p1 = (p1 * Math.PI) / (180 * 3600);
                p2 = (p2 * Math.PI) / (180 * 3600);
                p3 = (p3 * Math.PI) / (180 * 3600);
            }

            double x_k, y_k, z_k;
            x_k = x_p - y_p * p3 - z_p * p1;
            y_k = x_p * p3 + y_p - z_p * p2;
            z_k = x_p * p1 + y_p * p2 + z_p;

            x_cartesian.Text = Convert.ToString(x_k);
            y_cartesian.Text = Convert.ToString(y_k);
            z_cartesian.Text = Convert.ToString(z_k);
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
