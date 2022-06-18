using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CategoryVm
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public int ItemCount { set; get; }
    }
}
