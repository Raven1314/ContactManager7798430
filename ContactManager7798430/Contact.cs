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
        public string contactCity { get; set; }
        public string contactPostCode { get; set; }
    }
    public class PersonContact : Contact
    {
        public string GetcontactHomeTel { get; set; }
    }
    public class Business : Contact
    {
        public string BusinessContactTel { get; set; }
    }

}
