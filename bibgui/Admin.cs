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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            FillOutAllBooksEver();
        }
        private void FillOutAllBooksEver()
        {
            //All Books ever DATAGRID
            SqlConnection str4 = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string query4 = "DECLARE @return_value int EXEC @return_value = [dbo].[FindAllBookEver] SELECT  'Return Value' = @return_value";
            SqlDataAdapter sda4 = new SqlDataAdapter(query4, str4);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            AllBooksEver.DataSource = dt4;
        }

        private void createItemButton_Click(object sender, EventArgs e)
        {
            int media = Convert.ToInt32(mediatext.Text);
            int status = Convert.ToInt32(statustext.Text);
            string isbn = isnbtext.Text;
            string dk5 = dk5text.Text;
            string titel = titeltext.Text;
            string description = descriptiontext.Text;
            string author = authortext.Text;
            string publisher = publishertext.Text;
            int lenttime = Convert.ToInt32(lenttimetext.Text);
            string osv = osvtext.Text;

            try
            {
                SqlConnection str = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                string query = "INSERT INTO [dbo].[items] ([Media_Types_ID] ,[Status_Status_ID] ,[Isbn_No] ,[DK5_No] ,[Titel] ,[Description] ,[Author] ,[Publisher] ,[Lent_time] ,[osv]) VALUES ("+ media + ","+ status + "  ,'"+ isbn + "'  ,'"+ dk5 + "'  ,'"+ titel + "'  ,'"+ description + "'  ,'"+ author + "'  ,'"+ publisher + "'  ,"+ lenttime + "  ,'"+ osv + "')";
                SqlCommand sda = new SqlCommand(query, str);
                str.Open();
                sda.ExecuteNonQuery();
                str.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
            FillOutAllBooksEver();
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {

            int media = Convert.ToInt32(mediatext.Text);
            int status = Convert.ToInt32(statustext.Text);
            string isbn = isnbtext.Text;
            string dk5 = dk5text.Text;
            string titel = titeltext.Text;
            string description = descriptiontext.Text;
            string author = authortext.Text;
            string publisher = publishertext.Text;
            int lenttime = Convert.ToInt32(lenttimetext.Text);
            string osv = osvtext.Text;

            try
            {
                SqlConnection str = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                string query = "UPDATE [dbo].[items] SET [Media_Types_ID] =  "+ media + ",[Status_Status_ID] =  "+ status + ",[Isbn_No] =  '"+ isbn + "',[DK5_No] =  '"+ dk5 + "',[Titel] =  '"+ titel + "',[Description] =  '"+ description + "',[Author] =  '"+ author + "',[Publisher] =  '"+ publisher + "',[Lent_time] =  "+ lenttime + ",[osv] = '"+ osv + "' WHERE Item_ID = "+itemID.Text;
                SqlCommand sda = new SqlCommand(query, str);
                str.Open();
                sda.ExecuteNonQuery();
                str.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
            FillOutAllBooksEver();
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            if(AllBooksEver.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.AllBooksEver.SelectedRows[0];
                int OutID = (int)row.Cells["Item_ID"].Value;
                string query = "DELETE FROM Items WHERE Item_ID = " + OutID;
                SqlConnection str = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                SqlCommand sda = new SqlCommand(query, str);
                try
                {
                    str.Open();
                    sda.ExecuteNonQuery();
                    str.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            FillOutAllBooksEver();
        }

        private void AllBooksEver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AllBooksEver.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.AllBooksEver.SelectedRows[0];
                itemID.Text = row.Cells["Item_ID"].Value.ToString();
                mediatext.Text = row.Cells["Media_Type_ID"].Value.ToString();
                statustext.Text = row.Cells["Status_Status_ID"].Value.ToString();
                isnbtext.Text = row.Cells["Isbn_No"].Value.ToString();
                dk5text.Text = row.Cells["DK5_No"].Value.ToString();
                titeltext.Text = row.Cells["Titel"].Value.ToString();
                descriptiontext.Text = row.Cells["Description"].Value.ToString();
                authortext.Text = row.Cells["Author"].Value.ToString();
                publishertext.Text = row.Cells["Publisher"].Value.ToString();
                lenttimetext.Text = row.Cells["Lent_time"].Value.ToString();
                osvtext.Text = row.Cells["osv"].Value.ToString();
            }
        }

        private void AllBooksEver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AllBooksEver.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.AllBooksEver.SelectedRows[0];
                itemID.Text = row.Cells["Item_ID"].Value.ToString();
                mediatext.Text = row.Cells["Media_Types_ID"].Value.ToString();
                statustext.Text = row.Cells["Status_Status_ID"].Value.ToString();
                isnbtext.Text = row.Cells["Isbn_No"].Value.ToString();
                dk5text.Text = row.Cells["DK5_No"].Value.ToString();
                titeltext.Text = row.Cells["Titel"].Value.ToString();
                descriptiontext.Text = row.Cells["Description"].Value.ToString();
                authortext.Text = row.Cells["Author"].Value.ToString();
                publishertext.Text = row.Cells["Publisher"].Value.ToString();
                lenttimetext.Text = row.Cells["Lent_time"].Value.ToString();
                osvtext.Text = row.Cells["osv"].Value.ToString();
            }

        }
        private void AllUsersFill()
        {

        }
    }
}
