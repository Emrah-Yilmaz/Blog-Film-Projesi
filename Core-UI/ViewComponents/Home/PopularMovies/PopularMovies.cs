﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject_Emrah_Yilmaz.ViewComponents.Blog.PopularMovies
{
    public class PopularMovies:ViewComponent
    {
        readonly BlogManager blogManager = new(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = blogManager.GetListSelected(x => x.SubCategory == 4);
            return View(values);

        }
    }
}
