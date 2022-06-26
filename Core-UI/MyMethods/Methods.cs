using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Core_UI.MyMethods
{
    public class Methods
    {

        public static int IsThereCategory(string search)
        {
            int result = 0;
            Context db = new();
            var values = db.Categories.FirstOrDefault(x => x.CategoryName == search);
            if (values != null)
            {
                result = 1;
            }
            return result;
        }
        public static int IsThereBlog(string search)
        {
            int result = 0;
            Context db = new();
            var values = db.Blogs.FirstOrDefault(x => x.BlogTitle == search);
            if (values != null)
            {
                result = 1;
            }
            return result;
        }
       
    }
}
