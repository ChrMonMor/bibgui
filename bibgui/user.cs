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
            //All books that the user has at home DATAGRID
            SqlConnection str = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string query = "DECLARE	@return_value int EXEC @return_value = [dbo].[WhatBooksDoesUserHave] @CPR = NULL, @User_ID = "+ userID.Text + ", @Email = NULL, @Phone_No = NULL SELECT  'Return Value' = @return_value";
            SqlDataAdapter sda = new SqlDataAdapter(query, str);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AllBooksGridView.DataSource = dt;

            //All Books that the user has reserved DATAGRID
            SqlConnection str2 = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string query2 = "SELECT Items.Titel, Media.Types_Name, users_reseved_items.Reserved_Date ,users_reseved_items.Waiting_Till FROM ((users_reseved_items " +
                "INNER JOIN Items ON Items.Item_ID = users_reseved_items.Items_Item_ID) " +
                "INNER JOIN Media ON Media.Types_ID = Items.Media_Types_ID)" +
                "WHERE users_reseved_items.Users_User_ID = "+userID.Text;
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, str2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            ReservedBooks.DataSource = dt2;

            //All Books that are "Home" DATAGRID
            SqlConnection str3 = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string query3 = "DECLARE @return_value int EXEC @return_value = [dbo].[FindAllBookThatAreHome] SELECT  'Return Value' = @return_value";
            SqlDataAdapter sda3 = new SqlDataAdapter(query3, str3);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            AllbooksAtHome.DataSource = dt3;

            //All Books ever DATAGRID
            SqlConnection str4 = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string query4 = "DECLARE @return_value int EXEC @return_value = [dbo].[FindAllBook] SELECT  'Return Value' = @return_value";
            SqlDataAdapter sda4 = new SqlDataAdapter(query4, str4);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            AllBooksDataGrid.DataSource = dt4;
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
                new Admin().Show();
            }
        }

        private void GetBookButton_Click(object sender, EventArgs e)
        {
            if (AllbooksAtHome.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.AllbooksAtHome.SelectedRows[0];
                //row.Cells["ColumnName"].Value;
            }
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            if (AllBooksGridView.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.AllBooksGridView.SelectedRows[0];
                //row.Cells["ColumnName"].Value;
            }
        }

        private void ReservBookButton_Click(object sender, EventArgs e)
        {
            if (AllBooksDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.AllBooksDataGrid.SelectedRows[0];
                //row.Cells["ColumnName"].Value;
            }
        }
    }
}
