#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Category\CategoryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "093f7e3a3f557ea2842e0bebeb552f61b08564a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryDetails), @"mvc.1.0.view", @"/Views/Category/CategoryDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"093f7e3a3f557ea2842e0bebeb552f61b08564a5", @"/Views/Category/CategoryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde5d76a64416b24c2f7dfd126a4acd6ef3f13ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_CategoryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Category\CategoryDetails.cshtml"
  
    ViewData["Title"] = "CategoryDetails";
    Layout = "~/Views/Shared/_LayoutHome.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""w3l-grids"">
    <div class=""grids-main py-5"">
        <div class=""container py-lg-4"">
            <div class=""headerhny-title"">
                <div class=""w3l-title-grids"">
                    <div class=""headerhny-left"">

                        <h4><a class=""show-title"" href=""#"">");
#nullable restore
#line 14 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Category\CategoryDetails.cshtml"
                                                      Write(ViewBag.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"w3l-populohny-grids\">\r\n                ");
#nullable restore
#line 20 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Category\CategoryDetails.cshtml"
           Write(ViewBag.empty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Category\CategoryDetails.cshtml"
                 foreach (var item in Model)
                {
                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"item vhny-grid\">\r\n                        <div class=\"box16\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 853, "\"", 889, 2);
            WriteAttributeValue("", 860, "/Blog/SingleBlog/", 860, 17, true);
#nullable restore
#line 26 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Category\CategoryDetails.cshtml"
WriteAttributeValue("", 877, item.BlogId, 877, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <figure>\r\n                                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 993, "\"", 1014, 1);
#nullable restore
#line 28 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Category\CategoryDetails.cshtml"
WriteAttributeValue("", 999, item.BlogImage, 999, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1015, "\"", 1021, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </figure>\r\n                                <div class=\"box-content\">\r\n                                    <h3 class=\"title\">");
#nullable restore
#line 31 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Category\CategoryDetails.cshtml"
                                                 Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <h4>\r\n                                        <span class=\"post\">\r\n                                            <span class=\"fa fa-clock-o\"> </span>");
#nullable restore
#line 34 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Category\CategoryDetails.cshtml"
                                                                           Write(item.FilmTimeInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                        </span>

                                        <span class=""post fa fa-heart text-right""></span>
                                    </h4>
                                </div>
                                <span class=""fa fa-play video-icon"" aria-hidden=""true""></span>
                            </a>
                        </div>
                    </div>
");
#nullable restore
#line 45 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Category\CategoryDetails.cshtml"
                 
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


            </div>
        </div>

        <div class=""button-center text-center mt-3"">
            <a href=""/Category/Index/"" class=""btn view-button"">
                Geri Dön <span class=""fa fa-angle-double-left ml-2""
                               aria-hidden=""true""></span>
            </a>
        </div>

    </div>
</section>
");
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
