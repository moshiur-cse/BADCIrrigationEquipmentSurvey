#pragma checksum "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37ea12ef49c0fa775400ed6975d62bdc7e856c0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kharif1SurveyInfo_Details), @"mvc.1.0.view", @"/Views/Kharif1SurveyInfo/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kharif1SurveyInfo/Details.cshtml", typeof(AspNetCore.Views_Kharif1SurveyInfo_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37ea12ef49c0fa775400ed6975d62bdc7e856c0a", @"/Views/Kharif1SurveyInfo/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18840fcd0f6dc65e539ad3db3277a2f6527ee2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Kharif1SurveyInfo_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BADCIrrigationEquipmentSurvey.Models.DataModels.Kharif1SurveyInfo>
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
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(166, 131, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Kharif1SurveyInfo</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(298, 54, false);
#line 15 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalOperatingHour));

#line default
#line hidden
            EndContext();
            BeginContext(352, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(396, 50, false);
#line 18 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalOperatingHour));

#line default
#line hidden
            EndContext();
            BeginContext(446, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(490, 43, false);
#line 21 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AusArea));

#line default
#line hidden
            EndContext();
            BeginContext(533, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(577, 39, false);
#line 24 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.AusArea));

#line default
#line hidden
            EndContext();
            BeginContext(616, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(660, 44, false);
#line 27 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JuteArea));

#line default
#line hidden
            EndContext();
            BeginContext(704, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(748, 40, false);
#line 30 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.JuteArea));

#line default
#line hidden
            EndContext();
            BeginContext(788, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(832, 43, false);
#line 33 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VegArea));

#line default
#line hidden
            EndContext();
            BeginContext(875, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(919, 39, false);
#line 36 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.VegArea));

#line default
#line hidden
            EndContext();
            BeginContext(958, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1002, 46, false);
#line 39 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1092, 42, false);
#line 42 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1178, 43, false);
#line 45 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AusCost));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1265, 39, false);
#line 48 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.AusCost));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1348, 44, false);
#line 51 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JuteCost));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1436, 40, false);
#line 54 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.JuteCost));

#line default
#line hidden
            EndContext();
            BeginContext(1476, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1520, 43, false);
#line 57 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VegCost));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1607, 39, false);
#line 60 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.VegCost));

#line default
#line hidden
            EndContext();
            BeginContext(1646, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1690, 46, false);
#line 63 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OthersCost));

#line default
#line hidden
            EndContext();
            BeginContext(1736, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1780, 42, false);
#line 66 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.OthersCost));

#line default
#line hidden
            EndContext();
            BeginContext(1822, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1866, 55, false);
#line 69 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(1921, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1965, 51, false);
#line 72 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(2016, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2060, 66, false);
#line 75 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(2126, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2170, 62, false);
#line 78 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(2232, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2276, 54, false);
#line 81 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UseInKharif2Season));

#line default
#line hidden
            EndContext();
            BeginContext(2330, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2374, 50, false);
#line 84 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.UseInKharif2Season));

#line default
#line hidden
            EndContext();
            BeginContext(2424, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2471, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ef4c89e2ade4df388f661176fdf13ef", async() => {
                BeginContext(2530, 4, true);
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
#line 89 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Details.cshtml"
                           WriteLiteral(Model.SurveyKharif1Id);

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
            BeginContext(2538, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2546, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fb9607ce4b04772bb71634cfeca1f83", async() => {
                BeginContext(2568, 12, true);
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
            BeginContext(2584, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BADCIrrigationEquipmentSurvey.Models.DataModels.Kharif1SurveyInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
