#pragma checksum "D:\ProductManager\ProductManager\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a04992df916f0d2153202ec79cd1a1f6a00e3f09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a04992df916f0d2153202ec79cd1a1f6a00e3f09", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\ProductManager\ProductManager\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome to NuclearBlast CD Shop</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>


<div class=""container pb-5 mb-sm-1"">
    <!-- Categories grid-->
    <div class=""row"">
");
#nullable restore
#line 16 "D:\ProductManager\ProductManager\Pages\Index.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 col-sm-6\">\r\n                <div class=\"card border-0 mb-grid-gutter\">\r\n                    <a class=\"card-img-tiles\" href=\"#\">\r\n                        <div class=\"main-img\"><img");
            BeginWriteAttribute("src", " src=\"", 674, "\"", 694, 1);
#nullable restore
#line 21 "D:\ProductManager\ProductManager\Pages\Index.cshtml"
WriteAttributeValue("", 680, product.Image, 680, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Clothing\"></div>\r\n                        <div class=\"thumblist\"><img");
            BeginWriteAttribute("src", " src=\"", 770, "\"", 790, 1);
#nullable restore
#line 22 "D:\ProductManager\ProductManager\Pages\Index.cshtml"
WriteAttributeValue("", 776, product.Image, 776, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Bags\"><img");
            BeginWriteAttribute("src", " src=\"", 807, "\"", 827, 1);
#nullable restore
#line 22 "D:\ProductManager\ProductManager\Pages\Index.cshtml"
WriteAttributeValue("", 813, product.Image, 813, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Bags\"></div>\r\n                    </a>\r\n                    <div class=\"card-body border mt-n1 py-4 text-center\">\r\n                        <h2 class=\"h5 mb-1\">");
#nullable restore
#line 25 "D:\ProductManager\ProductManager\Pages\Index.cshtml"
                                       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <span class=\"d-block mb-3 font-size-xs text-muted\"><span class=\"font-weight-semibold\">");
#nullable restore
#line 26 "D:\ProductManager\ProductManager\Pages\Index.cshtml"
                                                                                                         Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\r\n                        <a class=\"btn btn-pill btn-outline-primary btn-sm\" href=\"#\">More info</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 31 "D:\ProductManager\ProductManager\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductManager.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductManager.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductManager.Pages.IndexModel>)PageContext?.ViewData;
        public ProductManager.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
