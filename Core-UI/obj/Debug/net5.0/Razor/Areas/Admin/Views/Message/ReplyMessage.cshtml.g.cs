#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\ReplyMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cf4317eb7ace71512e15350f0a6f1e33ed8f2b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Message_ReplyMessage), @"mvc.1.0.view", @"/Areas/Admin/Views/Message/ReplyMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cf4317eb7ace71512e15350f0a6f1e33ed8f2b2", @"/Areas/Admin/Views/Message/ReplyMessage.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Message_ReplyMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\ReplyMessage.cshtml"
  
    ViewData["Title"] = "ReplyMessage";
    Layout = "~/Views/Shared/_AdminDashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Basic form elements</h4>\r\n        <p class=\"card-description\"> Basic form elements </p>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\ReplyMessage.cshtml"
         using (Html.BeginForm("ReplyMessage", "Message","Admin", FormMethod.Post))
        {
           
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\ReplyMessage.cshtml"
       Write(Html.Label("Gönderen"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\ReplyMessage.cshtml"
       Write(Html.TextBoxFor(x => x.ReceiverUsername, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\ReplyMessage.cshtml"
       Write(Html.Label("Mesaj İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\ReplyMessage.cshtml"
       Write(Html.TextAreaFor(x => x.MessageDetails, 15,3, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">Cevapla</button>\r\n");
#nullable restore
#line 25 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\ReplyMessage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
