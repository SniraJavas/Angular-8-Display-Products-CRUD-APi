#pragma checksum "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "646b78f58f4b6571dbe391126c267b05027dd4ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"646b78f58f4b6571dbe391126c267b05027dd4ee", @"/Views/Products/Details.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApiDataOrbis.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDescriptionOriginal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductDescriptionOriginal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductBarcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductBarcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rowchecksum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rowchecksum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1800, "\"", 1832, 1);
#nullable restore
#line 58 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Details.cshtml"
WriteAttributeValue("", 1815, Model.ProductsID, 1815, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApiDataOrbis.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
