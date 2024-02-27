using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using Image = System.Drawing.Image;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        UserControl2 usercon = new UserControl2();
        public Form2()
        {
            InitializeComponent();
            flowLayoutPanel2.Hide();
            flowLayoutPanel1.Hide();
           




        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.BringToFront();
            flowLayoutPanel1.Show();
            flowLayoutPanel2.Hide();
            usercon.Hide();
            string con = "server=127.0.0.1;uid=root;pwd=Testing123;database=rhulepisot";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();
            string sql = "SELECT * FROM rhulepisot.user;";
            MySqlCommand cmd = new MySqlCommand(sql, conConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int ctr = 0;
                string name = (string)reader["named"];
                System.Windows.Forms.Button butt = new System.Windows.Forms.Button();

                butt.Location = new Point(100, 100);

                butt.BackColor = System.Drawing.Color.Cornsilk;
                butt.Location = new System.Drawing.Point(-3, 62);
                butt.Name = "butt" + ctr++;
                butt.Size = new System.Drawing.Size(295, 178);
                butt.TabIndex = 1;
                butt.Text = name;
                butt.UseVisualStyleBackColor = false;
                Image i = Image.FromFile("C:\\Users\\user\\Downloads\\1663918001085.jpg");
                butt.Image = i;
                
                butt.Click += new EventHandler(Button_Click);

                
                Form2.ActiveForm.Controls.Add(butt);
                flowLayoutPanel1.Controls.Add(butt);
            

        }

    }

        private void button1_Click(object sender, EventArgs e)
        {
            
            flowLayoutPanel2.BringToFront();
            flowLayoutPanel2.Show();
            flowLayoutPanel1.Hide();
            usercon.Hide();
            string con = "server=127.0.0.1;uid=root;pwd=Testing123;database=rhulepisot";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();
            string sql = "SELECT * FROM rhulepisot.user;";
            MySqlCommand cmd = new MySqlCommand(sql, conConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int ctr = 0;
                string name = (string)reader["named"];
                System.Windows.Forms.Button butt = new System.Windows.Forms.Button();

                butt.Location = new Point(100, 100);

                butt.BackColor = System.Drawing.Color.Cornsilk;
                butt.Location = new System.Drawing.Point(-3, 62);
                butt.Name = "butt" + ctr++;
                butt.Size = new System.Drawing.Size(295, 178);
                butt.TabIndex = 1;
                butt.Text = name;
                butt.UseVisualStyleBackColor = false;
                butt.BackgroundImage = Image.FromFile(@"C:\Users\user\Downloads\1663918001085.jpg");
                butt.Click += new EventHandler(Button_Click);

                


                Form2.ActiveForm.Controls.Add(butt);
                flowLayoutPanel2.Controls.Add(butt);
            

        }

    }   private void Button_Click(object sender1, EventArgs e1)
        {
            flowLayoutPanel1.Hide();
            usercon.Show();
            tableLayoutPanel1.Controls.Add(usercon, 1, 0);
        }

        private void menu1_Load(object sender, EventArgs e)
        {

        }

        

        private void lastTry1_Load(object sender, EventArgs e)
        {

        }
    }

        
    }

        

       
        
    

