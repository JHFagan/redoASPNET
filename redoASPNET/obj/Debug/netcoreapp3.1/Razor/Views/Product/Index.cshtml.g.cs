#pragma checksum "C:\Users\jhfag\Desktop\Repos\redoASPNET\redoASPNET\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9cba85f612b1672b085cda088d2671f5bec7726"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\jhfag\Desktop\Repos\redoASPNET\redoASPNET\Views\_ViewImports.cshtml"
using redoASPNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jhfag\Desktop\Repos\redoASPNET\redoASPNET\Views\_ViewImports.cshtml"
using redoASPNET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9cba85f612b1672b085cda088d2671f5bec7726", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a537186111289f7550dd21ab7ca63cd4b9360f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Products</h2>
<div style=""display: block"">
    <a href=""/Product/InsertProduct/"">Create a New Product</a>
</div>

<table class=""table"">
    <tr>
        <th>ID</th>
        <th>Name</th>
        <th>Price</th>
        <th>Category</th>
        <th>On Sale</th>
        <th>Stock Level</th>
    </tr>

");
#nullable restore
#line 18 "C:\Users\jhfag\Desktop\Repos\redoASPNET\redoASPNET\Views\Product\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><a");
            BeginWriteAttribute("href", " href=", 427, "", 472, 2);
            WriteAttributeValue("", 433, "/Product/ViewProduct/", 433, 21, true);
#nullable restore
#line 21 "C:\Users\jhfag\Desktop\Repos\redoASPNET\redoASPNET\Views\Product\Index.cshtml"
WriteAttributeValue("", 454, product.ProductID, 454, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\jhfag\Desktop\Repos\redoASPNET\redoASPNET\Views\Product\Index.cshtml"
                                                           Write(product.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\jhfag\Desktop\Repos\redoASPNET\redoASPNET\Views\Product\Index.cshtml"
           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\jhfag\Desktop\Repos\redoASPNET\redoASPNET\Views\Product\Index.cshtml"
           Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\jhfag\Desktop\Repos\redoASPNET\redoASPNET\Views\Product\Index.cshtml"
           Write(product.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\jhfag\Desktop\Repos\redoASPNET\redoASPNET\Views\Product\Index.cshtml"
           Write(product.OnSale);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\jhfag\Desktop\Repos\redoASPNET\redoASPNET\Views\Product\Index.cshtml"
           Write(product.StockLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\jhfag\Desktop\Repos\redoASPNET\redoASPNET\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
