#pragma checksum "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Product\listcs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7592cb3f7c37e9db88539fc73e257c633e9ee54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_listcs), @"mvc.1.0.view", @"/Views/Product/listcs.cshtml")]
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
#line 1 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Product\listcs.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Product\listcs.cshtml"
using shopapp.webui.WievModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7592cb3f7c37e9db88539fc73e257c633e9ee54", @"/Views/Product/listcs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"939a67bb250e2d80621aaf1d6e67572328004f12", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_listcs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductWievModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

	
	<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
	<script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n\t");
#nullable restore
#line 16 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Product\listcs.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\t\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Product\listcs.cshtml"
 if (@Model.Products.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"row\">\r\n\t\t<div class=\"col-md-12\">\r\n\r\n\t\t\t<div class=\"alert alert-danger\">Stokta yok</div>\r\n\t\t</div>\r\n\r\n\t</div>\r\n");
#nullable restore
#line 29 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Product\listcs.cshtml"

}

else
{



#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"row my-5\">\r\n");
#nullable restore
#line 37 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Product\listcs.cshtml"
         foreach (var p in Model.Products)
		{

		

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col md-4\">\r\n\t\t\t\t\t");
#nullable restore
#line 42 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Product\listcs.cshtml"
               Write(await Html.PartialAsync("_product",p));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 45 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Product\listcs.cshtml"

			
			

		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n");
#nullable restore
#line 51 "C:\Users\Arda\Desktop\shopapp\shopapp.webui\Views\Product\listcs.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\r\n\t\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductWievModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
