#pragma checksum "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dea1db0cf4be33670e2239d7ecb6e9412c55ec7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OtherSurveyInfoesP_Details), @"mvc.1.0.view", @"/Views/OtherSurveyInfoesP/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OtherSurveyInfoesP/Details.cshtml", typeof(AspNetCore.Views_OtherSurveyInfoesP_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea1db0cf4be33670e2239d7ecb6e9412c55ec7a", @"/Views/OtherSurveyInfoesP/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18840fcd0f6dc65e539ad3db3277a2f6527ee2c", @"/Views/_ViewImports.cshtml")]
    public class Views_OtherSurveyInfoesP_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BADCIrrigationEquipmentSurvey.Models.DataModels.OtherSurveyInfo>
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
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(164, 129, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>OtherSurveyInfo</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(294, 49, false);
#line 15 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EquipmentInfo));

#line default
#line hidden
            EndContext();
            BeginContext(343, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(387, 61, false);
#line 18 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.EquipmentInfo.NameOfEquipment));

#line default
#line hidden
            EndContext();
            BeginContext(448, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(492, 48, false);
#line 21 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DistrictInfo));

#line default
#line hidden
            EndContext();
            BeginContext(540, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(584, 53, false);
#line 24 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.DistrictInfo.DistCode));

#line default
#line hidden
            EndContext();
            BeginContext(637, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(681, 47, false);
#line 27 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpazilaInfo));

#line default
#line hidden
            EndContext();
            BeginContext(728, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(772, 52, false);
#line 30 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpazilaInfo.UpazCode));

#line default
#line hidden
            EndContext();
            BeginContext(824, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(868, 46, false);
#line 33 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyDate));

#line default
#line hidden
            EndContext();
            BeginContext(914, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(958, 42, false);
#line 36 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveyDate));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1044, 48, false);
#line 39 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RobiBoroArea));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1136, 44, false);
#line 42 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.RobiBoroArea));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1224, 49, false);
#line 45 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RobiWheatArea));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1317, 45, false);
#line 48 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.RobiWheatArea));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1406, 50, false);
#line 51 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RobiPotatoArea));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1500, 46, false);
#line 54 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.RobiPotatoArea));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1590, 49, false);
#line 57 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RobiMaizeArea));

#line default
#line hidden
            EndContext();
            BeginContext(1639, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1683, 45, false);
#line 60 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.RobiMaizeArea));

#line default
#line hidden
            EndContext();
            BeginContext(1728, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1772, 53, false);
#line 63 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RobiVegWinterArea));

#line default
#line hidden
            EndContext();
            BeginContext(1825, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1869, 49, false);
#line 66 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.RobiVegWinterArea));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1962, 51, false);
#line 69 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RobiMustardArea));

#line default
#line hidden
            EndContext();
            BeginContext(2013, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2057, 47, false);
#line 72 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.RobiMustardArea));

#line default
#line hidden
            EndContext();
            BeginContext(2104, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2148, 50, false);
#line 75 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RobiOthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(2198, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2242, 46, false);
#line 78 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.RobiOthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(2288, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2332, 59, false);
#line 81 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RobiBenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(2391, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2435, 55, false);
#line 84 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.RobiBenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(2490, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2534, 70, false);
#line 87 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RobiBenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(2604, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2648, 66, false);
#line 90 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.RobiBenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(2714, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2758, 50, false);
#line 93 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kharif1AusArea));

#line default
#line hidden
            EndContext();
            BeginContext(2808, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2852, 46, false);
#line 96 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.Kharif1AusArea));

#line default
#line hidden
            EndContext();
            BeginContext(2898, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2942, 51, false);
#line 99 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kharif1JuteArea));

#line default
#line hidden
            EndContext();
            BeginContext(2993, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3037, 47, false);
#line 102 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.Kharif1JuteArea));

#line default
#line hidden
            EndContext();
            BeginContext(3084, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3128, 56, false);
#line 105 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kharif1VegSummerArea));

#line default
#line hidden
            EndContext();
            BeginContext(3184, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3228, 52, false);
#line 108 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.Kharif1VegSummerArea));

#line default
#line hidden
            EndContext();
            BeginContext(3280, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3324, 53, false);
#line 111 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kharif1OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(3377, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3421, 49, false);
#line 114 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.Kharif1OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(3470, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3514, 62, false);
#line 117 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kharif1BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(3576, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3620, 58, false);
#line 120 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.Kharif1BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(3678, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3722, 73, false);
#line 123 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kharif1BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(3795, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3839, 69, false);
#line 126 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.Kharif1BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(3908, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3952, 52, false);
#line 129 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kharif2TAmanArea));

#line default
#line hidden
            EndContext();
            BeginContext(4004, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4048, 48, false);
#line 132 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.Kharif2TAmanArea));

#line default
#line hidden
            EndContext();
            BeginContext(4096, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4140, 53, false);
#line 135 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kharif2OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(4193, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4237, 49, false);
#line 138 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.Kharif2OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(4286, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4330, 62, false);
#line 141 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kharif2BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(4392, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4436, 58, false);
#line 144 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.Kharif2BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(4494, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4538, 73, false);
#line 147 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kharif2BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(4611, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4655, 69, false);
#line 150 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
       Write(Html.DisplayFor(model => model.Kharif2BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(4724, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(4771, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ff9c6c7d1fd4657a4bc663c40b68806", async() => {
                BeginContext(4828, 4, true);
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
#line 155 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoesP\Details.cshtml"
                           WriteLiteral(Model.OtherSurveyId);

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
            BeginContext(4836, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(4844, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9c6162477a840b5a5fa532f196efbfb", async() => {
                BeginContext(4866, 12, true);
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
            BeginContext(4882, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BADCIrrigationEquipmentSurvey.Models.DataModels.OtherSurveyInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
