using MySql.Data.MySqlClient;
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
    public partial class LastTry : UserControl
    {
        public LastTry()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hello()
        {
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
                Button butt = new Button();

                butt.Location = new Point(100, 100);

                butt.BackColor = System.Drawing.Color.Cornsilk;
                butt.Location = new System.Drawing.Point(-3, 62);
                butt.Name = "butt" + ctr++;
                butt.Size = new System.Drawing.Size(295, 178);
                butt.TabIndex = 1;
                butt.Text = name;
                butt.UseVisualStyleBackColor = false;


                Form2.ActiveForm.Controls.Add(butt);
                flowLayoutPanel2.Controls.Add(butt);
            }


        }
    }
}
