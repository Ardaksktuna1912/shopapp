#pragma checksum "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "051e29fa6a3481b2823e0103f6a03dea02cea9e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__layout), @"mvc.1.0.view", @"/Views/Shared/_layout.cshtml")]
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
#line 1 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
using shopapp.webui.WievModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"051e29fa6a3481b2823e0103f6a03dea02cea9e5", @"/Views/Shared/_layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"939a67bb250e2d80621aaf1d6e67572328004f12", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "051e29fa6a3481b2823e0103f6a03dea02cea9e53277", async() => {
                WriteLiteral("\r\n\t\r\n\t<link rel=\"stylesheet\" href=\"/modules/bootstrap/dist/css/bootstrap.min.css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "051e29fa6a3481b2823e0103f6a03dea02cea9e54335", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
     if(IsSectionDefined("MessageBox"))
	{
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
   Write(RenderSection("MessageBox"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
                                    
	}
	else
	{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t<div class=\"alert alert-success text-center m-0\">Welcome</div>\r\n");
#nullable restore
#line 23 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
	}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\t");
#nullable restore
#line 27 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\r\n\t");
#nullable restore
#line 29 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
Write(RenderSection("Header",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t<main class=\"my-3\">\r\n\t\t<div class=\"container\">\r\n\r\n");
#nullable restore
#line 34 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
     if (IsSectionDefined("Categories"))
		{
		

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t<div class=\"col-md-3\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 39 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
                   Write(RenderSection("Categories",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\r\n\r\n\t\t\t\t\t<div class=\"col-md-9\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 44 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
                       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 48 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
			}
	else
				{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-md-12\">\r\n\t\t\t\t\t");
#nullable restore
#line 53 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 57 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"

				}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\r\n\r\n\t\t\t\t\t\r\n\t\t\t\r\n\t\t</div>\r\n\t</main>\r\n\r\n\r\n\t\r\n\t<script src=\"https://code.jquery.com/jquery-3.4.1.slim.min.js\" integrity=\"sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n\" crossorigin=\"anonymous\"></script>\r\n\r\n\t");
#nullable restore
#line 70 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Shared\_layout.cshtml"
Write(RenderSection("Scripts",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t<footer class=\"py-5 bg-dark text-white text-center \">\r\n    Arda App || Tüm  Hakları Saklıdır\r\n</footer>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591