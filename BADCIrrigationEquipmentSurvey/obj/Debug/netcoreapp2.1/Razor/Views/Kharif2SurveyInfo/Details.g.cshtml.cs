#pragma checksum "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1731f22a9783f2d65ad8a6f25306bbb0825ff0f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kharif2SurveyInfo_Details), @"mvc.1.0.view", @"/Views/Kharif2SurveyInfo/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kharif2SurveyInfo/Details.cshtml", typeof(AspNetCore.Views_Kharif2SurveyInfo_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1731f22a9783f2d65ad8a6f25306bbb0825ff0f4", @"/Views/Kharif2SurveyInfo/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18840fcd0f6dc65e539ad3db3277a2f6527ee2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Kharif2SurveyInfo_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BADCIrrigationEquipmentSurvey.Models.DataModels.Kharif2SurveyInfo>
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
#line 3 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(166, 131, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Kharif2SurveyInfo</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(298, 54, false);
#line 15 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalOperatingHour));

#line default
#line hidden
            EndContext();
            BeginContext(352, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(396, 50, false);
#line 18 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalOperatingHour));

#line default
#line hidden
            EndContext();
            BeginContext(446, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(490, 45, false);
#line 21 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TAmanArea));

#line default
#line hidden
            EndContext();
            BeginContext(535, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(579, 41, false);
#line 24 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.TAmanArea));

#line default
#line hidden
            EndContext();
            BeginContext(620, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(664, 46, false);
#line 27 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(710, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(754, 42, false);
#line 30 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.OthersArea));

#line default
#line hidden
            EndContext();
            BeginContext(796, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(840, 45, false);
#line 33 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TAmanCost));

#line default
#line hidden
            EndContext();
            BeginContext(885, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(929, 41, false);
#line 36 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.TAmanCost));

#line default
#line hidden
            EndContext();
            BeginContext(970, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1014, 46, false);
#line 39 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OthersCost));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1104, 42, false);
#line 42 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.OthersCost));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1190, 55, false);
#line 45 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1289, 51, false);
#line 48 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.BenefitedFarmerMale));

#line default
#line hidden
            EndContext();
            BeginContext(1340, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1384, 66, false);
#line 51 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1494, 62, false);
#line 54 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.BenefitedAgricultureLabourMale));

#line default
#line hidden
            EndContext();
            BeginContext(1556, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1603, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d48769638294392aa8c127580344d51", async() => {
                BeginContext(1662, 4, true);
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
#line 59 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\Kharif2SurveyInfo\Details.cshtml"
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
            BeginContext(1670, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1678, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97e15f960db047e69ade97aeda47f20e", async() => {
                BeginContext(1700, 12, true);
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
            BeginContext(1716, 10, true);
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
