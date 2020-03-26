using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager7798430
{
    public abstract class Contact//Contact
    {
        public int ContactID { get; set; }
        public string contactFname { get; set; }
        public string ContactLname { get; set; }
        public string contactEmail { get; set; }
        public string contactAddr1 { get; set; }
        public string contactAddr2 { get; set; }
        public string contactAddr3 { get; set; }
        public string contactPostcode { get; set; }
        public string contactCity { get; set; }
    }

    public class PersonalContact : Contact //Inherit from contact
    {
        public string PersonalTel { get; set; }
    }

    public class BusinessContact : Contact //Inherit from contact
    {
        public string BusinessTel { get; set; }
    }

}
