using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarrisContactManagerCSharp
{
    
    public partial class BusinessEditor : Form
    {
        DbConn dbConn = new DbConn();
        public BusinessEditor()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BusinessEditor_Load(object sender, EventArgs e)
        {
            dGVBusinessRecords.DataSource = dbConn.GetAllBusiness(); // support in populating records in datagrid
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dGVBusinessRecords.DataSource = dbConn.GetAllBusiness(); // refresh any selected data
        }


        private void btnAddNew_Click(object sender, EventArgs e)
        { // enable text boxes functions 
            tbFname.Enabled = true;
            tbLname.Enabled = true;
            tbEmail.Enabled = true;
            tbAddr1.Enabled = true;
            tbAddr2.Enabled = true;
            tbCity.Enabled = true;
            tbPostcode.Enabled = true;
            tbBusinessTel.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveNew.Enabled = true;
            // text boxes should be empty after inserting new data in table 
            tbFname.Text = String.Empty;
            tbLname.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbAddr1.Text = String.Empty;
            tbAddr2.Text = String.Empty;
            tbCity.Text = String.Empty;
            tbPostcode.Text = String.Empty;
            tbBusinessTel.Text = String.Empty;
        }

        private void dGVBusinessRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = Int32.Parse(dGVBusinessRecords.SelectedCells[0].Value.ToString());    // get index of current selected for contact ID 
            tbFname.Text = dGVBusinessRecords.SelectedCells[1].Value.ToString();
            tbLname.Text = dGVBusinessRecords.SelectedCells[2].Value.ToString();
            tbEmail.Text = dGVBusinessRecords.SelectedCells[3].Value.ToString();
            tbAddr1.Text = dGVBusinessRecords.SelectedCells[4].Value.ToString();
            tbAddr2.Text = dGVBusinessRecords.SelectedCells[5].Value.ToString();
            tbCity.Text = dGVBusinessRecords.SelectedCells[6].Value.ToString();
            tbPostcode.Text = dGVBusinessRecords.SelectedCells[7].Value.ToString();
            tbBusinessTel.Text = dGVBusinessRecords.SelectedCells[8].Value.ToString();

            //populate it based upon the data 
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            BusinessContact businessContact = new BusinessContact();
            businessContact.ContactFname = tbFname.Text;
            businessContact.ContactLname = tbLname.Text;
            businessContact.ContactEmail = tbEmail.Text;
            businessContact.ContactAddr1 = tbAddr1.Text;
            businessContact.ContactAddr2 = tbAddr2.Text;
            businessContact.ContactCity = tbCity.Text;
            businessContact.ContactPostcode = tbPostcode.Text;
            businessContact.BusinessTel = tbBusinessTel.Text;
            dbConn.InsertBusiness(businessContact); // INSERT PERSONAL TAKES PERSONAL CONTACT AS A PERIMETER 
            tbFname.Enabled = false; // changed true to false 
            tbLname.Enabled = false; // changed true to false 
            tbEmail.Enabled = false; // changed true to false
            tbAddr1.Enabled = false; // changed true to false
            tbAddr2.Enabled = false;  // changed true to false;
            tbCity.Enabled = false; // changed true to false
            tbPostcode.Enabled = false; // changed true to false
            tbBusinessTel.Enabled = false; // changed true to false
            btnUpdate.Enabled = true; // changed false to true
            btnDelete.Enabled = true; // changed FALSE to TRUE
            btnSaveNew.Enabled = false; // changed true to false
            dGVBusinessRecords.DataSource = dbConn.GetAllBusiness();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { //enable text boxes
            tbFname.Enabled = true;
            tbLname.Enabled = true;
            tbEmail.Enabled = true;
            tbAddr1.Enabled = true;
            tbAddr2.Enabled = true;
            tbCity.Enabled = true;
            tbPostcode.Enabled = true;
            tbBusinessTel.Enabled = true;
            // disabled buttons 
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAddNew.Enabled = false;
            btnSave.Enabled = true; // enable button 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(dGVBusinessRecords.SelectedCells[0].Value.ToString()); // auto-generated 
            BusinessContact businessContact = new BusinessContact(); // call the business class for data stored 
            businessContact.ContactID = index;   // contact id is auto-generated 
            businessContact.ContactFname = tbFname.Text;  
            businessContact.ContactLname = tbLname.Text;
            businessContact.ContactEmail = tbEmail.Text;
            businessContact.ContactAddr1 = tbAddr2.Text;
            businessContact.ContactAddr2 = tbAddr2.Text;
            businessContact.ContactCity = tbCity.Text;
            businessContact.ContactPostcode = tbPostcode.Text;
            businessContact.BusinessTel = tbBusinessTel.Text;
            dbConn.UpdateBusiness(businessContact); // call dbconn connection for updating the business in table 
            dGVBusinessRecords.DataSource = dbConn.GetAllBusiness(); // call get all business from stored procedure in heidi SQL 
            tbFname.Enabled = false; 
            tbLname.Enabled = false;
            tbEmail.Enabled = false;
            tbAddr1.Enabled = false;
            tbAddr2.Enabled = false;
            tbCity.Enabled = false;
            tbPostcode.Enabled = false;
            tbBusinessTel.Enabled = false;
            btnUpdate.Enabled = true; // enable button 
            btnDelete.Enabled = true; // enable button 
            btnAddNew.Enabled = true; // enable button 
            btnSave.Enabled = false; // disabled 

        }

        private void btnDelete_Click(object sender, EventArgs e) 
        {
           
            string message = "Are you sure you want to delete?";   // message when deleting data
            // delete message with ID of the selected row
            string caption = "Do you want to delete the contact with the record  with id of " + Int32.Parse(dGVBusinessRecords.SelectedCells[0].Value.ToString());
           
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;  // enable message,caption and buttons functions in page 
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes) // if select Yes, system must delete record  while (No) will automatically exit the action 
            {
                // delete business is passed to ID 
                dbConn.DeleteBusiness(Int32.Parse(dGVBusinessRecords.SelectedCells[0].Value.ToString()));
                dGVBusinessRecords.DataSource = dbConn.GetAllBusiness();
            }
        }
    }
}
