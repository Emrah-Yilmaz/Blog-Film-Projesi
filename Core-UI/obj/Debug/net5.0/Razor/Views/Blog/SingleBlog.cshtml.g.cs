#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f48c7b48fa4935ec84fade29891e2457fe0617ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_SingleBlog), @"mvc.1.0.view", @"/Views/Blog/SingleBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f48c7b48fa4935ec84fade29891e2457fe0617ff", @"/Views/Blog/SingleBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde5d76a64416b24c2f7dfd126a4acd6ef3f13ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_SingleBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml"
  
    ViewData["Title"] = "SingleBlog";
    Layout = "~/Views/Shared/_LayoutHome.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""w3l-blog-single"">
    <div class=""single blog py-5"">
        <div class=""container py-lg-4"">
            <div style=""margin: 8px auto; display: block; text-align:center;"">

                <!---728x90--->


            </div>
            <div class=""title-content text-left"">
                <h3 class=""hny-title"">Blog Detaylar?? </h3>
            </div>
            <div class=""d-grid grid-colunm-2 mt-4"">
                <!-- left side blog post content -->
                <div class=""single-left"">

");
#nullable restore
#line 24 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-left1\">\r\n\r\n                            <div class=\"blg-img\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 896, "\"", 917, 1);
#nullable restore
#line 29 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml"
WriteAttributeValue("", 902, item.BlogImage, 902, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt="" "" class=""img-fluid"" style=""width:500px; align-self:center;"">
                            </div>

                            <div class=""btom-cont btom-cont1 pt-4 mt-md-2"">
                                <h4><span class=""fa fa-clock-o mr-1"" aria-hidden=""true""></span> ");
#nullable restore
#line 33 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml"
                                                                                            Write(((DateTime)item.CreateDate).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <h5 class=\"card-title\"><a href=\"#\">");
#nullable restore
#line 34 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml"
                                                              Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n\r\n                                ");
#nullable restore
#line 36 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml"
                           Write(await Component.InvokeAsync("RatingAndVote", new {id = ViewBag.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                \r\n\r\n\r\n\r\n\r\n                                <p class=\"mb-4 mt-4\">\r\n                                    ");
#nullable restore
#line 44 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml"
                               Write(item.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                        <blockquote class=""blockquote my-5"">
                            <div class=""icon-quote"">
                                <span class=""fa fa-quote-left"" aria-hidden=""true""></span>
                            </div>
                            Y??netmen
                            <footer class=""blockquote-footer mt-3"">
                                ");
#nullable restore
#line 54 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml"
                           Write(item.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </footer>\r\n                        </blockquote>\r\n");
            WriteLiteral("                        <iframe width=\"560\" height=\"315\"");
            BeginWriteAttribute("src", " src=\"", 2250, "\"", 2302, 2);
            WriteAttributeValue("", 2256, "https://www.youtube.com/embed/", 2256, 30, true);
#nullable restore
#line 58 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml"
WriteAttributeValue("", 2286, item.TrailerUrl, 2286, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n");
#nullable restore
#line 59 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <div class=\"comments mt-5\">\r\n\r\n\r\n                        ");
#nullable restore
#line 67 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml"
                   Write(await Component.InvokeAsync("CommentListByBlog", new {id = ViewBag.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    </div>\r\n\r\n\r\n                    ");
#nullable restore
#line 73 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml"
               Write(await Html.PartialAsync("/Views/Comment/PartialCommentAdd.cshtml", new {id = ViewBag.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n                <!-- left side blog post content -->\r\n                <!-- right side bar -->\r\n                ");
#nullable restore
#line 79 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Blog\SingleBlog.cshtml"
           Write(await Component.InvokeAsync("SingleBlogRightSide"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <!-- //right side bar -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
