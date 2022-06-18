﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SubsCategory
    {
        [Key]
        public int SubCategory { get; set; }
        public string SubCategoryName { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
