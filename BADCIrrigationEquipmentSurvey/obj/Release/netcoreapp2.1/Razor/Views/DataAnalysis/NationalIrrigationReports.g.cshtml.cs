#pragma checksum "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cd05ac8d55eae34423f6468cf7fc7e52f1dc56c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataAnalysis_NationalIrrigationReports), @"mvc.1.0.view", @"/Views/DataAnalysis/NationalIrrigationReports.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DataAnalysis/NationalIrrigationReports.cshtml", typeof(AspNetCore.Views_DataAnalysis_NationalIrrigationReports))]
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
#line 1 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
using BADCIrrigationEquipmentSurvey.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd05ac8d55eae34423f6468cf7fc7e52f1dc56c", @"/Views/DataAnalysis/NationalIrrigationReports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18840fcd0f6dc65e539ad3db3277a2f6527ee2c", @"/Views/_ViewImports.cshtml")]
    public class Views_DataAnalysis_NationalIrrigationReports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
  
    ViewData["Title"] = "UpazilaWiseIrrigationReports";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("styles", async() => {
                BeginContext(184, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(192, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1404c860d2924de5b0b1cd72d85bb2ca", async() => {
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
                BeginContext(249, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(255, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0d5f9d96812145e6b680731244130798", async() => {
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
                BeginContext(313, 5677, true);
                WriteLiteral(@"
    
    <style>
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
                border: 1px solid #ddd !important;
                padding: 5px;
                text-align: left;
                color: #235;
                font: 500 14px/1.42857 ""Helvetica Neue"", Helvetica, Ari");
                WriteLiteral(@"al, sans-serif;
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
                .table > thead > th > i,
                .table > thead > tr > th > i {
                    font: italic 500 12px/1.42857 Cambria, ""Helvetica Neue"", Helvetica, Arial, sans-serif;
                }

");
                WriteLiteral(@"            .table > tbody > tr:nth-child(even) > td {
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
                .table > tbody > tr > td > input.union-code,
                .table > tbody > tr > td > input.mauza-name {
                    text-align: left;
                }

                .table > tr > td > input.dec");
                WriteLiteral(@"imals,
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
            padding: 0;
            /*background: rgba(200, 240, 245, 0.03);*/
            background-color: #fcfeff;
        }

            .row > [class*=""col-""] {
                border: 0 none;
      ");
                WriteLiteral(@"          margin: 0;
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
                margin: 4px;
                font-size: 23px;
                color: #158;
            }

                .btn-action span.glyphicon:hover {
                    color: #28d;
           ");
                WriteLiteral(@"     }

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
            BeginContext(5993, 2179, true);
            WriteLiteral(@"<div style=""margin: 0 auto; padding: 0;"">

    <div style=""border-bottom: 2px solid #135; margin: 5px auto; text-align:center;"">
        <strong class=""data-title"">Upazila Wise Irrigation Equipment used, Area Irrigated and Benefitted Farmer</strong>
        <br />

    </div>
    <div class=""form-view"">
        <div id=""multi-form-wrapper"" class=""data-view multi-form-wrapper"">
            <table id=""multi-form-view"" class=""table table-responsive multi-form-view"">
                <thead>
                    <tr>
                        <th rowspan=""3"">SL No</th>
                        <th rowspan=""3"">Division</th>
                        <th colspan=""12"">LOW LIFT PUMP OPERATED BY ELECTRICITY AND DIESEL</th>
                    </tr>
                    <tr>
                        <th rowspan=""2"">Organization</th>
                        <th colspan=""5"">LLP Operated by Electricity</th>
                        <th colspan=""3"">LLP Operated by Diesel</th>
                        <th colspan=""");
            WriteLiteral(@"3"">Total</th>
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
                        <th>1</th>
                        <th>2</th>
                        <th>3</th>
                        <th>4</th>
                        <th>5</th>
                        <th>6</th>
                        <th>7</th>
                        <th>8</th>
                        <th>9</th>
                        <th>10</th>
                        <th>11</th>
                        <th>12</th>
                        <th>1");
            WriteLiteral("3</th>\r\n                        <th>14</th>\r\n\r\n\r\n                    </tr>\r\n\r\n                </thead>\r\n\r\n                <tbody>\r\n");
            EndContext();
#line 263 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                       var c = 1;

#line default
#line hidden
            BeginContext(9331, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 265 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                     foreach (ReportViewModel item in Model)
                    {

#line default
#line hidden
            BeginContext(9418, 105, true);
            WriteLiteral("                        <tr>\r\n                            <td rowspan=\"3\" style=\"vertical-align: middle\">");
            EndContext();
            BeginContext(9524, 1, false);
#line 268 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                                                                      Write(c);

#line default
#line hidden
            EndContext();
            BeginContext(9525, 82, true);
            WriteLiteral("</td>\r\n                            <td rowspan=\"3\" style=\"vertical-align: middle\">");
            EndContext();
            BeginContext(9608, 12, false);
#line 269 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                                                                      Write(item.Upazila);

#line default
#line hidden
            EndContext();
            BeginContext(9620, 82, true);
            WriteLiteral("</td>\r\n                            <td>BADC</td>\r\n                            <td>");
            EndContext();
            BeginContext(9703, 24, false);
#line 271 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.PDBCountGroupByBADC);

#line default
#line hidden
            EndContext();
            BeginContext(9727, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(9767, 24, false);
#line 272 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.REBCountGroupByBADC);

#line default
#line hidden
            EndContext();
            BeginContext(9791, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(9831, 69, false);
#line 273 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.REBCountGroupByBADC));

#line default
#line hidden
            EndContext();
            BeginContext(9900, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(9940, 46, false);
#line 274 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.AreaCountGroupByBADSAndElectricityEngines);

#line default
#line hidden
            EndContext();
            BeginContext(9986, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10026, 48, false);
#line 275 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.FarmrsCountGroupByBADSAndElectricityEngines);

#line default
#line hidden
            EndContext();
            BeginContext(10074, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10114, 41, false);
#line 276 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.UnitCountGroupByBADSAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(10155, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10195, 41, false);
#line 277 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.AreaCountGroupByBADSAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(10236, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10276, 43, false);
#line 278 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.FarmrsCountGroupByBADSAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(10319, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10359, 113, false);
#line 279 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.REBCountGroupByBADC + item.UnitCountGroupByBADSAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(10472, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10512, 108, false);
#line 280 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.AreaCountGroupByBADSAndElectricityEngines + item.AreaCountGroupByBADSAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(10620, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10660, 112, false);
#line 281 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.FarmrsCountGroupByBADSAndElectricityEngines + item.FarmrsCountGroupByBADSAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(10772, 149, true);
            WriteLiteral("</td>\r\n\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Others</td>\r\n                            <td>");
            EndContext();
            BeginContext(10922, 26, false);
#line 287 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.PDBCountGroupByOthers);

#line default
#line hidden
            EndContext();
            BeginContext(10948, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10988, 26, false);
#line 288 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.REBCountGroupByOthers);

#line default
#line hidden
            EndContext();
            BeginContext(11014, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11054, 73, false);
#line 289 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByOthers + item.REBCountGroupByOthers));

#line default
#line hidden
            EndContext();
            BeginContext(11127, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11167, 48, false);
#line 290 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.AreaCountGroupByOthersAndElectricityEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11215, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11255, 50, false);
#line 291 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.FarmrsCountGroupByOthersAndElectricityEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11305, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11345, 43, false);
#line 292 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.UnitCountGroupByOthersAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11388, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11428, 43, false);
#line 293 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.AreaCountGroupByOthersAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11471, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11511, 45, false);
#line 294 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(item.FarmrsCountGroupByOthersAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11556, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11596, 119, false);
#line 295 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByOthers + item.REBCountGroupByOthers + item.UnitCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(11715, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11755, 112, false);
#line 296 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.AreaCountGroupByOthersAndElectricityEngines + item.AreaCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(11867, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11907, 116, false);
#line 297 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.FarmrsCountGroupByOthersAndElectricityEngines + item.FarmrsCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(12023, 146, true);
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Total</td>\r\n                            <td>");
            EndContext();
            BeginContext(12170, 71, false);
#line 302 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.PDBCountGroupByOthers));

#line default
#line hidden
            EndContext();
            BeginContext(12241, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(12281, 71, false);
#line 303 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.REBCountGroupByBADC + item.REBCountGroupByOthers));

#line default
#line hidden
            EndContext();
            BeginContext(12352, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(12392, 127, false);
#line 304 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.REBCountGroupByBADC + item.PDBCountGroupByOthers + item.REBCountGroupByOthers));

#line default
#line hidden
            EndContext();
            BeginContext(12519, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(12559, 115, false);
#line 305 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.AreaCountGroupByBADSAndElectricityEngines + item.AreaCountGroupByOthersAndElectricityEngines));

#line default
#line hidden
            EndContext();
            BeginContext(12674, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(12714, 119, false);
#line 306 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.FarmrsCountGroupByBADSAndElectricityEngines + item.FarmrsCountGroupByOthersAndElectricityEngines));

#line default
#line hidden
            EndContext();
            BeginContext(12833, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(12873, 105, false);
#line 307 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.UnitCountGroupByBADSAndDieselEngines + item.UnitCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(12978, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(13018, 105, false);
#line 308 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.AreaCountGroupByBADSAndDieselEngines + item.AreaCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(13123, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(13163, 109, false);
#line 309 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.FarmrsCountGroupByBADSAndDieselEngines + item.FarmrsCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(13272, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(13312, 217, false);
#line 310 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.REBCountGroupByBADC + item.PDBCountGroupByOthers + item.REBCountGroupByOthers + item.UnitCountGroupByBADSAndDieselEngines + item.UnitCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(13529, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(13569, 205, false);
#line 311 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.AreaCountGroupByBADSAndElectricityEngines + item.AreaCountGroupByOthersAndElectricityEngines + item.AreaCountGroupByBADSAndDieselEngines + item.AreaCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(13774, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(13814, 213, false);
#line 312 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.FarmrsCountGroupByBADSAndElectricityEngines + item.FarmrsCountGroupByOthersAndElectricityEngines + item.FarmrsCountGroupByBADSAndDieselEngines + item.FarmrsCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(14027, 40, true);
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 315 "D:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\NationalIrrigationReports.cshtml"
                        c++;
                    }

#line default
#line hidden
            BeginContext(14120, 84, true);
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
