#pragma checksum "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d5eec7714c24a0f2ffb8c1d2071fcc04a31f1b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kharif1SurveyInfo_Index), @"mvc.1.0.view", @"/Views/Kharif1SurveyInfo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kharif1SurveyInfo/Index.cshtml", typeof(AspNetCore.Views_Kharif1SurveyInfo_Index))]
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
#line 1 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\_ViewImports.cshtml"
using BADCIrrigationEquipmentSurvey;

#line default
#line hidden
#line 3 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\_ViewImports.cshtml"
using BADCIrrigationEquipmentSurvey.Models;

#line default
#line hidden
#line 4 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\_ViewImports.cshtml"
using BADCIrrigationEquipmentSurvey.Models.BasicModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d5eec7714c24a0f2ffb8c1d2071fcc04a31f1b2", @"/Views/Kharif1SurveyInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18840fcd0f6dc65e539ad3db3277a2f6527ee2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Kharif1SurveyInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BADCIrrigationEquipmentSurvey.Models.DataModels.Kharif1SurveyInfo>>
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
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(177, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(206, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4e381c5c32c486c98af4c17ebf05e70", async() => {
                BeginContext(229, 10, true);
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
            BeginContext(243, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(336, 54, false);
#line 17 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalOperatingHour));

#line default
#line hidden
            EndContext();
            BeginContext(390, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(446, 43, false);
#line 20 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AusArea));

#line default
#line hidden
            EndContext();
            BeginContext(489, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(545, 44, false);
#line 23 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JuteArea));

#line default
#line hidden
            EndContext();
            BeginContext(589, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(645, 43, false);
#line 26 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VegArea));

#line default
#line hidden
            EndContext();
            BeginContext(688, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(744, 46, false);
#line 29 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(790, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(846, 43, false);
#line 32 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AusCost));

#line default
#line hidden
            EndContext();
            BeginContext(889, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(945, 44, false);
#line 35 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JuteCost));

#line default
#line hidden
            EndContext();
            BeginContext(989, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1045, 43, false);
#line 38 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VegCost));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1144, 46, false);
#line 41 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OthersCost));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1246, 55, false);
#line 44 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1357, 66, false);
#line 47 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1479, 54, false);
#line 50 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UseInKharif2Season));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 56 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1651, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1700, 53, false);
#line 59 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalOperatingHour));

#line default
#line hidden
            EndContext();
            BeginContext(1753, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1809, 42, false);
#line 62 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AusArea));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1907, 43, false);
#line 65 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JuteArea));

#line default
#line hidden
            EndContext();
            BeginContext(1950, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2006, 42, false);
#line 68 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VegArea));

#line default
#line hidden
            EndContext();
            BeginContext(2048, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2104, 45, false);
#line 71 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(2149, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2205, 42, false);
#line 74 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AusCost));

#line default
#line hidden
            EndContext();
            BeginContext(2247, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2303, 43, false);
#line 77 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JuteCost));

#line default
#line hidden
            EndContext();
            BeginContext(2346, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2402, 42, false);
#line 80 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VegCost));

#line default
#line hidden
            EndContext();
            BeginContext(2444, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2500, 45, false);
#line 83 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OthersCost));

#line default
#line hidden
            EndContext();
            BeginContext(2545, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2601, 54, false);
#line 86 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(2655, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2711, 65, false);
#line 89 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(2776, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2832, 53, false);
#line 92 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UseInKharif2Season));

#line default
#line hidden
            EndContext();
            BeginContext(2885, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2940, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaddfd5a41f448d7a61958e5b8622f24", async() => {
                BeginContext(2998, 4, true);
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
#line 95 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
                                       WriteLiteral(item.SurveyKharif1Id);

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
            BeginContext(3006, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3026, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ae46e4934934d4896a2a136ab39b256", async() => {
                BeginContext(3087, 7, true);
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
#line 96 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
                                          WriteLiteral(item.SurveyKharif1Id);

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
            BeginContext(3098, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3118, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b299db369ab4d5ba31ceccc628143b3", async() => {
                BeginContext(3178, 6, true);
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
#line 97 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
                                         WriteLiteral(item.SurveyKharif1Id);

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
            BeginContext(3188, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 100 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\Kharif1SurveyInfo\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3227, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BADCIrrigationEquipmentSurvey.Models.DataModels.Kharif1SurveyInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
