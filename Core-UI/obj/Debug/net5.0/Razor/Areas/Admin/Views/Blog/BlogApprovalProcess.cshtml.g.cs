#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ccb6adbb142e1f2223a7fd70d0e2808ca2eca1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_BlogApprovalProcess), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/BlogApprovalProcess.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ccb6adbb142e1f2223a7fd70d0e2808ca2eca1e", @"/Areas/Admin/Views/Blog/BlogApprovalProcess.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Blog_BlogApprovalProcess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml"
  

    ViewData["Title"] = "AllMembers";
    Layout = "~/Views/Shared/_AdminDashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Basic form elements</h4>\r\n        <p class=\"card-description\"> Basic form elements </p>\r\n        <h1 class=\"alert-success text-center\">");
#nullable restore
#line 12 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml"
                                         Write(ViewBag.published);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h1 class=\"alert-danger text-center\">");
#nullable restore
#line 13 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml"
                                        Write(ViewBag.unpublished);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        \r\n\r\n");
#nullable restore
#line 16 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml"
         using (Html.BeginForm("BlogApprovalProcess", "Blog", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml"
       Write(Html.Label("Blog ID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml"
       Write(Html.TextBoxFor(x => x.BlogId, new {@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml"
       Write(Html.Label("Başlık"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml"
       Write(Html.TextBoxFor(x => x.BlogTitle, new {@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml"
                   Write(Html.ValidationMessageFor(x => x.BlogTitle, "", new{@class=" alert-danger"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml"
       Write(Html.Label("Blog Durumu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml"
       Write(Html.TextBoxFor(x => x.BlogStatus, new {@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n");
            WriteLiteral("            <button type=\"submit\" class=\"btn btn-info  container-fluid\"> ");
#nullable restore
#line 30 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml"
                                                                    Write(ViewBag.buton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 31 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Blog\BlogApprovalProcess.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
