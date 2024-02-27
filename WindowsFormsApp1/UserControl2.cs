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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void order_Click(object sender, EventArgs e)
        {
            string prodname = name.Text;
            string prodquan = quantity.Text;
            string prodsie = size.Text;

            name.Text = "";
            quantity.Text = "";
            size.Text = "";
            string con = "server=127.0.0.1;uid=root;pwd=Testing123;database=rhulepisot";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();

            string insertSql = "INSERT INTO rhulepisot.food (name, quantity, size) VALUES (?, ?, ?)";
            MySqlCommand insertCmd = new MySqlCommand(insertSql, conConn);

            insertCmd.Parameters.AddWithValue("@name", prodname);
            insertCmd.Parameters.AddWithValue("@quantity", prodquan);
            insertCmd.Parameters.AddWithValue("@size", prodsie);

            insertCmd.ExecuteNonQuery();

            conConn.Close();
        }
    }
}
