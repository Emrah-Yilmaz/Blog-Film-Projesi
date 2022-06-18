using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string AboutImage { get; set; }
        public string AboutTitle { get; set; }
        public string AboutContent1 { get; set; }
        public string AboutContent2 { get; set; }
        public string  OurAddress { get; set; }
        public string OurPhoneNumber { get; set; }
        public string OurEmailAddress { get; set; }
        public string OurLocation { get; set; }

    }
}
