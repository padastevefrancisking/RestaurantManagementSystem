using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Guis
{
    public partial class Form1 : Form
    {
        //TODO
        // IMPLEMENT TEXT GUIDE
        // VIDEO

        //jesus lord above this is scuffed

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            //This block of code cost me 3 hrs
            OrderLabel.cornerRadius = 40;
            OrderLabel.borderWidth = 2;
            OrderLabel.borderColor = Color.White;
            OrderLabel.Parent = pictureBox2;
            OrderLabel.BackColor = Color.Transparent;

            label2.Parent = pictureBox3;
            label2.BackColor = Color.Transparent;

            pictureBox4.Parent = pictureBox3;
            pictureBox4.BackColor = Color.Transparent;

            button1.Parent = pictureBox2;
            button1.BackColor = Color.Transparent;

            pictureBox6.Parent = pictureBox1;
            pictureBox6.BackColor = Color.Transparent;

        }

        

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Color top = Color.FromArgb(255, 19, 61, 35);
            Color bottom = Color.FromArgb(255, 34,78 ,54);
            LinearGradientMode direction = LinearGradientMode.Vertical;
            LinearGradientBrush brush = new LinearGradientBrush(pictureBox1.ClientRectangle, top, bottom, direction);

            e.Graphics.FillRectangle(brush, pictureBox1.ClientRectangle);
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {

            Color top = Color.FromArgb(255, 34, 78, 54);
            Color bottom = Color.FromArgb(255, 25, 25, 25);
            LinearGradientMode direction = LinearGradientMode.Vertical;
            LinearGradientBrush brush = new LinearGradientBrush(pictureBox2.ClientRectangle, top, bottom, direction);

            e.Graphics.FillRectangle(brush, pictureBox2.ClientRectangle);
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {

            Color up = Color.FromArgb(255, 39, 63, 26);
            Color down = Color.FromArgb(255, 45, 82, 50);
            LinearGradientMode direction = LinearGradientMode.Vertical;
            LinearGradientBrush brush = new LinearGradientBrush(pictureBox3.ClientRectangle, up, down, direction);

            e.Graphics.FillRectangle(brush, pictureBox3.ClientRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I AM HERE");
        }

      
    }
}
