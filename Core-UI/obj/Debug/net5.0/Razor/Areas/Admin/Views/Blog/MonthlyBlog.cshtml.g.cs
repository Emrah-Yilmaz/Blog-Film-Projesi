#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\MonthlyBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c6a2758d7f8c22d02a3e399e90004a09313c61f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_MonthlyBlog), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/MonthlyBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c6a2758d7f8c22d02a3e399e90004a09313c61f", @"/Areas/Admin/Views/Blog/MonthlyBlog.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Blog_MonthlyBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\MonthlyBlog.cshtml"
  
    ViewData["Title"] = "MonthlyBlog";
    Layout = "~/Views/Shared/_AdminDashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""wrapper wrapper-content animated fadeInUp"">

            <div class=""ibox"">
                <div class=""ibox-title"">
                    <h5>Bu Ay Yayınlananlar</h5>
                    <br />
                    <h5 class=""alert-danger"">");
#nullable restore
#line 17 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\MonthlyBlog.cshtml"
                                        Write(ViewBag.month);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                </div>\r\n                <div class=\"ibox-content\">\r\n\r\n\r\n                    <div class=\"project-list\">\r\n\r\n                        <table class=\"table table-hover\">\r\n                            <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\MonthlyBlog.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <tr>
                                        <td class=""project-status"">

                                            <span class=""label label-primary"">Bu Ay Yayınlanan Bloglar</span>
                                        </td>
                                        <td class=""project-title"">
                                            <a href=""project_detail.html"">");
#nullable restore
#line 35 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\MonthlyBlog.cshtml"
                                                                     Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            <br>\r\n                                            <small>");
#nullable restore
#line 37 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\MonthlyBlog.cshtml"
                                              Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        </td>\r\n                                        <td class=\"project-actions\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1529, "\"", 1575, 2);
            WriteAttributeValue("", 1536, "/Admin/User/ProfileDetails/", 1536, 27, true);
#nullable restore
#line 40 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\MonthlyBlog.cshtml"
WriteAttributeValue("", 1563, item.UserID, 1563, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Yazarı Göster </a>\r\n                                        </td>\r\n\r\n                                        <td class=\"project-actions\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1783, "\"", 1826, 2);
            WriteAttributeValue("", 1790, "/Admin/Blog/BlogDetails/", 1790, 24, true);
#nullable restore
#line 44 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\MonthlyBlog.cshtml"
WriteAttributeValue("", 1814, item.BlogId, 1814, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Bloğu Göster</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 47 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\MonthlyBlog.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
