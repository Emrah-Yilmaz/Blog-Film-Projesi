#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\ContactInformation\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f20dc1a4ac8a9653024593fecb275ce68d1c2177"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContactInformation_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ContactInformation/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20dc1a4ac8a9653024593fecb275ce68d1c2177", @"/Views/Shared/Components/ContactInformation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde5d76a64416b24c2f7dfd126a4acd6ef3f13ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ContactInformation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\ContactInformation\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""d-grid contact-addres-inf mt-5 pt-lg-4"">
        <div class=""contact-info-left d-grid"">
            <div class=""contact-info"">
                <div class=""icon"">
                    <span class=""fa fa-location-arrow"" aria-hidden=""true""></span>
                </div>
                <div class=""contact-details"">
                    <h4>Adres:</h4>
                    <p>");
#nullable restore
#line 13 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\ContactInformation\Default.cshtml"
                  Write(item.OurAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""contact-info"">
                <div class=""icon"">
                    <span class=""fa fa-phone"" aria-hidden=""true""></span>
                </div>
                <div class=""contact-details"">
                    <h4>Phone:</h4>
                    <p><a href=""#"">");
#nullable restore
#line 22 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\ContactInformation\Default.cshtml"
                              Write(item.OurPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></p>
                </div>
            </div>
            <div class=""contact-info"">
                <div class=""icon"">
                    <span class=""fa fa-envelope-open-o"" aria-hidden=""true""></span>
                </div>
                <div class=""contact-details"">
                    <h4>Mail:</h4>
                    <p><a href=""mailto:mail@example.com"" class=""email"">");
#nullable restore
#line 31 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\ContactInformation\Default.cshtml"
                                                                  Write(item.OurEmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <br />\r\n     <div class=\"contact-map\">\r\n        <iframe");
            BeginWriteAttribute("src", " src=\"", 1412, "\"", 1472, 2);
            WriteAttributeValue("", 1418, "https://www.google.com/maps/embed?pb=", 1418, 37, true);
#nullable restore
#line 38 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\ContactInformation\Default.cshtml"
WriteAttributeValue("", 1455, item.OurLocation, 1455, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"600\" height=\"450\" style=\"border:0;\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1516, "\"", 1534, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n    </div>\r\n");
#nullable restore
#line 40 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\ContactInformation\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591