#pragma checksum "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\Shared\Components\FeaturedProducts\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "501ac01b4c084bca9535253ce968181e7c3c6db7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FeaturedProducts_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FeaturedProducts/Default.cshtml")]
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
#line 1 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\_ViewImports.cshtml"
using Web.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\_ViewImports.cshtml"
using Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"501ac01b4c084bca9535253ce968181e7c3c6db7", @"/Views/Shared/Components/FeaturedProducts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b09aee315edf4d24c0974ce02e1ba97d68ac10e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FeaturedProducts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hover-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\Shared\Components\FeaturedProducts\Default.cshtml"
 foreach (var pro in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Single Prodect -->\r\n    <div class=\"new-product-item swiper-slide\">\r\n        <div class=\"product\">\r\n            <div class=\"thumb\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 214, "\"", 246, 2);
            WriteAttributeValue("", 221, "/products/details/", 221, 18, true);
#nullable restore
#line 8 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\Shared\Components\FeaturedProducts\Default.cshtml"
WriteAttributeValue("", 239, pro.ID, 239, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "501ac01b4c084bca9535253ce968181e7c3c6db75393", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 294, "~/", 294, 2, true);
#nullable restore
#line 9 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\Shared\Components\FeaturedProducts\Default.cshtml"
AddHtmlAttributeValue("", 296, pro.ProductPictures[0].Picture.URL, 296, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "501ac01b4c084bca9535253ce968181e7c3c6db77020", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 401, "~/", 401, 2, true);
#nullable restore
#line 10 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\Shared\Components\FeaturedProducts\Default.cshtml"
AddHtmlAttributeValue("", 403, pro.ProductPictures[1].Picture.URL, 403, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </a>
                <span class=""badges"">
                    <span class=""sale"">-10%</span>
                    <span class=""new"">New</span>
                </span>
                <div class=""actions"">
                    <a href=""wishlist.html"" class=""action wishlist"" title=""Wishlist"">
                        <i class=""icon-heart""></i>
                    </a>
                    <a href=""#"" class=""action quickview"" data-link-action=""quickview"" title=""Quick view"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">
                        <i class=""icon-size-fullscreen""></i>
                    </a>
                    <a href=""compare.html"" class=""action compare"" title=""Compare"">
                        <i class=""icon-refresh""></i>
                    </a>
                </div>
                <button title=""Add To Cart"" class="" add-to-cart"">
                    Add
                    To Cart
                </button>
            </div>
            <div class=""c");
            WriteLiteral("ontent\">\r\n                <h5 class=\"title\"><a");
            BeginWriteAttribute("href", " href=\"", 1526, "\"", 1558, 2);
            WriteAttributeValue("", 1533, "/products/details/", 1533, 18, true);
#nullable restore
#line 33 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\Shared\Components\FeaturedProducts\Default.cshtml"
WriteAttributeValue("", 1551, pro.ID, 1551, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\Shared\Components\FeaturedProducts\Default.cshtml"
                                                                 Write(pro.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                <span class=\"price\">\r\n                    <span class=\"new\">");
#nullable restore
#line 35 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\Shared\Components\FeaturedProducts\Default.cshtml"
                                 Write(pro.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"old\">");
#nullable restore
#line 36 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\Shared\Components\FeaturedProducts\Default.cshtml"
                                 Write(pro.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 41 "D:\Compar\compar academy\ASP\Ecommerce Web\Ecommerce\Web\Views\Shared\Components\FeaturedProducts\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591