using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace bibgui
{
    public partial class user : Form
    {
        public user(int UserID)
        {
            InitializeComponent();
            userID.Text = UserID.ToString();
        }

        private void user_Load(object sender, EventArgs e)
        {
            FillOutAllBookAtHome();

            FillOutReservedBook();

            FillOutAllBooksInLibrary();

            FillOutAllBooksEver();

            FillOutOutstandings();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdminAccess_Click(object sender, EventArgs e)
        {
            if (AreYouAdmin.Checked)
            {
                this.Hide();
                new Admin(userID.Text).Show();
            }
        }

        private void GetBookButton_Click(object sender, EventArgs e)
        {
            if (AllbooksAtHome.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.AllbooksAtHome.SelectedRows[0];
                int itemID = Convert.ToInt32(row.Cells["Item_ID"].Value);
                int till = Convert.ToInt32(row.Cells["Lent_time"].Value);
                string query = "UPDATE items SET Status_Status_ID = 2 WHERE Item_ID = "+ itemID;
                string query2 = "INSERT INTO users_lent_items (Users_User_ID, Items_Item_ID, Return_Date, Return_renewal, Returned) VALUES("+userID.Text+", "+itemID+ ", dateadd(day,"+ till + ",GETDATE()), 5, 0)";
                //string query = "DECLARE	@return_value int EXEC @return_value = [dbo].[IsItemResevedByUser] @User_ID = "+ userID.Text +", @Item_ID = "+ itemID +" SELECT  'Return Value' = @return_value";
                SqlConnection str = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                SqlCommand sda = new SqlCommand(query, str);
                SqlCommand sda2 = new SqlCommand(query2, str);
                try
                {
                    str.Open();
                    sda.ExecuteNonQuery();
                    sda2.ExecuteNonQuery();
                    str.Close();
                }
                catch (Exception)
                {

                    throw;
                }
                FillOutAllBookAtHome();
                FillOutReservedBook();
                FillOutAllBooksInLibrary();
            }
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            if (AllBooksGridView.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.AllBooksGridView.SelectedRows[0];
                int itemID = Convert.ToInt32(row.Cells["Items_Item_ID"].Value);
                string query = "UPDATE items SET Status_Status_ID = 1 WHERE Item_ID = " + itemID;
                string query2 = "UPDATE users_lent_items SET Returned = 1 WHERE Items_Item_ID = "+itemID;
                SqlConnection str = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                SqlCommand sda = new SqlCommand(query, str);
                SqlCommand sda2 = new SqlCommand(query2, str);
                try
                {
                    str.Open();
                    sda.ExecuteNonQuery();
                    sda2.ExecuteNonQuery();
                    str.Close();
                }
                catch (Exception)
                {

                    throw;
                }
                FillOutAllBookAtHome();
                FillOutReservedBook();
                FillOutAllBooksInLibrary();
            }
        }

        private void ReservBookButton_Click(object sender, EventArgs e)
        {
            if (AllBooksDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.AllBooksDataGrid.SelectedRows[0];
                if ((int)row.Cells["Item_ID"].Value < 3)
                {
                    int itemID = Convert.ToInt32(row.Cells["Item_ID"].Value);
                    string query = "UPDATE items SET Status_Status_ID = 3 WHERE Item_ID = " + itemID;
                    string query2 = "INSERT INTO users_reseved_items (Items_Item_ID, Users_User_ID, Reserved_Date, Waiting_Till) VALUES ("+itemID+", "+userID.Text+ ", GETDATE(), dateadd(month, 6,GETDATE()))";
                    SqlConnection str = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                    SqlCommand sda = new SqlCommand(query, str);
                    SqlCommand sda2 = new SqlCommand(query2, str);
                    try
                    {
                        str.Open();
                        sda.ExecuteNonQuery();
                        sda2.ExecuteNonQuery();
                        str.Close();
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
                FillOutReservedBook();
                FillOutAllBooksInLibrary();
                FillOutAllBooksEver();
            }
        }

        private void OutstandingsButton_Click(object sender, EventArgs e)
        {
            if (OutstandingsDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.OutstandingsDataGrid.SelectedRows[0];
                int OutID = (int)row.Cells["Outstandings_ID"].Value;
                string query = "DELETE FROM Outstandings WHERE Outstandings_ID = " + OutID;
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
                FillOutOutstandings();

            }
        }

        private void FillOutAllBookAtHome()
        {
            //All books that the user has at home DATAGRID
            SqlConnection str = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string query = "DECLARE	@return_value int EXEC @return_value = [dbo].[WhatBooksDoesUserHave] @CPR = NULL, @User_ID = " + userID.Text + ", @Email = NULL, @Phone_No = NULL SELECT  'Return Value' = @return_value";
            SqlDataAdapter sda = new SqlDataAdapter(query, str);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AllBooksGridView.DataSource = dt;
        }
        private void FillOutReservedBook()
        {
            //All Books that the user has reserved DATAGRID
            SqlConnection str2 = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string query2 = "SELECT users_reseved_items.Items_Item_ID, users_reseved_items.Users_Reseved_Item_ID, Items.Titel, Media.Types_Name, users_reseved_items.Reserved_Date ,users_reseved_items.Waiting_Till FROM ((users_reseved_items " +
                "INNER JOIN Items ON Items.Item_ID = users_reseved_items.Items_Item_ID) " +
                "INNER JOIN Media ON Media.Types_ID = Items.Media_Types_ID)" +
                "WHERE users_reseved_items.Users_User_ID = " + userID.Text;
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, str2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            ReservedBooks.DataSource = dt2;
        }
        private void FillOutAllBooksInLibrary()
        {
            //All Books that are "Home" DATAGRID
            SqlConnection str3 = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string query3 = "DECLARE @return_value int EXEC @return_value = [dbo].[FindAllBookThatAreHome] SELECT  'Return Value' = @return_value";
            SqlDataAdapter sda3 = new SqlDataAdapter(query3, str3);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            AllbooksAtHome.DataSource = dt3;
        }
        private void FillOutAllBooksEver()
        {
            //All Books ever DATAGRID
            SqlConnection str4 = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string query4 = "DECLARE @return_value int EXEC @return_value = [dbo].[FindAllBook] SELECT  'Return Value' = @return_value";
            SqlDataAdapter sda4 = new SqlDataAdapter(query4, str4);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            AllBooksDataGrid.DataSource = dt4;
        }
        private void FillOutOutstandings()
        {
            //Outstandings DATAGRID
            SqlConnection str5 = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string query5 = "SELECT [Outstandings_ID] ,[Amount] ,[Till_Date] ,[From_Date] FROM[bibliotekdb].[dbo].[outstandings] WHERE Users_User_ID = " + userID.Text;
            SqlDataAdapter sda5 = new SqlDataAdapter(query5, str5);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            OutstandingsDataGrid.DataSource = dt5;
        }
        private void GetReservedBookHome_Click(object sender, EventArgs e)
        {
            if (ReservedBooks.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.ReservedBooks.SelectedRows[0];
                SqlConnection str = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                int OutID = (int)row.Cells["Users_Reseved_Item_ID"].Value;
                int itemID = (int)row.Cells["Items_Item_ID"].Value;

                string query = "DELETE FROM users_reseved_items WHERE Users_Reseved_Item_ID = " + OutID;
                string query2 = "UPDATE items SET Status_Status_ID = 2 WHERE Item_ID = " + itemID;
                string str4 = "SELECT Lent_time FROM items WHERE Item_ID = "+ itemID;
                SqlDataAdapter sda2 = new SqlDataAdapter(str4, str);
                DataTable dt5 = new DataTable();
                sda2.Fill(dt5);
                int till = (int)dt5.Rows[0][0];
                string query3 = "INSERT INTO users_lent_items (Users_User_ID, Items_Item_ID, Return_Date, Return_renewal, Returned) VALUES(" + userID.Text + ", " + itemID + ", dateadd(day," + till + ",GETDATE()), 5, 0)";

                SqlCommand sda = new SqlCommand(query, str);
                SqlCommand sda3 = new SqlCommand(query2, str);
                SqlCommand sda4 = new SqlCommand(query3, str);
                try
                {
                    str.Open();
                    sda.ExecuteNonQuery();
                    sda3.ExecuteNonQuery();
                    sda4.ExecuteNonQuery();
                    str.Close();
                }
                catch (Exception)
                {

                    throw;
                }
                FillOutAllBooksEver();
                FillOutAllBooksInLibrary();
                FillOutReservedBook();
                FillOutAllBookAtHome();
            }
        }
    }
}
