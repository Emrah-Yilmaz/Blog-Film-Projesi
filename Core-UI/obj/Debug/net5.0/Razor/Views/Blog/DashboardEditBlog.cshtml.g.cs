#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc9c309b4f66c03a7bd764d9602baa5addc480ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_DashboardEditBlog), @"mvc.1.0.view", @"/Views/Blog/DashboardEditBlog.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\_ViewImports.cshtml"
using Core_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\_ViewImports.cshtml"
using Core_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc9c309b4f66c03a7bd764d9602baa5addc480ce", @"/Views/Blog/DashboardEditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde5d76a64416b24c2f7dfd126a4acd6ef3f13ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_DashboardEditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
  
    ViewData["Title"] = "DashboardCreateBlog";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Blog Düzenleme Sayfası</h1>\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Basic form elements</h4>\r\n        <p class=\"card-description\"> Basic form elements </p>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
         using (Html.BeginForm("DashboardEditBlog", "Blog", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.Label("Blog ID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.TextBoxFor(x => x.BlogId, new {@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.Label("Başlık"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.TextBoxFor(x => x.BlogTitle, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
                   Write(Html.ValidationMessageFor(x => x.BlogTitle, "", new{@class=" alert-danger"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
        Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.TextBoxFor(x => x.BlogImage, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.ValidationMessageFor(x => x.BlogImage, "", new{@class=" alert-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n");
#nullable restore
#line 29 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.Label("Film Süresi "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.TextBoxFor(x => x.FilmTimeInfo, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.ValidationMessageFor(x => x.FilmTimeInfo, "", new{@class=" alert-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n");
#nullable restore
#line 33 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.Label("Yönetmen  "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.TextBoxFor(x => x.Director, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.ValidationMessageFor(x => x.Director, "", new{@class=" alert-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n");
#nullable restore
#line 37 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.Label("IMDB  "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.TextBoxFor(x => x.Imdb, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.ValidationMessageFor(x => x.Imdb, "", new{@class=" alert-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n");
#nullable restore
#line 41 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.Label("Fragman  - Açıklama: Yalnızca Youtube Linki paylaşmalısınız ve Linkte 'v=' alanından sonraki karekterleri girmelisiniz- "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.TextBoxFor(x => x.TrailerUrl, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.ValidationMessageFor(x => x.TrailerUrl, "", new{@class=" alert-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n");
#nullable restore
#line 46 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.Label("Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.DropDownListFor(x => x.CategoryId,(List<SelectListItem>)ViewBag.categories, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.ValidationMessageFor(x => x.CategoryId, "", new{@class=" alert-danger"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.TextAreaFor(x => x.BlogContent, 15,3, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
       Write(Html.ValidationMessageFor(x => x.BlogContent, "", new{@class=" alert-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n");
            WriteLiteral("            <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">Güncelle</button>\r\n");
#nullable restore
#line 58 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\DashboardEditBlog.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
