#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\UnpublishedBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e1eb735b4161e4b2cc30a0bfe5db082449303f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_UnpublishedBlog), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/UnpublishedBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e1eb735b4161e4b2cc30a0bfe5db082449303f2", @"/Areas/Admin/Views/Blog/UnpublishedBlog.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Blog_UnpublishedBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\UnpublishedBlog.cshtml"
  
    ViewData["Title"] = "UnpublishedBlog";
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
                    <h5>Yayında Olan Bloglar</h5>

                </div>
                <div class=""ibox-content"">


                    <div class=""project-list"">

                        <table class=""table table-hover"">
                            <tbody>
");
#nullable restore
#line 23 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\UnpublishedBlog.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <tr>
                                        <td class=""project-status"">

                                            <span class=""label label-default"">Yayından Kaldılmış</span>
                                        </td>
                                        <td class=""project-title"">
                                            <a href=""project_detail.html"">");
#nullable restore
#line 31 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\UnpublishedBlog.cshtml"
                                                                     Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            <br>\r\n                                            <small>");
#nullable restore
#line 33 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\UnpublishedBlog.cshtml"
                                              Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        </td>\r\n                                        <td class=\"project-actions\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1430, "\"", 1476, 2);
            WriteAttributeValue("", 1437, "/Admin/Blog/ProfileDetails/", 1437, 27, true);
#nullable restore
#line 36 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\UnpublishedBlog.cshtml"
WriteAttributeValue("", 1464, item.UserID, 1464, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Yazarı Göster </a>\r\n                                        </td>\r\n\r\n                                        <td class=\"project-actions\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1684, "\"", 1727, 2);
            WriteAttributeValue("", 1691, "/Admin/Blog/BlogDetails/", 1691, 24, true);
#nullable restore
#line 40 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\UnpublishedBlog.cshtml"
WriteAttributeValue("", 1715, item.BlogId, 1715, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Bloğu Göster</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 43 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\UnpublishedBlog.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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