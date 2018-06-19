using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SK_Cellular
{
    public partial class Dashboard : Form
    {
        private int childFormNumber = 0;

        public Dashboard()
        {
            InitializeComponent();
        }

        //private void ShowNewForm(object sender, EventArgs e)
        //{
        //    Form childForm = new Form();
        //    childForm.MdiParent = this;
        //    childForm.Text = "Window " + childFormNumber++;
        //    childForm.Show();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //panel1.Hide();
            //products pro = new products();
            //pro.MdiParent = this;
            //pro.Show();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login lg = new Login();
            lg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //panel1.Hide();
            //LoginRegistration lr = new LoginRegistration();
            //lr.MdiParent = this;
            //lr.Show();

        }
    }
}
