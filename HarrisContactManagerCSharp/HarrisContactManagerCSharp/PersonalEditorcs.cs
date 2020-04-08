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
    public partial class PersonalEditorcs : Form  // personal contact form editor 
    { 
        DbConn dbConn = new DbConn();  
        public PersonalEditorcs()
        {
            InitializeComponent();
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            PersonalEditorcs personal = new PersonalEditorcs();
            personal.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e) 
        {
            tbFname.Enabled = true; // Enable text boxes when update clciked 
            tbLname.Enabled = true;
            tbEmail.Enabled = true;
            tbAddr1.Enabled = true;
            tbAddr2.Enabled = true;
            tbCity.Enabled = true;
            tbPostcode.Enabled = true;
            tbTel.Enabled = true;
            btnUpdate.Enabled = false; // disabled button while updating
            btnDelete.Enabled = false;
            btnAddNew.Enabled = false; 
            btnSave.Enabled = true; // save button is enabled while updating
          


        }

        private void PersonalEditorcs_Load(object sender, EventArgs e) // when form loads populate data grid view 
        {
            dGVPersonalRecords.DataSource = dbConn.GetAllPersonal(); // use GetAllPersonal method 
        }

        private void btnRefresh_Click(object sender, EventArgs e)  // generate refresh button to view all personal in grid view
        {
            dGVPersonalRecords.DataSource = dbConn.GetAllPersonal(); // duplicate codes with the load method 
        }

       
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbFname.Enabled = true; // enabling text box to function in page without leaving them empty 
            tbLname.Enabled = true;
            tbEmail.Enabled = true;
            tbAddr1.Enabled = true;
            tbAddr2.Enabled = true;
            tbCity.Enabled = true;
            tbPostcode.Enabled = true;
            tbTel.Enabled = true;
            btnUpdate.Enabled = false;  // button will be disabled when add button clciked 
            btnDelete.Enabled = false;
            btnSaveNew.Enabled = true; // record can be saved when added 
            tbFname.Text = String.Empty; // enable assigning text 
            tbLname.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbAddr1.Text = String.Empty;
            tbAddr2.Text = String.Empty;
            tbCity.Text = String.Empty;
            tbPostcode.Text = String.Empty;
            tbTel.Text = String.Empty;



        }

     

        private void dGVPersonalRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int index = Int32.Parse(dGVPersonalRecords.SelectedCells[0].Value.ToString());  // take first item in grid 
            tbFname.Text = dGVPersonalRecords.SelectedCells[1].Value.ToString();  // Populate text 
            tbLname.Text = dGVPersonalRecords.SelectedCells[2].Value.ToString();  
            tbEmail.Text = dGVPersonalRecords.SelectedCells[3].Value.ToString();
            tbAddr1.Text = dGVPersonalRecords.SelectedCells[4].Value.ToString();
            tbAddr2.Text = dGVPersonalRecords.SelectedCells[5].Value.ToString();
            tbCity.Text = dGVPersonalRecords.SelectedCells[6].Value.ToString();
            tbPostcode.Text = dGVPersonalRecords.SelectedCells[7].Value.ToString();
            tbTel.Text = dGVPersonalRecords.SelectedCells[8].Value.ToString();
        }

        private void dGVPersonalRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSaveNew_Click_1(object sender, EventArgs e) // populate the save new button and text box to be passed to enable data creation
        {
            PersonalContact personalContact = new PersonalContact();
            personalContact.ContactFname = tbFname.Text;
            personalContact.ContactLname = tbLname.Text;
            personalContact.ContactEmail = tbEmail.Text;
            personalContact.ContactAddr1 = tbAddr1.Text;
            personalContact.ContactAddr2 = tbAddr2.Text;
            personalContact.ContactCity = tbCity.Text;
            personalContact.ContactPostcode = tbPostcode.Text;
            personalContact.PersonalTel = tbTel.Text;
            dbConn.InsertPersonal(personalContact); // INSERT PERSONAL TAKES PERSONAL CONTACT AS A PERIMETER 
            tbFname.Enabled = false; // changed true to false 
            tbLname.Enabled = false; // changed true to false 
            tbEmail.Enabled = false; // changed true to false
            tbAddr1.Enabled = false; // changed true to false
            tbAddr2.Enabled = false;  // changed true to false;
            tbCity.Enabled = false; // changed true to false
            tbPostcode.Enabled = false; // changed true to false
            tbTel.Enabled = false; // changed true to false
            btnUpdate.Enabled = true; // changed false to true
            btnDelete.Enabled = true; // changed FALSE to TRUE
            btnSaveNew.Enabled = false; // changed true to false
            dGVPersonalRecords.DataSource = dbConn.GetAllPersonal();  // Passed objects and enable them in the database 
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(dGVPersonalRecords.SelectedCells[0].Value.ToString()); // get index of current selected for contact ID 
            PersonalContact personalContact = new PersonalContact();
            personalContact.ContactID = index;
            personalContact.ContactFname = tbFname.Text;
            personalContact.ContactLname = tbLname.Text;
            personalContact.ContactEmail = tbEmail.Text;
            personalContact.ContactAddr1 = tbAddr2.Text;
            personalContact.ContactAddr2 = tbAddr2.Text;
            personalContact.ContactCity = tbCity.Text;
            personalContact.ContactPostcode = tbPostcode.Text;
            personalContact.PersonalTel = tbTel.Text;
            dbConn.UpdatePersonal(personalContact);
            dGVPersonalRecords.DataSource = dbConn.GetAllPersonal(); // refreshing the data when insert any record 
            tbFname.Enabled = false;
            tbLname.Enabled = false;
            tbEmail.Enabled = false;
            tbAddr1.Enabled = false;
            tbAddr2.Enabled = false;
            tbCity.Enabled = false;
            tbPostcode.Enabled = false;
            tbTel.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAddNew.Enabled = true;
            btnSave.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete?"; // message when deleting data
            string caption = "Do you want to delete the contact with the record  with id of " +  Int32.Parse(dGVPersonalRecords.SelectedCells[0].Value.ToString()); // delete message with ID of the selected row
            MessageBoxButtons buttons = MessageBoxButtons.YesNo; // two message box buttons to do or reject delete action of data
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons); // enable message,caption and buttons functions in page 
            if  (result == DialogResult.Yes) // if select Yes, system must delete record  while (No) will automatically exit the action 
            {
                // delete personal is passed to ID 
                dbConn.DeletePersonal(Int32.Parse(dGVPersonalRecords.SelectedCells[0].Value.ToString())); 
                dGVPersonalRecords.DataSource = dbConn.GetAllPersonal(); 
            }

        }

        private void dGVPersonalRecords_SelectionChanged(object sender, EventArgs e)
        {
      
        }

        private void dGVPersonalRecords_Click(object sender, EventArgs e)
        {

        }
    }
}
