#pragma checksum "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "004070ca42ce47a0ad167c5dbfd2871e7b4a8259"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Create), @"mvc.1.0.view", @"/Views/Products/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"004070ca42ce47a0ad167c5dbfd2871e7b4a8259", @"/Views/Products/Create.cshtml")]
    public class Views_Products_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApiDataOrbis.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Product</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""ProductCode"" class=""control-label""></label>
                <input asp-for=""ProductCode"" class=""form-control"" />
                <span asp-validation-for=""ProductCode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductDescriptionOriginal"" class=""control-label""></label>
                <input asp-for=""ProductDescriptionOriginal"" class=""form-control"" />
                <span asp-validation-for=""ProductDescriptionOriginal"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductDescription"" class=""control-label""></label>
                <input asp-for=""ProductDescription"" class=""form-contr");
            WriteLiteral(@"ol"" />
                <span asp-validation-for=""ProductDescription"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductCategory"" class=""control-label""></label>
                <input asp-for=""ProductCategory"" class=""form-control"" />
                <span asp-validation-for=""ProductCategory"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductStatus"" class=""control-label""></label>
                <input asp-for=""ProductStatus"" class=""form-control"" />
                <span asp-validation-for=""ProductStatus"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductBarcode"" class=""control-label""></label>
                <input asp-for=""ProductBarcode"" class=""form-control"" />
                <span asp-validation-for=""ProductBarcode"" class=""text-danger""></span>
            </div>
           ");
            WriteLiteral(@" <div class=""form-group"">
                <label asp-for=""Rowchecksum"" class=""control-label""></label>
                <input asp-for=""Rowchecksum"" class=""form-control"" />
                <span asp-validation-for=""Rowchecksum"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\Sinikiwe Jumba\source\repos\WebApiDataOrbis\Views\Products\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
