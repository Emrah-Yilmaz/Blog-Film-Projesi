#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8f8c4f63af75a700235c2f92ada32e04f16a986"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Message_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Message/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f8c4f63af75a700235c2f92ada32e04f16a986", @"/Areas/Admin/Views/Message/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Message_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Message>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminDashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper wrapper-content"">
    <div class=""row"">

        <div class=""col-lg-12 animated fadeInRight"">
            <div class=""mail-box-header"">


                <h2>
                    Inbox (16)
                </h2>

            </div>
            <div class=""mail-box"">

                <table class=""table table-hover table-mail"">
                    <tbody>
");
#nullable restore
#line 23 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\Index.cshtml"
                         foreach (var item in Model)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"unread\">\r\n\r\n                            <td class=\"mail-ontact\"><a");
            BeginWriteAttribute("href", " href=\"", 724, "\"", 767, 2);
            WriteAttributeValue("", 731, "/Admin/Message/Inbox/", 731, 21, true);
#nullable restore
#line 27 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\Index.cshtml"
WriteAttributeValue("", 752, item.MessageId, 752, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\Index.cshtml"
                                                                                              Write(item.SenderUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                            <td class=\"mail-subject\"><a");
            BeginWriteAttribute("href", " href=\"", 855, "\"", 898, 2);
            WriteAttributeValue("", 862, "/Admin/Message/Inbox/", 862, 21, true);
#nullable restore
#line 28 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\Index.cshtml"
WriteAttributeValue("", 883, item.MessageId, 883, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\Index.cshtml"
                                                                                               Write(item.MessageDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                            <td class=\"text-right mail-date\"><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 29 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\Index.cshtml"
                                                                                     Write(item.MessageDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\n");
#nullable restore
#line 31 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Areas\Admin\Views\Message\Index.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n\r\n                    </tbody>\r\n                </table>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
