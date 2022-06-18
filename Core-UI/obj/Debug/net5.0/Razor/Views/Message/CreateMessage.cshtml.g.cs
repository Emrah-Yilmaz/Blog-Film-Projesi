#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd28e972200281bc1b18d9124412afeca780cba1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_CreateMessage), @"mvc.1.0.view", @"/Views/Message/CreateMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd28e972200281bc1b18d9124412afeca780cba1", @"/Views/Message/CreateMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde5d76a64416b24c2f7dfd126a4acd6ef3f13ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_CreateMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml"
  
    ViewData["Title"] = "CreateMessage";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 class=\"card-title\">Yeni Mesaj Oluştur</h4>\r\n\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n\r\n            \r\n               <h5 class=\"alert-danger\">");
#nullable restore
#line 14 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml"
                                   Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5> \r\n            \r\n\r\n");
#nullable restore
#line 17 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml"
             using (Html.BeginForm("CreateMessage", "Message", FormMethod.Post, new { @class = "forms-sample" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 21 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml"
               Write(Html.Label("Alıcıya Ait Kullanıcı Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml"
               Write(Html.TextBoxFor(x=> x.ReceiverUsername, new{@class="form-control", @placeholder="Kullanıcı Adı"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 23 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml"
                           Write(Html.ValidationMessageFor(x => x.ReceiverUsername, "", new{@class=" alert-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml"
               Write(Html.Label("Mesaj Başlığı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml"
               Write(Html.TextBoxFor(x=> x.Subject, new{@class="form-control",  @placeholder="Başlık"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 29 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml"
                           Write(Html.ValidationMessageFor(x => x.Subject, "", new{@class=" alert-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml"
               Write(Html.Label("Mesajınız"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 36 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml"
               Write(Html.TextAreaFor(x=>x.MessageDetails, new{@class="form-control", @rows=4, @placeholder="Mesajınız..."}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 37 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml"
                           Write(Html.ValidationMessageFor(x => x.MessageDetails, "", new{@class=" alert-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">Gönder</button>\r\n                <button class=\"btn btn-light\">Temizle</button>\r\n");
#nullable restore
#line 42 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Message\CreateMessage.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591