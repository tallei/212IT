using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisContactManagerCSharp
{
    public abstract class Contact // created class contact,abstract is used to avoid class initialiazation but only initialize inherited classes
    {
        // elements or attributes  
        public int ContactID { get; set; } // get method returns value of ContactID, set give value to the name(ContactID)
        public string ContactFname { get; set; } // input values  in string type 
        public string ContactLname { get; set; }
        public string ContactEmail { get; set; }
          public string ContactAddr1 { get; set; }
        public string ContactAddr2 { get; set; }
        public string ContactCity { get; set; }
        public string ContactPostcode { get; set; }
        public string ContactHomeTel { get; set; }



    }
}
