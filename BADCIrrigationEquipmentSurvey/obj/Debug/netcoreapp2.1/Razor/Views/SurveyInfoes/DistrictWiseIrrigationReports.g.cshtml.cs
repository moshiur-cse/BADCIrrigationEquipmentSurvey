#pragma checksum "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcaa63d881b11c5b98590d6de32d60ede698cb9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SurveyInfoes_DistrictWiseIrrigationReports), @"mvc.1.0.view", @"/Views/SurveyInfoes/DistrictWiseIrrigationReports.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SurveyInfoes/DistrictWiseIrrigationReports.cshtml", typeof(AspNetCore.Views_SurveyInfoes_DistrictWiseIrrigationReports))]
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
#line 1 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
using BADCIrrigationEquipmentSurvey.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcaa63d881b11c5b98590d6de32d60ede698cb9e", @"/Views/SurveyInfoes/DistrictWiseIrrigationReports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18840fcd0f6dc65e539ad3db3277a2f6527ee2c", @"/Views/_ViewImports.cshtml")]
    public class Views_SurveyInfoes_DistrictWiseIrrigationReports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/datetimepicker.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/fixedtablestyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
  
    ViewBag.Title = "UpazilaWiseIrrigationReports";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("styles", async() => {
                BeginContext(180, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(188, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "92a760668bb243709f4e4f14c5f9fc20", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(245, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(251, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2d374494359423482d1c9657a339931", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(309, 5869, true);
                WriteLiteral(@"

    <style>
        .columnNo {
            font-size: 9px !important;
            font-style: italic !important;
        }

        .numberAlign {
            text-align: right !important;
        }
        .form-view {
            border: 0 none;
            margin: 0;
            padding: 0 15px;
            color: #135;
        }

        .data-view {
            border: 1px solid #ccc;
            margin: 0 -15px;
            padding: 8px;
            background: rgba(200, 240, 245, 0.03);
            background-color: #fcfeff;
            overflow: auto;
        }

        .table {
            border: 1px solid #ddd;
            margin: 0 auto;
        }

            .table td, .table > tbody > td,
            .table th, .table > thead > th,
            .table > tr:nth-child(even) > td,
            .table > tbody > tr:nth-child(even) > td,
            .table > tr:nth-child(odd) > td,
            .table > tbody > tr:nth-child(odd) > td {
                border: 1px");
                WriteLiteral(@" solid #ddd !important;
                padding: 5px;
                text-align: left;
                color: #235;
                font: 500 14px/1.42857 ""Helvetica Neue"", Helvetica, Arial, sans-serif;
                background: #fff;
                /*font-family: Cambria, ""Helvetica Neue"", Helvetica, Arial, sans-serif;*/
            }

            .table th, .table > thead > th,
            .table > thead > tr > th {
                padding: 5px;
                text-align: center !important;
                vertical-align: middle !important;
                color: #125;
                font: 500 14px/1.42857 Cambria, ""Helvetica Neue"", Helvetica, Arial, sans-serif;
                background-color: #f0f7f8;
            }

            .table > tr.sub-header-tr > th,
            .table > thead > tr.sub-header-tr > th {
                padding: 2px !important;
            }

                .table th i,
                .table > tr.sub-header-tr > th > i,
                .table > th");
                WriteLiteral(@"ead > th > i,
                .table > thead > tr > th > i {
                    font: italic 500 12px/1.42857 Cambria, ""Helvetica Neue"", Helvetica, Arial, sans-serif;
                }

            .table > tbody > tr:nth-child(even) > td {
                padding: 5px;
                background: #fafdfe !important;
            }

            .table > tr > td > input,
            .table > tr > td > select,
            .table > tbody > tr > td > input,
            .table > tbody > tr > td > select {
                width: 120px;
                padding: 3px 5px !important;
                text-align: center;
            }

                .table > tr > td > input.dist-code,
                .table > tr > td > input.upaz-code,
                .table > tr > td > input.union-code,
                .table > tr > td > input.mauza-name,
                .table > tbody > tr > td > input.dist-code,
                .table > tbody > tr > td > input.upaz-code,
                .table > tbody > tr >");
                WriteLiteral(@" td > input.union-code,
                .table > tbody > tr > td > input.mauza-name {
                    text-align: left;
                }

                .table > tr > td > input.decimals,
                .table > tr > td > input.integers,
                .table > tr > td > input.survey-dates,
                .table > tbody > tr > td > input.decimals,
                .table > tbody > tr > td > input.integers,
                .table > tbody > tr > td > input.survey-dates {
                    width: 85px;
                    text-align: center;
                }

        .dist-code,
        .upaz-code,
        .union-code,
        .mauza-name {
            text-align: left;
        }

        .decimals,
        .integers,
        .survey-date,
        .survey-dates {
            text-align: center;
        }

        .row {
            border-color: #ccc;
            border-style: solid;
            border-width: 1px 1px 0;
            margin: 0 -15px;
            padding");
                WriteLiteral(@": 0;
            /*background: rgba(200, 240, 245, 0.03);*/
            background-color: #fcfeff;
        }

            .row > [class*=""col-""] {
                border: 0 none;
                margin: 0;
                padding: 5px 12px;
            }

                .row > [class*=""col-""] > [class*=""title-""],
                .row > [class*=""col-""] > label,
                .row > [class*=""col-""] > .control-label {
                    margin: 6px;
                    padding: 0;
                    color: #137;
                    font: 600 14px/1.42857 Cambria, ""Helvetica Neue"", Helvetica, Arial, sans-serif;
                }

            .row > .col-auto {
                width: auto;
                max-width: 100%;
                padding: 5px 12px;
            }

        .btn-action {
            min-width: 80px;
            text-align: center !important;
            vertical-align: middle !important;
        }

            .btn-action span.glyphicon {
                ");
                WriteLiteral(@"margin: 4px;
                font-size: 23px;
                color: #158;
            }

                .btn-action span.glyphicon:hover {
                    color: #28d;
                }

            .btn-action span.glyphicon-remove:hover {
                color: #f53713 !important;
            }


        .data-title {
            margin: 20px 0 5px 0;
            color: #035;
            font: 500 18pt/1.42857 Roboto, Tahoma, Geneva, Verdana, sans-serif;
            text-align: left;
        }

        .data-sub-title {
            margin: 5px 0;
            color: #058;
            font: 500 14pt/1.42857 Roboto, Tahoma, Geneva, Verdana, sans-serif;
            text-align: left;
        }
    </style>

");
                EndContext();
            }
            );
            BeginContext(6181, 2418, true);
            WriteLiteral(@"<div style=""margin: 0 auto; padding: 0;"">

    <div style=""border-bottom: 2px solid #135; margin: 5px auto; text-align:center;"">
        <strong class=""data-title"">District Wise Irrigation Equipment used, Area Irrigated and Benefitted Farmer</strong>
        <br />

    </div>
    <div class=""form-view"">
        <div id=""multi-form-wrapper"" class=""data-view multi-form-wrapper"">
            <table id=""multi-form-view"" class=""table table-responsive multi-form-view"">
                <thead>
                    <tr>
                        <th rowspan=""3"">SL No</th>
                        <th rowspan=""3"">District</th>
                        <th colspan=""12"">LOW LIFT PUMP OPERATED BY ELECTRICITY AND DIESEL</th>
                    </tr>
                    <tr>
                        <th rowspan=""2"">Organization</th>
                        <th colspan=""5"">LLP Operated by Electricity</th>
                        <th colspan=""3"">LLP Operated by Diesel</th>
                        <th colspan=");
            WriteLiteral(@"""3"">Total</th>
                    </tr>

                    <tr>
                        <th>PDB</th>
                        <th>REB</th>
                        <th>Total</th>
                        <th>Area</th>
                        <th>Farmers</th>
                        <th>Unit</th>
                        <th>Area</th>
                        <th>Farmers</th>
                        <th>Unit</th>
                        <th>Area</th>
                        <th>Farmers</th>
                    </tr>
                    <tr>
                        <th class=""columnNo"">1</th>
                        <th class=""columnNo"">2</th>
                        <th class=""columnNo"">3</th>
                        <th class=""columnNo"">4</th>
                        <th class=""columnNo"">5</th>
                        <th class=""columnNo"">6</th>
                        <th class=""columnNo"">7</th>
                        <th class=""columnNo"">8</th>
                        <th class=""colu");
            WriteLiteral(@"mnNo"">9</th>
                        <th class=""columnNo"">10</th>
                        <th class=""columnNo"">11</th>
                        <th class=""columnNo"">12</th>
                        <th class=""columnNo"">13</th>
                        <th class=""columnNo"">14</th>


                    </tr>

                </thead>

                <tbody>
");
            EndContext();
#line 271 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                       var c = 1;

#line default
#line hidden
            BeginContext(9566, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 273 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                     foreach (ReportViewModel item in Model)
    {

#line default
#line hidden
            BeginContext(9637, 90, true);
            WriteLiteral("                <tr>\r\n                    <td rowspan=\"3\" style=\"vertical-align: middle;\">");
            EndContext();
            BeginContext(9728, 1, false);
#line 276 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                                               Write(c);

#line default
#line hidden
            EndContext();
            BeginContext(9729, 74, true);
            WriteLiteral("</td>\r\n                    <td rowspan=\"3\" style=\"vertical-align: middle\">");
            EndContext();
            BeginContext(9804, 12, false);
#line 277 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                                              Write(item.Upazila);

#line default
#line hidden
            EndContext();
            BeginContext(9816, 86, true);
            WriteLiteral("</td>\r\n                    <td>BADC</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(9903, 24, false);
#line 279 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.PDBCountGroupByBADC);

#line default
#line hidden
            EndContext();
            BeginContext(9927, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(9979, 24, false);
#line 280 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.REBCountGroupByBADC);

#line default
#line hidden
            EndContext();
            BeginContext(10003, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(10055, 69, false);
#line 281 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.REBCountGroupByBADC));

#line default
#line hidden
            EndContext();
            BeginContext(10124, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(10176, 46, false);
#line 282 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.AreaCountGroupByBADSAndElectricityEngines);

#line default
#line hidden
            EndContext();
            BeginContext(10222, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(10274, 48, false);
#line 283 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.FarmrsCountGroupByBADSAndElectricityEngines);

#line default
#line hidden
            EndContext();
            BeginContext(10322, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(10374, 41, false);
#line 284 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.UnitCountGroupByBADSAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(10415, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(10467, 41, false);
#line 285 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.AreaCountGroupByBADSAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(10508, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(10560, 43, false);
#line 286 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.FarmrsCountGroupByBADSAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(10603, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(10655, 113, false);
#line 287 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.REBCountGroupByBADC + item.UnitCountGroupByBADSAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(10768, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(10820, 108, false);
#line 288 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.AreaCountGroupByBADSAndElectricityEngines + item.AreaCountGroupByBADSAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(10928, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(10980, 112, false);
#line 289 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.FarmrsCountGroupByBADSAndElectricityEngines + item.FarmrsCountGroupByBADSAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(11092, 137, true);
            WriteLiteral("</td>\r\n\r\n\r\n                </tr>\r\n                <tr>\r\n                    <td>Others</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(11230, 26, false);
#line 295 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.PDBCountGroupByOthers);

#line default
#line hidden
            EndContext();
            BeginContext(11256, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(11308, 26, false);
#line 296 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.REBCountGroupByOthers);

#line default
#line hidden
            EndContext();
            BeginContext(11334, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(11386, 73, false);
#line 297 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.PDBCountGroupByOthers + item.REBCountGroupByOthers));

#line default
#line hidden
            EndContext();
            BeginContext(11459, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(11511, 48, false);
#line 298 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.AreaCountGroupByOthersAndElectricityEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11559, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(11611, 50, false);
#line 299 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.FarmrsCountGroupByOthersAndElectricityEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11661, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(11713, 43, false);
#line 300 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.UnitCountGroupByOthersAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11756, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(11808, 43, false);
#line 301 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.AreaCountGroupByOthersAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11851, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(11903, 45, false);
#line 302 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(item.FarmrsCountGroupByOthersAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11948, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(12000, 119, false);
#line 303 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.PDBCountGroupByOthers + item.REBCountGroupByOthers + item.UnitCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(12119, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(12171, 112, false);
#line 304 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.AreaCountGroupByOthersAndElectricityEngines + item.AreaCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(12283, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(12335, 116, false);
#line 305 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.FarmrsCountGroupByOthersAndElectricityEngines + item.FarmrsCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(12451, 134, true);
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n                <tr>\r\n                    <td>Total</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(12586, 71, false);
#line 310 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.PDBCountGroupByOthers));

#line default
#line hidden
            EndContext();
            BeginContext(12657, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(12709, 71, false);
#line 311 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.REBCountGroupByBADC + item.REBCountGroupByOthers));

#line default
#line hidden
            EndContext();
            BeginContext(12780, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(12832, 127, false);
#line 312 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.REBCountGroupByBADC + item.PDBCountGroupByOthers + item.REBCountGroupByOthers));

#line default
#line hidden
            EndContext();
            BeginContext(12959, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(13011, 115, false);
#line 313 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.AreaCountGroupByBADSAndElectricityEngines + item.AreaCountGroupByOthersAndElectricityEngines));

#line default
#line hidden
            EndContext();
            BeginContext(13126, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(13178, 119, false);
#line 314 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.FarmrsCountGroupByBADSAndElectricityEngines + item.FarmrsCountGroupByOthersAndElectricityEngines));

#line default
#line hidden
            EndContext();
            BeginContext(13297, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(13349, 105, false);
#line 315 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.UnitCountGroupByBADSAndDieselEngines + item.UnitCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(13454, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(13506, 105, false);
#line 316 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.AreaCountGroupByBADSAndDieselEngines + item.AreaCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(13611, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(13663, 109, false);
#line 317 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.FarmrsCountGroupByBADSAndDieselEngines + item.FarmrsCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(13772, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(13824, 217, false);
#line 318 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.REBCountGroupByBADC + item.PDBCountGroupByOthers + item.REBCountGroupByOthers + item.UnitCountGroupByBADSAndDieselEngines + item.UnitCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(14041, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(14093, 205, false);
#line 319 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.AreaCountGroupByBADSAndElectricityEngines + item.AreaCountGroupByOthersAndElectricityEngines + item.AreaCountGroupByBADSAndDieselEngines + item.AreaCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(14298, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"numberAlign\">");
            EndContext();
            BeginContext(14350, 213, false);
#line 320 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
                                       Write(Convert.ToDouble(item.FarmrsCountGroupByBADSAndElectricityEngines + item.FarmrsCountGroupByOthersAndElectricityEngines + item.FarmrsCountGroupByBADSAndDieselEngines + item.FarmrsCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(14563, 32, true);
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 323 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\SurveyInfoes\DistrictWiseIrrigationReports.cshtml"
c++;
}

#line default
#line hidden
            BeginContext(14604, 84, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
