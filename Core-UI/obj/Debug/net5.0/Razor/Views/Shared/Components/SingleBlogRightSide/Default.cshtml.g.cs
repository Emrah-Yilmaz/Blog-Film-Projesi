#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\SingleBlogRightSide\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f490f561301a88df7a8fb6a52f284f1e4b11ef1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SingleBlogRightSide_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SingleBlogRightSide/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\SingleBlogRightSide\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f490f561301a88df7a8fb6a52f284f1e4b11ef1e", @"/Views/Shared/Components/SingleBlogRightSide/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde5d76a64416b24c2f7dfd126a4acd6ef3f13ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SingleBlogRightSide_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryVm>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n  <div class=\"right-side-bar\">\r\n                   \r\n                    <aside class=\"posts\">\r\n                        <h3 class=\"aside-title\">Top Movies</h3>\r\n                        <ul class=\"category\">\r\n");
#nullable restore
#line 9 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\SingleBlogRightSide\Default.cshtml"
                           foreach (var item in Model)
                         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 416, "\"", 457, 2);
            WriteAttributeValue("", 423, "/Category/CategoryDetails/", 423, 26, true);
#nullable restore
#line 12 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\SingleBlogRightSide\Default.cshtml"
WriteAttributeValue("", 449, item.Id, 449, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"fa fa-angle-right\">\r\n\r\n                                </span>");
#nullable restore
#line 14 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\SingleBlogRightSide\Default.cshtml"
                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <label> (");
#nullable restore
#line 14 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\SingleBlogRightSide\Default.cshtml"
                                                      Write(item.ItemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</label></a>\r\n                            </li>   \n");
#nullable restore
#line 16 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\SingleBlogRightSide\Default.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        \r\n                        </ul>\r\n                    </aside>\r\n                </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryVm>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591