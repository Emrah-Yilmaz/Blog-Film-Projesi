#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\AdminRole\UpdateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a2e54d02f288e4f0f0a4f15fd1339697ae00019"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRole_UpdateRole), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/UpdateRole.cshtml")]
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
#line 1 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\AdminRole\UpdateRole.cshtml"
using Core_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a2e54d02f288e4f0f0a4f15fd1339697ae00019", @"/Areas/Admin/Views/AdminRole/UpdateRole.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminRole_UpdateRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleUpdateViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\AdminRole\UpdateRole.cshtml"
  
    ViewData["Title"] = "UpdateRole";
    Layout = "~/Views/Shared/_AdminDashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Rol Güncelleme Sayfası</h1>\r\n\r\n<form method=\"post\">\r\n    <div class=\"form-group\">\r\n        <label>Role Id</label>\r\n        <input tyoe=\"text\" class=\"form-control\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 330, "\"", 347, 1);
#nullable restore
#line 13 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\AdminRole\UpdateRole.cshtml"
WriteAttributeValue("", 338, Model.Id, 338, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Role Adı</label>\r\n        <input tyoe=\"text\" class=\"form-control\" name=\"Name\"");
            BeginWriteAttribute("value", " value=\"", 487, "\"", 506, 1);
#nullable restore
#line 17 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\AdminRole\UpdateRole.cshtml"
WriteAttributeValue("", 495, Model.Name, 495, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <button class=\"btn btn-outline-success\">Güncelle</button>\r\n</form>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleUpdateViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
