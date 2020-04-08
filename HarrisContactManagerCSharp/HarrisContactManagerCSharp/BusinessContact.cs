using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisContactManagerCSharp
{
    public class BusinessContact : Contact  // Business version inherits overall properties of Contact as well
    {

        public string BusinessTel { get; set; } // BusinessTel given from UML assigned as the Contact property

    }
}
