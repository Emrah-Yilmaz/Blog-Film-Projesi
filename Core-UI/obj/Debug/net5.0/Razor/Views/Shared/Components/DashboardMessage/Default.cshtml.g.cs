#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\DashboardMessage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5da0b7a047ed6680c5b1783c8748798d66dacfe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DashboardMessage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DashboardMessage/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5da0b7a047ed6680c5b1783c8748798d66dacfe5", @"/Views/Shared/Components/DashboardMessage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde5d76a64416b24c2f7dfd126a4acd6ef3f13ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_DashboardMessage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IOrderedEnumerable<EntityLayer.Concrete.Message>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Theme/writer/assets/images/faces/face4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<li class=""nav-item dropdown"">
    <a class=""nav-link count-indicator dropdown-toggle"" id=""messageDropdown"" href=""#"" data-toggle=""dropdown"" aria-expanded=""false"">
        <i class=""mdi mdi-email-outline""></i>
        <span class=""count-symbol bg-warning""></span>
    </a>
    <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""messageDropdown"">
        <h6 class=""p-3 mb-0"">Mesajlar</h6>
        <span class=""p-3 mb-0"">Son 3 mesaj g??r??nt??lenmektedir</span>
        <div class=""dropdown-divider""></div>
");
#nullable restore
#line 12 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\DashboardMessage\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"dropdown-item preview-item\"");
            BeginWriteAttribute("href", " href=\"", 710, "\"", 747, 2);
            WriteAttributeValue("", 717, "/Message/Inbox/", 717, 15, true);
#nullable restore
#line 14 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\DashboardMessage\Default.cshtml"
WriteAttributeValue("", 732, item.MessageId, 732, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"preview-thumbnail\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5da0b7a047ed6680c5b1783c8748798d66dacfe55836", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n                    <h6 class=\"preview-subject ellipsis mb-1 font-weight-normal\"> ");
#nullable restore
#line 19 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\DashboardMessage\Default.cshtml"
                                                                             Write(item.SenderUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"font-weight-light\">sana mesaj g??nderdi.</span></h6>\r\n                  \r\n\r\n                </div>\r\n            </a>\r\n");
#nullable restore
#line 24 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\Shared\Components\DashboardMessage\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <a href=\"/Message/Index/\">\r\n          \r\n            <h6 class=\"p-3 mb-0 text-center\">T??m Mesajlar?? G??r</h6>\r\n        </a>\r\n\r\n    </div>\r\n</li>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IOrderedEnumerable<EntityLayer.Concrete.Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
