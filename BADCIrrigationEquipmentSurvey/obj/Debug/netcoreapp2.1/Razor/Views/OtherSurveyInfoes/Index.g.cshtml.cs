#pragma checksum "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ff3946a028fe429bf7e9d5b59dc3f9383fea5cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OtherSurveyInfoes_Index), @"mvc.1.0.view", @"/Views/OtherSurveyInfoes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OtherSurveyInfoes/Index.cshtml", typeof(AspNetCore.Views_OtherSurveyInfoes_Index))]
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
#line 1 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\_ViewImports.cshtml"
using BADCIrrigationEquipmentSurvey;

#line default
#line hidden
#line 3 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\_ViewImports.cshtml"
using BADCIrrigationEquipmentSurvey.Models;

#line default
#line hidden
#line 4 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\_ViewImports.cshtml"
using BADCIrrigationEquipmentSurvey.Models.BasicModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ff3946a028fe429bf7e9d5b59dc3f9383fea5cf", @"/Views/OtherSurveyInfoes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18840fcd0f6dc65e539ad3db3277a2f6527ee2c", @"/Views/_ViewImports.cshtml")]
    public class Views_OtherSurveyInfoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BADCIrrigationEquipmentSurvey.Models.DataModels.OtherSurveyInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(175, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(204, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f327b000324d959fe63ab05469bc91", async() => {
                BeginContext(227, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(241, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(334, 49, false);
#line 17 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EquipmentInfo));

#line default
#line hidden
            EndContext();
            BeginContext(383, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(439, 48, false);
#line 20 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DistrictInfo));

#line default
#line hidden
            EndContext();
            BeginContext(487, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(543, 47, false);
#line 23 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpazilaInfo));

#line default
#line hidden
            EndContext();
            BeginContext(590, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(646, 46, false);
#line 26 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SurveyDate));

#line default
#line hidden
            EndContext();
            BeginContext(692, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(748, 48, false);
#line 29 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RobiBoroArea));

#line default
#line hidden
            EndContext();
            BeginContext(796, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(852, 49, false);
#line 32 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RobiWheatArea));

#line default
#line hidden
            EndContext();
            BeginContext(901, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(957, 50, false);
#line 35 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RobiPotatoArea));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1063, 49, false);
#line 38 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RobiMaizeArea));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1168, 53, false);
#line 41 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RobiVegWinterArea));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1277, 51, false);
#line 44 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RobiMustardArea));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1384, 50, false);
#line 47 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RobiOthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1490, 59, false);
#line 50 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RobiBenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1605, 70, false);
#line 53 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RobiBenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(1675, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1731, 50, false);
#line 56 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kharif1AusArea));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1837, 51, false);
#line 59 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kharif1JuteArea));

#line default
#line hidden
            EndContext();
            BeginContext(1888, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1944, 56, false);
#line 62 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kharif1VegSummerArea));

#line default
#line hidden
            EndContext();
            BeginContext(2000, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2056, 53, false);
#line 65 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kharif1OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(2109, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2165, 62, false);
#line 68 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kharif1BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(2227, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2283, 73, false);
#line 71 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kharif1BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(2356, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2412, 52, false);
#line 74 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kharif2TAmanArea));

#line default
#line hidden
            EndContext();
            BeginContext(2464, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2520, 53, false);
#line 77 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kharif2OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(2573, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2629, 62, false);
#line 80 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kharif2BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(2691, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2747, 73, false);
#line 83 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kharif2BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(2820, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 89 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2938, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2987, 64, false);
#line 92 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EquipmentInfo.NameOfEquipment));

#line default
#line hidden
            EndContext();
            BeginContext(3051, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3107, 56, false);
#line 95 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DistrictInfo.DistCode));

#line default
#line hidden
            EndContext();
            BeginContext(3163, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3219, 55, false);
#line 98 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpazilaInfo.UpazCode));

#line default
#line hidden
            EndContext();
            BeginContext(3274, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3330, 45, false);
#line 101 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SurveyDate));

#line default
#line hidden
            EndContext();
            BeginContext(3375, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3431, 47, false);
#line 104 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RobiBoroArea));

#line default
#line hidden
            EndContext();
            BeginContext(3478, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3534, 48, false);
#line 107 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RobiWheatArea));

#line default
#line hidden
            EndContext();
            BeginContext(3582, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3638, 49, false);
#line 110 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RobiPotatoArea));

#line default
#line hidden
            EndContext();
            BeginContext(3687, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3743, 48, false);
#line 113 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RobiMaizeArea));

#line default
#line hidden
            EndContext();
            BeginContext(3791, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3847, 52, false);
#line 116 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RobiVegWinterArea));

#line default
#line hidden
            EndContext();
            BeginContext(3899, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3955, 50, false);
#line 119 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RobiMustardArea));

#line default
#line hidden
            EndContext();
            BeginContext(4005, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4061, 49, false);
#line 122 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RobiOthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(4110, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4166, 58, false);
#line 125 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RobiBenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(4224, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4280, 69, false);
#line 128 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RobiBenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(4349, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4405, 49, false);
#line 131 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kharif1AusArea));

#line default
#line hidden
            EndContext();
            BeginContext(4454, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4510, 50, false);
#line 134 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kharif1JuteArea));

#line default
#line hidden
            EndContext();
            BeginContext(4560, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4616, 55, false);
#line 137 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kharif1VegSummerArea));

#line default
#line hidden
            EndContext();
            BeginContext(4671, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4727, 52, false);
#line 140 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kharif1OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(4779, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4835, 61, false);
#line 143 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kharif1BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(4896, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4952, 72, false);
#line 146 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kharif1BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(5024, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5080, 51, false);
#line 149 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kharif2TAmanArea));

#line default
#line hidden
            EndContext();
            BeginContext(5131, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5187, 52, false);
#line 152 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kharif2OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(5239, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5295, 61, false);
#line 155 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kharif2BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(5356, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5412, 72, false);
#line 158 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kharif2BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(5484, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5539, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77ca5b3bf9294124ab8e30007ce95e29", async() => {
                BeginContext(5595, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 161 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
                                       WriteLiteral(item.OtherSurveyId);

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
            BeginContext(5603, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(5623, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8248e4cd53d641a5abafd7cb38aae74d", async() => {
                BeginContext(5682, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 162 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
                                          WriteLiteral(item.OtherSurveyId);

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
            BeginContext(5693, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(5713, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd31c55ce9e34e829c8081a5edc9fd37", async() => {
                BeginContext(5771, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 163 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
                                         WriteLiteral(item.OtherSurveyId);

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
            BeginContext(5781, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 166 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\OtherSurveyInfoes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(5820, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BADCIrrigationEquipmentSurvey.Models.DataModels.OtherSurveyInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
