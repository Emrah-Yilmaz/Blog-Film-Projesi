#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\Admins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d33d1fbe0ccabeb1b63e6e3d5ea70ff1b198326"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Admins), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Admins.cshtml")]
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
#line 1 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\Admins.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d33d1fbe0ccabeb1b63e6e3d5ea70ff1b198326", @"/Areas/Admin/Views/User/Admins.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_Admins : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\Admins.cshtml"
  
    ViewData["Title"] = "Admins";
    Layout = "~/Views/Shared/_AdminDashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Kullanıcı Adı</th>\r\n            <th scope=\"col\">Mail Adresi</th>\r\n            <th scope=\"col\">Profili</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\Admins.cshtml"
         foreach (var item in Model)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n            <th > ");
#nullable restore
#line 20 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\Admins.cshtml"
             Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\Admins.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 536, "\"", 578, 2);
            WriteAttributeValue("", 543, "/Admin/User/ProfileDetails/", 543, 27, true);
#nullable restore
#line 22 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\Admins.cshtml"
WriteAttributeValue("", 570, item.Id, 570, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Profile Git</a> </td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\Admins.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
