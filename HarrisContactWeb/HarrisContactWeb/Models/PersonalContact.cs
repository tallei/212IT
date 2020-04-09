using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactWeb.Models
{
    public class PersonalContact  // personal  contact class with public access modifier 
    {
        // 
        public int PersonalContactID { get; set; } // automatically identifies primary key of the class 
        public string PersonalFname { get; set; }
        public string PersonalLname { get; set; }
        public string PersonalEmail { get; set; }
        public string PersonalAddr1 { get; set; }
        public string PersonalAddr2 { get; set; }
        public string PersonalCity { get; set; }
        public string PersonalPostcode { get; set; }
        public string PersonalTel { get; set; }
    }
}
