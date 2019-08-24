using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Customer_Management_System
{
    public partial class CustomerManagement : Form
    {
        string connnectionString = @"Server=localhost;Database=customer_management_system;Uid=root;Pwd=01262812;";
        int ContactID = 0;
        public CustomerManagement()
        {
            InitializeComponent();
        }

       

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text == "" || txtLastName.Text == "" || txtGender.Text == "" || txtContact.Text == "")
            {
                errorEmptyInfo.Visible = true;
            }
            else
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connnectionString))
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("infoAddorEdit", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_ContactID", ContactID);
                    mySqlCmd.Parameters.AddWithValue("_FirstName", txtFirstName.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_LastName", txtLastName.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_ContactNo", txtContact.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Gender", txtGender.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Successfully");
                    GridFill();
                    Clear();
                    errorEmptyInfo.Visible = false;

                }
            }
           

        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connnectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("infoViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblinformation = new DataTable();
                sqlDa.Fill(dtblinformation);
                dgvinformation.DataSource = dtblinformation;

            }

        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtContact.Text = txtGender.Text = "";
            ContactID = 0;
            addButton.Text = "Add";
            deleteButton.Enabled = false;
        }

        private void Dgvinformation_DoubleClick(object sender, EventArgs e)
        {
            if(dgvinformation.CurrentRow.Index != -1)
            {
                txtFirstName.Text = dgvinformation.CurrentRow.Cells[1].Value.ToString();
                txtLastName.Text = dgvinformation.CurrentRow.Cells[2].Value.ToString();
                txtContact.Text = dgvinformation.CurrentRow.Cells[3].Value.ToString();
                txtGender.Text = dgvinformation.CurrentRow.Cells[4].Value.ToString();
                ContactID = Convert.ToInt32(dgvinformation.CurrentRow.Cells[0].Value.ToString());
                addButton.Text = "Update";
                deleteButton.Enabled = true;

            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connnectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("infoSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblinformation = new DataTable();
                sqlDa.Fill(dtblinformation);
                dgvinformation.DataSource = dtblinformation;
                
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure to delete this customer ?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connnectionString))
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("infoDeleteByID", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_ContactID", ContactID);
                    mySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Succesfully");
                    Clear();
                    GridFill();
                }
            }
            
        }

        private void TxtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CustomerManagement_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
