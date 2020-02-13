#pragma checksum "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "839643a004861fedfd53610875cd3d728f526c95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Shop), @"mvc.1.0.view", @"/Views/Home/Shop.cshtml")]
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
#line 1 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\_ViewImports.cshtml"
using CoffeeShopLab23;

#line default
#line hidden
#line 2 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\_ViewImports.cshtml"
using CoffeeShopLab23.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"839643a004861fedfd53610875cd3d728f526c95", @"/Views/Home/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf61ab4a4118ea162c5413b50a923b0a25e91479", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopDbContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BUY", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#line 5 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml"
  
    ViewData["Title"] = "Shop";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var shoppingItems = (List<Items>)Model.Items.ToList();
    var userIds = (List<Users>)Model.Users.ToList();

#line default
#line hidden
            WriteLiteral("\r\n\r\n<h1>Shop</h1>\r\n\r\n<table class=\"table\">\r\n\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Name</th>\r\n        <th>Description</th>\r\n        <th>Price</th>\r\n\r\n\r\n    </tr>\r\n  \r\n");
#line 26 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml"
         foreach (Items Item in shoppingItems)
        {

#line default
#line hidden
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "839643a004861fedfd53610875cd3d728f526c954576", async() => {
                WriteLiteral("\r\n                <tr>\r\n                    <td>");
#line 30 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml"
                   Write(Item.Id);

#line default
#line hidden
                WriteLiteral(" </td>\r\n                    <td>");
#line 31 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml"
                   Write(Item.Name);

#line default
#line hidden
                WriteLiteral(" </td>\r\n                    <td>");
#line 32 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml"
                   Write(Item.Description);

#line default
#line hidden
                WriteLiteral("</td>\r\n                    <td>");
#line 33 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml"
                   Write(Item.Price);

#line default
#line hidden
                WriteLiteral(" </td>\r\n\r\n                    <!--use the name attribute to map this text input to our parameter in the back end controller-->\r\n");
                WriteLiteral("\r\n");
#line 38 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml"
                     if ((bool)TempData["isUserLogin"] == true)
                    {

#line default
#line hidden
                WriteLiteral("                        <td><input type=\"number\" name=\"quantity\" min=\"1\" max=\"5\"></td>\r\n                        <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1158, "\"", 1174, 1);
#line 41 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml"
WriteAttributeValue("", 1166, Item.Id, 1166, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 1236, "\"", 1254, 1);
#line 42 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml"
WriteAttributeValue("", 1244, Item.Name, 1244, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"Description\"");
                BeginWriteAttribute("value", " value=\"", 1323, "\"", 1348, 1);
#line 43 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml"
WriteAttributeValue("", 1331, Item.Description, 1331, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"Price\"");
                BeginWriteAttribute("value", " value=\"", 1411, "\"", 1431, 2);
#line 44 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml"
WriteAttributeValue("", 1419, Item.Price, 1419, 11, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1430, "", 1431, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 1495, "\"", 1503, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <td><input type=\"submit\" /></td>\r\n");
#line 47 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml"
                    }
                    

#line default
#line hidden
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#line 52 "C:\Users\rtobia\source\repos\CoffeeShopLab23\CoffeeShop3\Views\Home\Shop.cshtml"


        }

#line default
#line hidden
            WriteLiteral("    </tr>\r\n\r\n");
            WriteLiteral("</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopDbContext> Html { get; private set; }
    }
}
#pragma warning restore 1591