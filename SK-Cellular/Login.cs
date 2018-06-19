using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SK_Cellular
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox1.Text = "admin";
            textBox2.Text = "admin@123";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-B76CUCU\SAMEESQL;Initial Catalog=stock;Integrated Security=True");
            //SqlDataAdapter adapter = new SqlDataAdapter(@"select * from login s 
            //    where s.username='" + textBox1.Text + "'and s.password = '" + textBox2.Text + "'", conn);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //if (dt.Rows.Count == 1)
            //{
            //    Dashboard sdash = new Dashboard();
            //    sdash.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid UserName and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Show();
               
            //}
        }
    }
}
