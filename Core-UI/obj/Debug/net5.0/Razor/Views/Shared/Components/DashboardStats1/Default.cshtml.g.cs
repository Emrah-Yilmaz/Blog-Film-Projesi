#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\DashboardStats1\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f2d857a170ec35ff30c8c7f6795d4e27e8724a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DashboardStats1_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DashboardStats1/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f2d857a170ec35ff30c8c7f6795d4e27e8724a2", @"/Views/Shared/Components/DashboardStats1/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde5d76a64416b24c2f7dfd126a4acd6ef3f13ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_DashboardStats1_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\DashboardStats1\Default.cshtml"
Write(ViewBag.haftagunu);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <div class=""col-lg-3"">
  
         <div class=""ibox "">
            <div class=""ibox-title"">
                <span class=""label label-success float-right""> Ayl??k</span>
                <h5>Blog </h5>
            </div>
            <div class=""ibox-content"">
                <h1 class=""no-margins"">");
#nullable restore
#line 11 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\DashboardStats1\Default.cshtml"
                                  Write(ViewBag.monthly);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </h1>
                <small>Ay??n ilk g??n?? ve bug??n aras??ndaki blog say??s?? </small>
            </div>
        </div>

    </div>

    <div class=""col-lg-3"">
         <div class=""ibox "">
            <div class=""ibox-title"">
                <span class=""label label-info float-right"">Haftal??k</span>
                <h5>Blog</h5>
            </div>
            <div class=""ibox-content"">
                <h1 class=""no-margins"">");
#nullable restore
#line 25 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\DashboardStats1\Default.cshtml"
                                  Write(ViewBag.weekly);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                <small>Haftan??n ilk g??n?? ve bug??n aras??ndaki blog say??s??</small>
            </div>
        </div>      

       
    </div>

    <div class=""col-lg-3"">
       <div class=""ibox "">
            <div class=""ibox-title"">
                <span class=""label label-primary float-right"">G??nl??k</span>
                <h5>Blog</h5>
            </div>
            <div class=""ibox-content"">
                <h1 class=""no-margins"">");
#nullable restore
#line 40 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\DashboardStats1\Default.cshtml"
                                  Write(ViewBag.daily);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                <small>Son 24 saatlik blog say??s??</small>
            </div>
        </div>        

        
    </div>

    <div class=""col-lg-3"">
             
         <div class=""ibox "">
            <div class=""ibox-title"">
                <span class=""label label-danger float-right"">Toplam</span>
                <h5>Blog </h5>
            </div>
            <div class=""ibox-content"">
                <h1 class=""no-margins"">");
#nullable restore
#line 56 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\DashboardStats1\Default.cshtml"
                                  Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <small>Toplam blog say??s?? </small>\r\n            </div>\r\n        </div>\r\n\r\n       \r\n    </div>");
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
