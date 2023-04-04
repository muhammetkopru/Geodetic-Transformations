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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            label2.Visible = false;
            comboBox2.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "The Instantaneous Terrestrial Coordinate System" & comboBox2.Text == "The Average Terrestrial Coordinate System")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            if (comboBox1.Text == "The Average Terrestrial Coordinate System" & comboBox2.Text == "The Instantaneous Terrestrial Coordinate System")
            {
                Form3 form3 = new Form3();
                form3.Show();   
                Hide();
            }
            if (comboBox1.Text == "Astronomical Latitude, Longitude and Azimuth On The Instantaneous Coordinate System" & comboBox2.Text == "Reduction To Average Pole Coordinate System")
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Ellipsoidal Curvilinear Coordinates" & comboBox2.Text == "Ellipsoidal Cartesian Coordinates")
            {
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
            }
            if(comboBox1.Text == "Ellipsoidal Cartesian Coordinates" & comboBox2.Text== "Ellipsoidal Curvilinear Coordinates With Iteration")
            {
                Form6 form6 = new Form6();
                form6.Show();
                this.Hide();
            }
            if(comboBox1.Text == "Ellipsoidal Cartesian Coordinates" & comboBox2.Text == "Ellipsoidal Curvilinear Coordinates With Direct Solution")
            {
                Form7 form7 = new Form7();
                form7.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Ellipsoidal Cartesian Coordinates" & comboBox2.Text == "The Average Terrestrial Coordinate System")
            {
                Form8 form8 = new Form8();
                form8.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Ellipsoidal Cartesian Coordinates" & comboBox2.Text == "The Instantaneous Terrestrial Coordinate System")
            {
                Form9 form9 = new Form9();
                form9.Show();
                this.Hide();
            }
            if (comboBox1.Text == "The Average Terrestrial Coordinate System" & comboBox2.Text == "Ellipsoidal Cartesian Coordinates")
            {
                Form10 form10 = new Form10();
                form10.Show();
                this.Hide();
            }
            if (comboBox1.Text == "The Average Terrestrial Coordinate System" & comboBox2.Text == "Ellipsoidal Curvilinear Coordinates")
            {
                Form11 form11 = new Form11();
                form11.Show();
                this.Hide();
            }
            if (comboBox1.Text == "The Instantaneous Terrestrial Coordinate System" & comboBox2.Text == "Ellipsoidal Cartesian Coordinates")
            {
                Form12 form12 = new Form12();
                form12.Show();
                this.Hide();
            }
            if (comboBox1.Text == "The Instantaneous Terrestrial Coordinate System" & comboBox2.Text == "Ellipsoidal Curvilinear Coordinates")
            {
                Form13 form13= new Form13();
                form13.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Ellipsoidal Curvilinear Coordinates" & comboBox2.Text == "The Average Terrestrial Coordinate System")
            {
                Form15 form15 = new Form15();
                form15.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Ellipsoidal Curvilinear Coordinates" & comboBox2.Text == "The Instantaneous Terrestrial Coordinate System")
            {
                Form14 form14 = new Form14();
                form14.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Astronomical Latitude, Longitude, Azimuth and Ellipsoidal Latitude, Longitude, Azimuth" & comboBox2.Text == "Plumb Diversion Parameters and Geoid Height")
            {
                Form16 form16 = new Form16();
                form16.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Local Astronomical System Created at Point P on the Topography" & comboBox2.Text == "Local Astronomical Coordinates Of Point K With Spatial Length, Azimuth and Zenith")
            {
                Form17 form17 = new Form17();
                form17.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Local Astronomical System Created at Point P on the Topography" & comboBox2.Text == "Average Terrestrial Coordinates of Point K With Spatial Length, Azimuth and Zenith")
            {
                Form18 form18 = new Form18();
                form18.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Local Astronomical System Created at Point P on the Topography" & comboBox2.Text == "Local Astronomical Coordinates and Parameters Of Point K Known Average Terrestrial Coordinates")
            {
                Form19 form19 = new Form19();
                form19.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Local Geodetic System Created at Point P on the Topography" & comboBox2.Text== "Local Geodetic and Ellipsoidal Cartesian Coordinates Of Point K with Spatial Length, Azimuth and Zenith")
            {
                Form20 form20 = new Form20();
                form20.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Local Geodetic System Created at Point P on the Topography" & comboBox2.Text == "Local Geodetic Coordinates and Parameters Of Point K With Cartesian Coordinates of Points P and K")
            {
                Form21 form21 = new Form21();
                form21.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Local Astronomical System Created at Point P on the Topography" & comboBox2.Text == "Local Geodetic Coordinates of Point K on the Topography")
            {
                Form22 form22 = new Form22();
                form22.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Local Geodetic System Created at Point P on the Topography" & comboBox2.Text == "Local Astronomic Coordinates of Point K on the Topography")
            {
                Form23 form23 = new Form23();
                form23.Show();
                this.Hide();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Astronomical Latitude, Longitude and Azimuth On The Instantaneous Coordinate System")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Reduction To Average Pole Coordinate System");
            }
            if(comboBox1.Text == "Ellipsoidal Curvilinear Coordinates")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Ellipsoidal Cartesian Coordinates");
                comboBox2.Items.Add("The Average Terrestrial Coordinate System");
                comboBox2.Items.Add("The Instantaneous Terrestrial Coordinate System");

            }
            if(comboBox1.Text== "Ellipsoidal Cartesian Coordinates")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Ellipsoidal Curvilinear Coordinates With Iteration");
                comboBox2.Items.Add("Ellipsoidal Curvilinear Coordinates With Direct Solution");
                comboBox2.Items.Add("The Average Terrestrial Coordinate System");
                comboBox2.Items.Add("The Instantaneous Terrestrial Coordinate System");
            }
            if (comboBox1.Text == "The Average Terrestrial Coordinate System")
            {
                comboBox2.Items.Add("Ellipsoidal Cartesian Coordinates");
                comboBox2.Items.Add("Ellipsoidal Curvilinear Coordinates");
            }
            if (comboBox1.Text == "The Instantaneous Terrestrial Coordinate System")
            {
                comboBox2.Items.Add("Ellipsoidal Cartesian Coordinates");
                comboBox2.Items.Add("Ellipsoidal Curvilinear Coordinates");
            }
            if (comboBox1.Text == "Astronomical Latitude, Longitude, Azimuth and Ellipsoidal Latitude, Longitude, Azimuth")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Plumb Diversion Parameters and Geoid Height");
            }
            if (comboBox1.Text== "Local Astronomical System Created at Point P on the Topography")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Local Astronomical Coordinates Of Point K With Spatial Length, Azimuth and Zenith");
                comboBox2.Items.Add("Average Terrestrial Coordinates of Point K With Spatial Length, Azimuth and Zenith");
                comboBox2.Items.Add("Local Astronomical Coordinates and Parameters Of Point K Known Average Terrestrial Coordinates");
                comboBox2.Items.Add("Local Geodetic Coordinates of Point K on the Topography");
            }
            if (comboBox1.Text == "Local Geodetic System Created at Point P on the Topography")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Local Geodetic and Ellipsoidal Cartesian Coordinates Of Point K with Spatial Length, Azimuth and Zenith");
                comboBox2.Items.Add("Local Geodetic Coordinates and Parameters Of Point K With Cartesian Coordinates of Points P and K");
                comboBox2.Items.Add("Local Astronomic Coordinates of Point K on the Topography");
            }
           
            label2.Visible=true;
            comboBox2.Visible=true;
            button3.Visible=true;
            comboBox2.Items.Remove(comboBox1.SelectedItem);
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible=true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
