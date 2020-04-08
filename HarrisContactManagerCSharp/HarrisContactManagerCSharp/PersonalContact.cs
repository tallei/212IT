using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisContactManagerCSharp
{
   public  class PersonalContact: Contact // Personal Contact inherits overall properties of Contact
   {
        public string PersonalTel { get; set; } // PersonalTel assigned as the Contact property
   }
}
