using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SK_Cellular.DB;
namespace SK_Cellular.Items
{
    public partial class Add_Item : Form
    {
        public Add_Item()
        {
            InitializeComponent();
            //SqlDataAdapter adapter = new SqlDataAdapter(@"select Cat_Name from Category", connectDB.getConnection());
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mainDB"].ConnectionString);

            SqlCommand sc = new SqlCommand("select Cat_Name from Category", conn);
            DataSet ds = new DataSet();

            SqlDataReader reader;

            //adapter.Fill(ds);
            string a = "11";
            conn.Open();
            reader = sc.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(0));
            }
            conn.Close();
            //comboBox1.DataSource = ds.Tables["Cat_Name"];

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
