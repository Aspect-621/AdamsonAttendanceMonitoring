using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static Monitoring.Attendance;

namespace Monitoring
{
    partial class ClassReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassReport));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            label22 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            pictureBox7 = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            pictureBox9 = new PictureBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            pictureBox16 = new PictureBox();
            label24 = new Label();
            label14 = new Label();
            pictureBox10 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label11 = new Label();
            pictureBox14 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightBlue;
            pictureBox2.Location = new Point(0, 52);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 310);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 98);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(134, 43);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.LightBlue;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(53, 43);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 13);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 8;
            label1.Text = "Courses";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(10, 145);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(159, 43);
            panel2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(59, 12);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 16;
            label2.Text = "Attendance";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.LightBlue;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightBlue;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(label22);
            panel4.Location = new Point(10, 192);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(159, 43);
            panel4.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightBlue;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(55, 12);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 18;
            label3.Text = "Class Report";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.LightBlue;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.MintCream;
            label22.Location = new Point(171, 15);
            label22.Name = "label22";
            label22.Size = new Size(103, 15);
            label22.TabIndex = 44;
            label22.Text = "Becina, Cyrill John";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightBlue;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(10, 239);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(159, 43);
            panel3.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightBlue;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(56, 12);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 19;
            label5.Text = "Total Report";
            label5.Click += label5_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.LightBlue;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(53, 43);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 19;
            pictureBox7.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MintCream;
            label4.Location = new Point(171, 15);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 44;
            label4.Text = "Becina, Cyrill John";
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightBlue;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pictureBox8);
            panel5.Location = new Point(10, 286);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(159, 45);
            panel5.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightBlue;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(59, 10);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 13;
            label6.Text = "Sign Out";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.LightBlue;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(0, 0);
            pictureBox8.Margin = new Padding(3, 2, 3, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(53, 43);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 8;
            pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightBlue;
            pictureBox3.Location = new Point(172, -1);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(527, 55);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightBlue;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(318, 7);
            label7.Name = "label7";
            label7.Size = new Size(222, 32);
            label7.TabIndex = 21;
            label7.Text = "NAME OF COURSE";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(262, 70);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(107, 23);
            dateTimePicker1.TabIndex = 25;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.SteelBlue;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(242, 70);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(23, 18);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 24;
            pictureBox9.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(206, 70);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 23;
            label8.Text = "Date:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "APPLICATIONS DEVT LAB", "APPLICATIONS DEVT LEC", "COMPUTER PROG LAB", "COMPUTER PROG LEC", "OBJECT ORIENTED PROG LAB", "OBJECT ORIENTED PROG LEC" });
            comboBox1.Location = new Point(545, 68);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(119, 23);
            comboBox1.TabIndex = 27;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(500, 70);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 26;
            label9.Text = "Class:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.MintCream;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(347, 111);
            label10.Name = "label10";
            label10.Size = new Size(62, 13);
            label10.TabIndex = 56;
            label10.Text = "Student ID";
            // 
            // pictureBox16
            // 
            pictureBox16.BackColor = Color.MintCream;
            pictureBox16.Location = new Point(315, 110);
            pictureBox16.Margin = new Padding(3, 2, 3, 2);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(125, 15);
            pictureBox16.TabIndex = 55;
            pictureBox16.TabStop = false;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.MintCream;
            label24.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(647, 112);
            label24.Name = "label24";
            label24.Size = new Size(0, 13);
            label24.TabIndex = 60;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.MintCream;
            label14.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(205, 111);
            label14.Name = "label14";
            label14.Size = new Size(80, 13);
            label14.TabIndex = 50;
            label14.Text = "Student Name";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.MintCream;
            pictureBox10.Location = new Point(180, 110);
            pictureBox10.Margin = new Padding(3, 2, 3, 2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(131, 15);
            pictureBox10.TabIndex = 49;
            pictureBox10.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(181, 130);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(513, 225);
            flowLayoutPanel1.TabIndex = 61;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.MintCream;
            label11.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(545, 110);
            label11.Name = "label11";
            label11.Size = new Size(39, 13);
            label11.TabIndex = 66;
            label11.Text = "Status";
            label11.Click += label11_Click_1;
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.MintCream;
            pictureBox14.Location = new Point(446, 110);
            pictureBox14.Margin = new Padding(3, 2, 3, 2);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(249, 15);
            pictureBox14.TabIndex = 65;
            pictureBox14.TabStop = false;
            // 
            // ClassReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(700, 364);
            Controls.Add(label11);
            Controls.Add(pictureBox14);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label10);
            Controls.Add(pictureBox16);
            Controls.Add(label24);
            Controls.Add(label14);
            Controls.Add(pictureBox10);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox3);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClassReport";
            Text = "ClassReport";
            Load += ClassReport_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox6;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label label2;
        private Panel panel4;
        private Label label22;
        private PictureBox pictureBox5;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private PictureBox pictureBox7;
        private Label label5;
        private Panel panel5;
        private PictureBox pictureBox8;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox9;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox16;
        private Label label24;
        private Label label14;
        private PictureBox pictureBox10;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
    }
}