#pragma checksum "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f886af1d2220313311e0087797358c36b862be0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 1 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\_ViewImports.cshtml"
using Pulp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\_ViewImports.cshtml"
using Pulp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f886af1d2220313311e0087797358c36b862be0d", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f868726f9d7a640d640a690ec4ec40c97eff764a", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pulp.ViewModels.OrderItemCategoryItem>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Businesses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:16em;width:22em;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger col-5 my-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrderItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger col-5 my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning col-8 text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Buyers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#7BB38E"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n");
#nullable restore
#line 6 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<div class=\"container\">\n    <h1 class=\"text-center mt-3\" style=\"color:#7BB38E\">Cart</h1>\n");
#nullable restore
#line 13 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
     if (Model.Message != null)
    {
        if (Model.flag == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\n    ");
#nullable restore
#line 18 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div> ");
#nullable restore
#line 19 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
       }
else if (Model.flag == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\n    ");
#nullable restore
#line 23 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
#nullable restore
#line 24 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
      }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid\">\n");
#nullable restore
#line 27 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
           List<Order> tempList = new List<Order>();

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
         if (User.Identity.IsAuthenticated && User.IsInRole("Fulfiller"))
        {
            tempList = Model.AllOrdersForAdmins;
        }
        else
        {
            tempList = Model.OrdersList;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
#nullable restore
#line 39 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
         if (tempList.Count < 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"border rounded shadow text-center \">\n    <h1>Empty Cart</h1>\n    <p>Try Our Service and Order Now! </p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f886af1d2220313311e0087797358c36b862be0d12071", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div> ");
#nullable restore
#line 45 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
       }
else
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
 foreach (var item in tempList)
{




#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"m-3 col-7\">\n\n\n\n\n");
#nullable restore
#line 58 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
     foreach (var orderedItem in item.OrderItems)
    {



        var photoPath = "~/images/" + (orderedItem.ItemOrdered.PictureUri);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-6\">\n\n\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f886af1d2220313311e0087797358c36b862be0d14391", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 69 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    <div class=\"col-6\">\n");
#nullable restore
#line 72 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
         if (item.orderStatus == OrderStatus.Approved)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-success alert-dismissible fade show \">\n    Order Approved\n</div> ");
#nullable restore
#line 76 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
       }
else if (item.orderStatus == OrderStatus.Cancled)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger alert-dismissible fade show \">\n    Order Cancle.. Please Check your Email !!\n</div> ");
#nullable restore
#line 81 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
       }
else if (item.orderStatus == OrderStatus.Waiting)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-warning alert-dismissible fade show \">\n    Waiting For Approval......\n</div> ");
#nullable restore
#line 86 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
       }
else if (item.orderStatus == OrderStatus.WaitingPayed)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-warning alert-dismissible fade show \">\n    Payment is Done .. Waiting for Address Confirmation\n</div> ");
#nullable restore
#line 91 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
       }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-info alert-dismissible fade show \">\n    Please Confirm Order ......\n</div>");
#nullable restore
#line 96 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>");
#nullable restore
#line 97 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
       Write(orderedItem.ItemOrdered.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <p>");
#nullable restore
#line 98 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
      Write(orderedItem.ItemOrdered.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
#nullable restore
#line 99 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
      Write(orderedItem.Units);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>pieces</span></p>\n        <div>\n            ");
#nullable restore
#line 101 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
       Write(orderedItem.ItemOrdered.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>E&pound;</span> For one\n            <p>\n                Total : ");
#nullable restore
#line 103 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                          decimal p = @orderedItem.Price;
                    int u = orderedItem.Units;
                    decimal res = p * u; 

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 105 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                                      Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n                <div class=\"row ml-1\">\n");
#nullable restore
#line 108 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                     if (User.Identity.IsAuthenticated && !User.IsInRole("Fulfiller") && item.orderStatus != OrderStatus.Waiting && item.orderStatus != OrderStatus.WaitingPayed)
                    {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f886af1d2220313311e0087797358c36b862be0d21209", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                                                                                       WriteLiteral(orderedItem.OrderItemID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 110 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                                                                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n");
#nullable restore
#line 115 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Fulfiller"))
                    {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f886af1d2220313311e0087797358c36b862be0d24367", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                                                                                       WriteLiteral(orderedItem.OrderItemID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f886af1d2220313311e0087797358c36b862be0d26955", async() => {
                WriteLiteral("Customer Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                                                                                                                       WriteLiteral(item.BuyerID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("                                                        <input type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3639, "\"", 3670, 3);
            WriteAttributeValue("", 3649, "postMe(", 3649, 7, true);
#nullable restore
#line 125 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
WriteAttributeValue("", 3656, item.OrderID, 3656, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3669, ")", 3669, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning col-8 mt-3 text-light\" value=\"Approve Order\" style=\"background-color:#7BB38E\" />");
#nullable restore
#line 125 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                                                                                                                                                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n\n\n\n\n            </div>\n        </div>\n    </div>");
#nullable restore
#line 133 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n</div>");
#nullable restore
#line 138 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                 if (User.Identity.IsAuthenticated && !User.IsInRole("Fulfiller"))
                {

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
 if (tempList.Count > 0)
{
    if (Model.flag != 2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-5 m-auto my-1\">\n    <p>Order: ");
#nullable restore
#line 147 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
         Write(Model.subTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>E&pound;</span></p>\n    <p>Taxes: ");
#nullable restore
#line 148 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
         Write(Model.taxes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>E&pound;</span></p>\n    <p>Delivery Fees : ");
#nullable restore
#line 149 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                  Write(Model.delivery);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>E&pound;</span></p>\n    <p>Total Price : ");
#nullable restore
#line 150 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                Write(Model.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>E&pound;</span></p>\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f886af1d2220313311e0087797358c36b862be0d33180", async() => {
                WriteLiteral("\n        <input type=\"hidden\" name=\"total\"");
                BeginWriteAttribute("value", " value=\"", 4585, "\"", 4605, 1);
#nullable restore
#line 153 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
WriteAttributeValue("", 4593, Model.total, 4593, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n        <input type=\"submit\" class=\"btn btn-outline-success border border-success mb-5 text-light\" value=\"Confirm order\" style=\"        background-color: #7BB38E\n\" />\n\n\n\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 152 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
                                                                           WriteLiteral(Model.BuyerID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n   </div>\n</div>\n");
#nullable restore
#line 162 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
        }
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n<script>\n   // alert(\'lll\');\n    async function postMe(id) {\n       // alert(\'kk\')\n        await $.ajax({\n            url: \"");
#nullable restore
#line 171 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Views\Orders\Index.cshtml"
             Write(Url.Action("ApproveOrder"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { id: id },
            method: ""POST"",
            success: function (rs) {
                console.log(id);

            },
            error: function (x, y, err) {
                console.log(err);
            }
        });


        location.reload();

    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pulp.ViewModels.OrderItemCategoryItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
