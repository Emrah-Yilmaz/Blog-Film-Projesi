#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\AllMembers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "687b42084b551f206bb3b61de0feadd265656717"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_AllMembers), @"mvc.1.0.view", @"/Areas/Admin/Views/User/AllMembers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"687b42084b551f206bb3b61de0feadd265656717", @"/Areas/Admin/Views/User/AllMembers.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_AllMembers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\AllMembers.cshtml"
  
    ViewData["Title"] = "AllMembers";
    Layout = "~/Views/Shared/_AdminDashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row wrapper border-bottom white-bg page-heading"">
                <div class=""col-lg-9"">
                    <h2>Tüm Üyelerimiz</h2>
                    
                </div>
            </div>

            <div class=""wrapper wrapper-content animated fadeInRight"">
        <div class=""row"">

");
#nullable restore
#line 17 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\AllMembers.cshtml"
             foreach (var item in Model)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4\">\r\n                <div class=\"contact-box\">\r\n                    <a class=\"row\"");
            BeginWriteAttribute("href", " href=\"", 643, "\"", 685, 2);
            WriteAttributeValue("", 650, "/Admin/User/ProfileDetails/", 650, 27, true);
#nullable restore
#line 21 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\AllMembers.cshtml"
WriteAttributeValue("", 677, item.Id, 677, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"col-4\">\r\n                        <div class=\"text-center\">\r\n                            <img alt=\"image\" class=\"rounded-circle m-t-xs img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 865, "\"", 885, 1);
#nullable restore
#line 24 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\AllMembers.cshtml"
WriteAttributeValue("", 871, item.ImageUrl, 871, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"m-t-xs font-bold\">");
#nullable restore
#line 25 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\AllMembers.cshtml"
                                                     Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-8\">\r\n                        <h3><strong>");
#nullable restore
#line 29 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\AllMembers.cshtml"
                               Write(item.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\r\n                        <p>");
#nullable restore
#line 30 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\AllMembers.cshtml"
                      Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <address>\r\n                            <strong>");
#nullable restore
#line 32 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\AllMembers.cshtml"
                               Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong><br>
                            795 Folsom Ave, Suite 600<br>
                            San Francisco, CA 94107<br>
                            <abbr title=""Phone"">P:</abbr> (123) 456-7890
                        </address>
                    </div>
                        </a>
                </div>
            </div>
");
#nullable restore
#line 41 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\User\AllMembers.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n          \r\n        </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
