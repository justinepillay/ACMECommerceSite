#pragma checksum "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\19002561_PROG_TASK_2\Project\AcmeIncWeb\AcmeIncWeb\Views\Product\CartDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "878dabe92b3c91decc6ab190860df9128a5987db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_CartDetails), @"mvc.1.0.view", @"/Views/Product/CartDetails.cshtml")]
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
#line 1 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\19002561_PROG_TASK_2\Project\AcmeIncWeb\AcmeIncWeb\Views\_ViewImports.cshtml"
using AcmeIncWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\19002561_PROG_TASK_2\Project\AcmeIncWeb\AcmeIncWeb\Views\_ViewImports.cshtml"
using AcmeIncWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878dabe92b3c91decc6ab190860df9128a5987db", @"/Views/Product/CartDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"208c85b1cde642e931b70358151d64161c2293ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_CartDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AcmeIncWeb.Models.Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/buttons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("gradient-button gradient-button-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\19002561_PROG_TASK_2\Project\AcmeIncWeb\AcmeIncWeb\Views\Product\CartDetails.cshtml"
  
    ViewData["Title"] = "Cart Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "878dabe92b3c91decc6ab190860df9128a5987db5396", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\19002561_PROG_TASK_2\Project\AcmeIncWeb\AcmeIncWeb\Views\Product\CartDetails.cshtml"
  

    if (!(Model == null))
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-info mb-3\">\r\n            <h3 class=\"card-header\">Your Cart</h3>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\19002561_PROG_TASK_2\Project\AcmeIncWeb\AcmeIncWeb\Views\Product\CartDetails.cshtml"
                                  Write(Model.Prod.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h6 class=\"card-subtitle text-muted\">Qty: 1</h6>\r\n            </div>\r\n\r\n            <div>\r\n                <center>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 534, "\"", 560, 1);
#nullable restore
#line 22 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\19002561_PROG_TASK_2\Project\AcmeIncWeb\AcmeIncWeb\Views\Product\CartDetails.cshtml"
WriteAttributeValue("", 540, Model.Prod.ImageUrl, 540, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\" height:auto; width:150px\" />\r\n                </center>\r\n            </div>\r\n\r\n            <div class=\"card-body\">\r\n                <p class=\"card-text\">");
#nullable restore
#line 27 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\19002561_PROG_TASK_2\Project\AcmeIncWeb\AcmeIncWeb\Views\Product\CartDetails.cshtml"
                                Write(Model.Prod.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <ul class=\"list-group list-group-flush\">\r\n                <li class=\"list-group-item\">");
#nullable restore
#line 30 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\19002561_PROG_TASK_2\Project\AcmeIncWeb\AcmeIncWeb\Views\Product\CartDetails.cshtml"
                                       Write(Model.Prod.Cat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n            <div class=\"card-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "878dabe92b3c91decc6ab190860df9128a5987db8934", async() => {
                WriteLiteral("Check Out");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-footer text-muted\">\r\n                ACME INC\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 39 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\19002561_PROG_TASK_2\Project\AcmeIncWeb\AcmeIncWeb\Views\Product\CartDetails.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>You have no items in your cart.</p>\r\n");
#nullable restore
#line 43 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\19002561_PROG_TASK_2\Project\AcmeIncWeb\AcmeIncWeb\Views\Product\CartDetails.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AcmeIncWeb.Models.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
