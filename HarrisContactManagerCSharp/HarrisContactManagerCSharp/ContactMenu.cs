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
    public partial class ContactMenu : Form 
    {
        public ContactMenu()
        {
            InitializeComponent(); // method that is automatically created and managed  by windows forms 
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            PersonalEditorcs personal = new PersonalEditorcs();  // open other screen from this form (initializing the class)
            personal.Show(); // visibility in windows forms
            
        }

        private void btn_business_Click(object sender, EventArgs e)
        {
            BusinessEditor business = new BusinessEditor();
            business.Show();
        }

        private void ContactMenu_Load(object sender, EventArgs e)
        {
           
        }
    }
}
