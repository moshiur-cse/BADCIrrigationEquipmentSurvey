#pragma checksum "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5bf6072dc382eec0feda8827f3eec8123e604b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kharif2SurveyInfo_Delete), @"mvc.1.0.view", @"/Views/Kharif2SurveyInfo/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kharif2SurveyInfo/Delete.cshtml", typeof(AspNetCore.Views_Kharif2SurveyInfo_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5bf6072dc382eec0feda8827f3eec8123e604b0", @"/Views/Kharif2SurveyInfo/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18840fcd0f6dc65e539ad3db3277a2f6527ee2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Kharif2SurveyInfo_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BADCIrrigationEquipmentSurvey.Models.DataModels.Kharif2SurveyInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::BADCIrrigationEquipmentSurvey.Models.BasicModels.MaxLengthTagHelper __BADCIrrigationEquipmentSurvey_Models_BasicModels_MaxLengthTagHelper;
        private global::BADCIrrigationEquipmentSurvey.Models.BasicModels.RequiredTagHelper __BADCIrrigationEquipmentSurvey_Models_BasicModels_RequiredTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(165, 178, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Kharif2SurveyInfo</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(344, 54, false);
#line 16 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalOperatingHour));

#line default
#line hidden
            EndContext();
            BeginContext(398, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(442, 50, false);
#line 19 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalOperatingHour));

#line default
#line hidden
            EndContext();
            BeginContext(492, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(536, 45, false);
#line 22 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TAmanArea));

#line default
#line hidden
            EndContext();
            BeginContext(581, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(625, 41, false);
#line 25 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TAmanArea));

#line default
#line hidden
            EndContext();
            BeginContext(666, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(710, 46, false);
#line 28 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(756, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(800, 42, false);
#line 31 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(842, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(886, 45, false);
#line 34 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TAmanCost));

#line default
#line hidden
            EndContext();
            BeginContext(931, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(975, 41, false);
#line 37 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TAmanCost));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1060, 46, false);
#line 40 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OthersCost));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1150, 42, false);
#line 43 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OthersCost));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1236, 55, false);
#line 46 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1335, 51, false);
#line 49 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1430, 66, false);
#line 52 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1540, 62, false);
#line 55 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(1602, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1640, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3347b58a590a40fcadc863faafd8c3cb", async() => {
                BeginContext(1666, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1676, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8032b077d60d4b1f95c7ca93830e4c5d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __BADCIrrigationEquipmentSurvey_Models_BasicModels_MaxLengthTagHelper = CreateTagHelper<global::BADCIrrigationEquipmentSurvey.Models.BasicModels.MaxLengthTagHelper>();
                __tagHelperExecutionContext.Add(__BADCIrrigationEquipmentSurvey_Models_BasicModels_MaxLengthTagHelper);
                __BADCIrrigationEquipmentSurvey_Models_BasicModels_RequiredTagHelper = CreateTagHelper<global::BADCIrrigationEquipmentSurvey.Models.BasicModels.RequiredTagHelper>();
                __tagHelperExecutionContext.Add(__BADCIrrigationEquipmentSurvey_Models_BasicModels_RequiredTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 60 "D:\Projects\Repos\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SurveyKharif1Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __BADCIrrigationEquipmentSurvey_Models_BasicModels_MaxLengthTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
                __BADCIrrigationEquipmentSurvey_Models_BasicModels_RequiredTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1725, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1809, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "467c03535d82430eb24110e87011e462", async() => {
                    BeginContext(1831, 12, true);
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
                BeginContext(1847, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1860, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BADCIrrigationEquipmentSurvey.Models.DataModels.Kharif2SurveyInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
