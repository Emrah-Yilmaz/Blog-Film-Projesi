#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\MemberActivities\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87cfdab427db0edc27321276b90ea4d26f995ee7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MemberActivities_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MemberActivities/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87cfdab427db0edc27321276b90ea4d26f995ee7", @"/Views/Shared/Components/MemberActivities/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde5d76a64416b24c2f7dfd126a4acd6ef3f13ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_MemberActivities_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""ibox "">
                        <div class=""ibox-title"">
                            <h5>Hover Table  </h5>
                            <div class=""ibox-tools"">
                                <a class=""collapse-link"">
                                    <i class=""fa fa-chevron-up""></i>
                                </a>
                                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                                    <i class=""fa fa-wrench""></i>
                                </a>
                                <ul class=""dropdown-menu dropdown-user"">
                                    <li><a href=""#"" class=""dropdown-item"">Config option 1</a>
                                    </li>
                                    <li><a href=""#"" class=""dropdown-item"">Config option 2</a>
                                    </li>
                                </ul>
                                <a class=""close-link"">
                                  ");
            WriteLiteral(@"  <i class=""fa fa-times""></i>
                                </a>
                            </div>
                        </div>
                        <div class=""ibox-content"">

                            <table class=""table table-hover"">
                                <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Blog</th>
                                    <th>Durumu</th>
                                    <th>Detaylar </th>
                                </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 35 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\MemberActivities\Default.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                         <tr>\r\n                                    <td>");
#nullable restore
#line 38 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\MemberActivities\Default.cshtml"
                                   Write(item.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 39 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\MemberActivities\Default.cshtml"
                                   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 40 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\MemberActivities\Default.cshtml"
                                   Write(item.BlogStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 2112, "\"", 2163, 2);
            WriteAttributeValue("", 2119, "/Admin/Blog/BlogApprovalProcess/", 2119, 32, true);
#nullable restore
#line 41 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\MemberActivities\Default.cshtml"
WriteAttributeValue("", 2151, item.BlogId, 2151, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Göster </a> </td>\r\n                                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\MemberActivities\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                               \r\n                               \r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>");
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
