namespace FinishProject
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WGS1984 = new System.Windows.Forms.RadioButton();
            this.GRS1980 = new System.Windows.Forms.RadioButton();
            this.Krasovsky1940 = new System.Windows.Forms.RadioButton();
            this.International1924 = new System.Windows.Forms.RadioButton();
            this.Bassel1841 = new System.Windows.Forms.RadioButton();
            this.Clarke1866 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.TextBox();
            this.z = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.z_cartesian = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.y_cartesian = new System.Windows.Forms.Label();
            this.x_cartesian = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the reference ellipsoid you are using.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WGS1984);
            this.groupBox1.Controls.Add(this.GRS1980);
            this.groupBox1.Controls.Add(this.Krasovsky1940);
            this.groupBox1.Controls.Add(this.International1924);
            this.groupBox1.Controls.Add(this.Bassel1841);
            this.groupBox1.Controls.Add(this.Clarke1866);
            this.groupBox1.Location = new System.Drawing.Point(26, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // WGS1984
            // 
            this.WGS1984.AutoSize = true;
            this.WGS1984.Location = new System.Drawing.Point(497, 63);
            this.WGS1984.Name = "WGS1984";
            this.WGS1984.Size = new System.Drawing.Size(91, 20);
            this.WGS1984.TabIndex = 5;
            this.WGS1984.TabStop = true;
            this.WGS1984.Text = "WGS 1984";
            this.WGS1984.UseVisualStyleBackColor = true;
            // 
            // GRS1980
            // 
            this.GRS1980.AutoSize = true;
            this.GRS1980.Location = new System.Drawing.Point(256, 63);
            this.GRS1980.Name = "GRS1980";
            this.GRS1980.Size = new System.Drawing.Size(88, 20);
            this.GRS1980.TabIndex = 4;
            this.GRS1980.TabStop = true;
            this.GRS1980.Text = "GRS 1980";
            this.GRS1980.UseVisualStyleBackColor = true;
            // 
            // Krasovsky1940
            // 
            this.Krasovsky1940.AutoSize = true;
            this.Krasovsky1940.Location = new System.Drawing.Point(21, 63);
            this.Krasovsky1940.Name = "Krasovsky1940";
            this.Krasovsky1940.Size = new System.Drawing.Size(122, 20);
            this.Krasovsky1940.TabIndex = 3;
            this.Krasovsky1940.TabStop = true;
            this.Krasovsky1940.Text = "Krasovsky 1940";
            this.Krasovsky1940.UseVisualStyleBackColor = true;
            // 
            // International1924
            // 
            this.International1924.AutoSize = true;
            this.International1924.Location = new System.Drawing.Point(497, 21);
            this.International1924.Name = "International1924";
            this.International1924.Size = new System.Drawing.Size(131, 20);
            this.International1924.TabIndex = 2;
            this.International1924.TabStop = true;
            this.International1924.Text = "International 1924";
            this.International1924.UseVisualStyleBackColor = true;
            // 
            // Bassel1841
            // 
            this.Bassel1841.AutoSize = true;
            this.Bassel1841.Location = new System.Drawing.Point(256, 21);
            this.Bassel1841.Name = "Bassel1841";
            this.Bassel1841.Size = new System.Drawing.Size(101, 20);
            this.Bassel1841.TabIndex = 1;
            this.Bassel1841.TabStop = true;
            this.Bassel1841.Text = "Bessel 1841";
            this.Bassel1841.UseVisualStyleBackColor = true;
            // 
            // Clarke1866
            // 
            this.Clarke1866.AutoSize = true;
            this.Clarke1866.Location = new System.Drawing.Point(21, 21);
            this.Clarke1866.Name = "Clarke1866";
            this.Clarke1866.Size = new System.Drawing.Size(98, 20);
            this.Clarke1866.TabIndex = 0;
            this.Clarke1866.TabStop = true;
            this.Clarke1866.Text = "Clarke 1866";
            this.Clarke1866.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z:";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(58, 241);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(162, 22);
            this.x.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(682, 41);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter the unit of the ellipsoidal cartesian coordinates on the date of measuremen" +
    "t in meters.";
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(58, 278);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(162, 22);
            this.y.TabIndex = 8;
            // 
            // z
            // 
            this.z.Location = new System.Drawing.Point(58, 318);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(162, 22);
            this.z.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chartreuse;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(353, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 51);
            this.button3.TabIndex = 19;
            this.button3.Text = "Convert";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.z_cartesian);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.y_cartesian);
            this.groupBox3.Controls.Add(this.x_cartesian);
            this.groupBox3.Location = new System.Drawing.Point(26, 484);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 199);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(279, 33);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ellipsoidal Longitude (λ):";
            // 
            // z_cartesian
            // 
            this.z_cartesian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.z_cartesian.Location = new System.Drawing.Point(314, 138);
            this.z_cartesian.Name = "z_cartesian";
            this.z_cartesian.Size = new System.Drawing.Size(365, 33);
            this.z_cartesian.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 33);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ellipsoidal Height (h):";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(5, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(280, 33);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ellipsoidal Latitude (ϕ):";
            // 
            // y_cartesian
            // 
            this.y_cartesian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y_cartesian.Location = new System.Drawing.Point(314, 80);
            this.y_cartesian.Name = "y_cartesian";
            this.y_cartesian.Size = new System.Drawing.Size(365, 33);
            this.y_cartesian.TabIndex = 18;
            // 
            // x_cartesian
            // 
            this.x_cartesian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.x_cartesian.Location = new System.Drawing.Point(314, 18);
            this.x_cartesian.Name = "x_cartesian";
            this.x_cartesian.Size = new System.Drawing.Size(370, 33);
            this.x_cartesian.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(32, 422);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(632, 59);
            this.label17.TabIndex = 27;
            this.label17.Text = "The Curvilinear Coordinates of your point in the reference ellipsoid you specifie" +
    "d are as follows:";
            this.label17.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::FinishProject.Properties.Resources.back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::FinishProject.Properties.Resources.exit_icon;
            this.pictureBox2.Location = new System.Drawing.Point(745, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 953);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.z);
            this.Controls.Add(this.y);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton WGS1984;
        private System.Windows.Forms.RadioButton GRS1980;
        private System.Windows.Forms.RadioButton Krasovsky1940;
        private System.Windows.Forms.RadioButton International1924;
        private System.Windows.Forms.RadioButton Bassel1841;
        private System.Windows.Forms.RadioButton Clarke1866;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.TextBox z;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label z_cartesian;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label y_cartesian;
        private System.Windows.Forms.Label x_cartesian;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}