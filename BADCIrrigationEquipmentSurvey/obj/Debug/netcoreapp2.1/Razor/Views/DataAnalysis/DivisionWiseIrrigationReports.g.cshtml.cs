#pragma checksum "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab7f6bbeae1fc7dcdc61918077236f6b7439cdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataAnalysis_DivisionWiseIrrigationReports), @"mvc.1.0.view", @"/Views/DataAnalysis/DivisionWiseIrrigationReports.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DataAnalysis/DivisionWiseIrrigationReports.cshtml", typeof(AspNetCore.Views_DataAnalysis_DivisionWiseIrrigationReports))]
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
#line 1 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
using BADCIrrigationEquipmentSurvey.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab7f6bbeae1fc7dcdc61918077236f6b7439cdb", @"/Views/DataAnalysis/DivisionWiseIrrigationReports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18840fcd0f6dc65e539ad3db3277a2f6527ee2c", @"/Views/_ViewImports.cshtml")]
    public class Views_DataAnalysis_DivisionWiseIrrigationReports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
  
    ViewData["Title"] = "UpazilaWiseIrrigationReports";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(167, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(186, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(194, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a9dbb5bac0d443258c38549973e15fcb", async() => {
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
                BeginContext(251, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(257, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6d0aae0b2684f2699e4e2b038945800", async() => {
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
                BeginContext(315, 5673, true);
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
                font: 500 14px/1.42857 ""Helvetica Neue"", Helvetica, Arial, ");
                WriteLiteral(@"sans-serif;
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
                WriteLiteral(@"        .table > tbody > tr:nth-child(even) > td {
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

                .table > tr > td > input.decimal");
                WriteLiteral(@"s,
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
                WriteLiteral(@"      margin: 0;
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
                WriteLiteral(@" }

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
            BeginContext(5991, 2179, true);
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
#line 264 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                       var c = 1;

#line default
#line hidden
            BeginContext(9329, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 266 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                     foreach (ReportViewModel item in Model)
                    {

#line default
#line hidden
            BeginContext(9416, 105, true);
            WriteLiteral("                        <tr>\r\n                            <td rowspan=\"3\" style=\"vertical-align: middle\">");
            EndContext();
            BeginContext(9522, 1, false);
#line 269 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                                                                      Write(c);

#line default
#line hidden
            EndContext();
            BeginContext(9523, 82, true);
            WriteLiteral("</td>\r\n                            <td rowspan=\"3\" style=\"vertical-align: middle\">");
            EndContext();
            BeginContext(9606, 12, false);
#line 270 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                                                                      Write(item.Upazila);

#line default
#line hidden
            EndContext();
            BeginContext(9618, 82, true);
            WriteLiteral("</td>\r\n                            <td>BADC</td>\r\n                            <td>");
            EndContext();
            BeginContext(9701, 24, false);
#line 272 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.PDBCountGroupByBADC);

#line default
#line hidden
            EndContext();
            BeginContext(9725, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(9765, 24, false);
#line 273 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.REBCountGroupByBADC);

#line default
#line hidden
            EndContext();
            BeginContext(9789, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(9829, 69, false);
#line 274 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.REBCountGroupByBADC));

#line default
#line hidden
            EndContext();
            BeginContext(9898, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(9938, 46, false);
#line 275 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.AreaCountGroupByBADSAndElectricityEngines);

#line default
#line hidden
            EndContext();
            BeginContext(9984, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10024, 48, false);
#line 276 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.FarmrsCountGroupByBADSAndElectricityEngines);

#line default
#line hidden
            EndContext();
            BeginContext(10072, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10112, 41, false);
#line 277 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.UnitCountGroupByBADSAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(10153, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10193, 41, false);
#line 278 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.AreaCountGroupByBADSAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(10234, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10274, 43, false);
#line 279 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.FarmrsCountGroupByBADSAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(10317, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10357, 113, false);
#line 280 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.REBCountGroupByBADC + item.UnitCountGroupByBADSAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(10470, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10510, 108, false);
#line 281 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.AreaCountGroupByBADSAndElectricityEngines + item.AreaCountGroupByBADSAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(10618, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10658, 112, false);
#line 282 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.FarmrsCountGroupByBADSAndElectricityEngines + item.FarmrsCountGroupByBADSAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(10770, 149, true);
            WriteLiteral("</td>\r\n\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Others</td>\r\n                            <td>");
            EndContext();
            BeginContext(10920, 26, false);
#line 288 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.PDBCountGroupByOthers);

#line default
#line hidden
            EndContext();
            BeginContext(10946, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(10986, 26, false);
#line 289 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.REBCountGroupByOthers);

#line default
#line hidden
            EndContext();
            BeginContext(11012, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11052, 73, false);
#line 290 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByOthers + item.REBCountGroupByOthers));

#line default
#line hidden
            EndContext();
            BeginContext(11125, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11165, 48, false);
#line 291 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.AreaCountGroupByOthersAndElectricityEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11213, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11253, 50, false);
#line 292 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.FarmrsCountGroupByOthersAndElectricityEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11303, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11343, 43, false);
#line 293 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.UnitCountGroupByOthersAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11386, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11426, 43, false);
#line 294 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.AreaCountGroupByOthersAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11469, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11509, 45, false);
#line 295 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(item.FarmrsCountGroupByOthersAndDieselEngines);

#line default
#line hidden
            EndContext();
            BeginContext(11554, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11594, 119, false);
#line 296 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByOthers + item.REBCountGroupByOthers + item.UnitCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(11713, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11753, 112, false);
#line 297 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.AreaCountGroupByOthersAndElectricityEngines + item.AreaCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(11865, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(11905, 116, false);
#line 298 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.FarmrsCountGroupByOthersAndElectricityEngines + item.FarmrsCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(12021, 146, true);
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Total</td>\r\n                            <td>");
            EndContext();
            BeginContext(12168, 71, false);
#line 303 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.PDBCountGroupByOthers));

#line default
#line hidden
            EndContext();
            BeginContext(12239, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(12279, 71, false);
#line 304 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.REBCountGroupByBADC + item.REBCountGroupByOthers));

#line default
#line hidden
            EndContext();
            BeginContext(12350, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(12390, 127, false);
#line 305 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.REBCountGroupByBADC + item.PDBCountGroupByOthers + item.REBCountGroupByOthers));

#line default
#line hidden
            EndContext();
            BeginContext(12517, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(12557, 115, false);
#line 306 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.AreaCountGroupByBADSAndElectricityEngines + item.AreaCountGroupByOthersAndElectricityEngines));

#line default
#line hidden
            EndContext();
            BeginContext(12672, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(12712, 119, false);
#line 307 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.FarmrsCountGroupByBADSAndElectricityEngines + item.FarmrsCountGroupByOthersAndElectricityEngines));

#line default
#line hidden
            EndContext();
            BeginContext(12831, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(12871, 105, false);
#line 308 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.UnitCountGroupByBADSAndDieselEngines + item.UnitCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(12976, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(13016, 105, false);
#line 309 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.AreaCountGroupByBADSAndDieselEngines + item.AreaCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(13121, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(13161, 109, false);
#line 310 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.FarmrsCountGroupByBADSAndDieselEngines + item.FarmrsCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(13270, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(13310, 217, false);
#line 311 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.PDBCountGroupByBADC + item.REBCountGroupByBADC + item.PDBCountGroupByOthers + item.REBCountGroupByOthers + item.UnitCountGroupByBADSAndDieselEngines + item.UnitCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(13527, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(13567, 205, false);
#line 312 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.AreaCountGroupByBADSAndElectricityEngines + item.AreaCountGroupByOthersAndElectricityEngines + item.AreaCountGroupByBADSAndDieselEngines + item.AreaCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(13772, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(13812, 213, false);
#line 313 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                           Write(Convert.ToDouble(item.FarmrsCountGroupByBADSAndElectricityEngines + item.FarmrsCountGroupByOthersAndElectricityEngines + item.FarmrsCountGroupByBADSAndDieselEngines + item.FarmrsCountGroupByOthersAndDieselEngines));

#line default
#line hidden
            EndContext();
            BeginContext(14025, 40, true);
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 316 "E:\Projects\BAC002\WebSite\BADCIrrigationEquipmentSurvey\Views\DataAnalysis\DivisionWiseIrrigationReports.cshtml"
                        c++;
                    }

#line default
#line hidden
            BeginContext(14118, 84, true);
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
