#pragma checksum "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05cde49a4401f09630530ff0faf345c7f7095c8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05cde49a4401f09630530ff0faf345c7f7095c8c", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde5d76a64416b24c2f7dfd126a4acd6ef3f13ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutHome.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"w3l-ab-grids py-5\">\r\n\t\t<div class=\"container py-lg-4\">\r\n");
#nullable restore
#line 10 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\About\Index.cshtml"
             foreach (var item in Model)
		   {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t   \t<div class=\"row ab-grids-sec align-items-center\">\r\n\t\t\t\t\r\n\t\t\t\t   <div class=\"col-lg-6 ab-right\">\r\n\t\t\t\t\t<img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 384, "\"", 406, 1);
#nullable restore
#line 15 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\About\Index.cshtml"
WriteAttributeValue("", 390, item.AboutImage, 390, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t<div class=\"col-lg-6 ab-left pl-lg-4 mt-lg-0 mt-5\">\r\n\t\t\t\t\t<h3 class=\"hny-title\">");
#nullable restore
#line 19 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\About\Index.cshtml"
                                     Write(item.AboutTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n\t\t\t\t\t<p class=\"mt-3\">");
#nullable restore
#line 20 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\About\Index.cshtml"
                               Write(item.AboutContent1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<div class=\"ready-more mt-4\">\r\n\t\t\t\t\t\t<a href=\"#\" class=\"btn read-button\">Read More <span class=\"fa fa-angle-double-right ml-2\" aria-hidden=\"true\"></span></a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 26 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\About\Index.cshtml"
		   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\r\n\t\t   \r\n\t\t\t<div class=\"w3l-counter-stats-info text-center\">\r\n\t\t\t\t<div class=\"stats_left\">\r\n\t\t\t\t");
#nullable restore
#line 31 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\About\Index.cshtml"
           Write(await Component.InvokeAsync("NumberOfCategories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t<div class=\"stats_left\">\r\n\t\t\t\t\t");
#nullable restore
#line 35 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\About\Index.cshtml"
               Write(await Component.InvokeAsync("NumberOfBlogs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t\t\r\n\t\t\t\t<div class=\"stats_left\">\r\n\t\t\t\t\t");
#nullable restore
#line 40 "C:\Users\emrah\source\repos\Core-Blog-Film\Core-UI\Views\About\Index.cshtml"
               Write(await Component.InvokeAsync("NumberOfWriters"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
					
				</div>

				<div class=""stats_left"">
					<div class=""counter_grid"">
						<div class=""icon_info"">
							<p class=""counter"">5063</p>
							<h4>Üye Sayısı</h4>

						</div>
					</div>
				</div>

			</div>

		</div>
	</div>
");
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
