#pragma checksum "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e957ebf57b619641f7da473ececebe29b2d9ee8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserInfoes_Details), @"mvc.1.0.view", @"/Views/UserInfoes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserInfoes/Details.cshtml", typeof(AspNetCore.Views_UserInfoes_Details))]
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
#line 1 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\_ViewImports.cshtml"
using BADCIrrigationEquipmentSurvey;

#line default
#line hidden
#line 3 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\_ViewImports.cshtml"
using BADCIrrigationEquipmentSurvey.Models;

#line default
#line hidden
#line 4 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\_ViewImports.cshtml"
using BADCIrrigationEquipmentSurvey.Models.BasicModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e957ebf57b619641f7da473ececebe29b2d9ee8", @"/Views/UserInfoes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18840fcd0f6dc65e539ad3db3277a2f6527ee2c", @"/Views/_ViewImports.cshtml")]
    public class Views_UserInfoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BADCIrrigationEquipmentSurvey.Models.BadcAppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(149, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(156, 17, false);
#line 8 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(173, 110, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <h4>User Info</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(284, 42, false);
#line 15 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(326, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(370, 38, false);
#line 18 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(408, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(454, 40, false);
#line 22 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(494, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(538, 36, false);
#line 25 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(574, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(620, 47, false);
#line 29 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(667, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(711, 43, false);
#line 32 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(754, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(800, 44, false);
#line 36 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MobileNo));

#line default
#line hidden
            EndContext();
            BeginContext(844, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(888, 40, false);
#line 39 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.MobileNo));

#line default
#line hidden
            EndContext();
            BeginContext(928, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(974, 45, false);
#line 43 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1063, 41, false);
#line 46 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1104, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1150, 41, false);
#line 50 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1235, 37, false);
#line 53 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1318, 52, false);
#line 57 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TwoFactorEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1414, 48, false);
#line 60 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.TwoFactorEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(1462, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1508, 46, false);
#line 64 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnd));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1598, 42, false);
#line 67 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnd));

#line default
#line hidden
            EndContext();
            BeginContext(1640, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1686, 50, false);
#line 71 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(1736, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1780, 46, false);
#line 74 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(1826, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1872, 53, false);
#line 78 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AccessFailedCount));

#line default
#line hidden
            EndContext();
            BeginContext(1925, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1969, 49, false);
#line 81 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.AccessFailedCount));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2065, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85e82bab22c8466491def0e06a4d0f23", async() => {
                BeginContext(2111, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 86 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\UserInfoes\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2119, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2127, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81d92d016f3b437db6326ba718a9e63d", async() => {
                BeginContext(2149, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2165, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BADCIrrigationEquipmentSurvey.Models.BadcAppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
