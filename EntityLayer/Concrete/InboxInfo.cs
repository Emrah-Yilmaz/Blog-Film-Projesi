using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class InboxInfo
    {
        [Key]
        public int ID { get; set; }
        public string NameSurname { get; set; }
        
        public string  EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }

    }
}
