#pragma checksum "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\MauzaInfoes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26aff3e7b79dd20ec0d3f23fda17a022d9ada37c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MauzaInfoes_Delete), @"mvc.1.0.view", @"/Views/MauzaInfoes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MauzaInfoes/Delete.cshtml", typeof(AspNetCore.Views_MauzaInfoes_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26aff3e7b79dd20ec0d3f23fda17a022d9ada37c", @"/Views/MauzaInfoes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18840fcd0f6dc65e539ad3db3277a2f6527ee2c", @"/Views/_ViewImports.cshtml")]
    public class Views_MauzaInfoes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BADCIrrigationEquipmentSurvey.Models.DataModels.MauzaInfo>
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
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\MauzaInfoes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 170, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>MauzaInfo</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(328, 45, false);
#line 16 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\MauzaInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MauzaName));

#line default
#line hidden
            EndContext();
            BeginContext(373, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(417, 41, false);
#line 19 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\MauzaInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MauzaName));

#line default
#line hidden
            EndContext();
            BeginContext(458, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(502, 45, false);
#line 22 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\MauzaInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MauzaJlNo));

#line default
#line hidden
            EndContext();
            BeginContext(547, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(591, 41, false);
#line 25 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\MauzaInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MauzaJlNo));

#line default
#line hidden
            EndContext();
            BeginContext(632, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(676, 48, false);
#line 28 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\MauzaInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DistrictInfo));

#line default
#line hidden
            EndContext();
            BeginContext(724, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(768, 53, false);
#line 31 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\MauzaInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DistrictInfo.DistCode));

#line default
#line hidden
            EndContext();
            BeginContext(821, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(865, 45, false);
#line 34 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\MauzaInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UnionInfo));

#line default
#line hidden
            EndContext();
            BeginContext(910, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(954, 51, false);
#line 37 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\MauzaInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UnionInfo.UnionCode));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1049, 47, false);
#line 40 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\MauzaInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpazilaInfo));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1140, 52, false);
#line 43 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\MauzaInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpazilaInfo.UpazCode));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1230, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00fb620002264dd0a9ce7e6dd16700f5", async() => {
                BeginContext(1256, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1266, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a9525982b8d41bd9b0efc60c26ea5c9", async() => {
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
#line 48 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\MauzaInfoes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MauzaCode);

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
                BeginContext(1309, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1393, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba0099d172924460ac9ca287bbf94a16", async() => {
                    BeginContext(1415, 12, true);
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
                BeginContext(1431, 6, true);
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
            BeginContext(1444, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BADCIrrigationEquipmentSurvey.Models.DataModels.MauzaInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
