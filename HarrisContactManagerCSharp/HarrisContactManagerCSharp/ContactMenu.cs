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
            InitializeComponent();
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            PersonalEditorcs personal = new PersonalEditorcs();
            personal.Show();
            
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
