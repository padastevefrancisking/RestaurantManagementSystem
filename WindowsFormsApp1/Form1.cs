using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {
           

                string f = "C:\\Users\\user\\Downloads\\video (2160p).mp4";
                axWindowsMediaPlayer1.URL = f;

                axWindowsMediaPlayer1.uiMode = "none";
                //axWindowsMediaPlayer1.fullScreen = true;
                axWindowsMediaPlayer1.settings.autoStart = true;
                axWindowsMediaPlayer1.settings.setMode("loop", true);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();

        }
    }
}
