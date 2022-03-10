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

namespace bibgui
{
    public partial class login : Form
    {
        public static int globalString;
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection str = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string query = "select * from login where CPR_No = '"+ cprbox.Text +"' and Password = '" + passbox.Text +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, str);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                string newQuery = "select User_ID from users where Login_CPR_No = '" + cprbox.Text + "'";
                SqlDataAdapter newsda = new SqlDataAdapter(newQuery, str);
                DataTable newdt = new DataTable();
                newsda.Fill(newdt);
                new user(Convert.ToInt32(newdt.Rows[0][0])).Show();
            }
            else
                MessageBox.Show("Invalid username or password");
        }
    }
}
