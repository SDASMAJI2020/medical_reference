#pragma checksum "I:\ERPMedical\ErpMedicalShop\ERPMEDICAL\Views\Puchase\Item.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02ab4b1e2ef5f81d6e26ef7509a780ff3250c750"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Puchase_Item), @"mvc.1.0.view", @"/Views/Puchase/Item.cshtml")]
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
#nullable restore
#line 1 "I:\ERPMedical\ErpMedicalShop\ERPMEDICAL\Views\_ViewImports.cshtml"
using ERPMEDICAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\ERPMedical\ErpMedicalShop\ERPMEDICAL\Views\_ViewImports.cshtml"
using ERPMEDICAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ab4b1e2ef5f81d6e26ef7509a780ff3250c750", @"/Views/Puchase/Item.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e11a10be3ed8b04f24afc0c5d4c8140f2b712181", @"/Views/_ViewImports.cshtml")]
    public class Views_Puchase_Item : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "CA", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "NV", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "OR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "WA", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal form-bordered"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "I:\ERPMedical\ErpMedicalShop\ERPMEDICAL\Views\Puchase\Item.cshtml"
  
    ViewData["Title"] = "Item";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- start: page -->
    <section class=""panel"">
        <header class=""panel-heading"">
            <div class=""panel-actions"">
                <a href=""#"" class=""fa fa-caret-down""></a>
                <a href=""#"" class=""fa fa-times""></a>
            </div>
            <h2 class=""panel-title"">Rows with Details</h2>
        </header>
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""mb-md"">
                        <button id=""addToTable"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#itemModal"">Add <i class=""fa fa-plus""></i></button>
                    </div>
                </div>
            </div>
            <table class=""table table-bordered table-striped mb-none"" id=""datatable-details"">
                <thead>
                    <tr>
                        <th>Rendering engine</th>
                        <th>Browser</th>
                        <th>Platform(s)</th>
                 ");
            WriteLiteral(@"       <th>Engine version</th>
                        <th>CSS grade</th>
                    </tr>
                </thead>
                <tbody>
                    <tr class=""gradeX"">
                        <td>Trident</td>
                        <td>
                            Internet
                            Explorer 4.0
                        </td>
                        <td>Win 95+</td>
                        <td class=""center"">4</td>
                        <td class=""center"">X</td>
                    </tr>
                    <tr class=""gradeC"">
                        <td>Trident</td>
                        <td>
                            Internet
                            Explorer 5.0
                        </td>
                        <td>Win 95+</td>
                        <td class=""center"">5</td>
                        <td class=""center"">C</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Trident</td");
            WriteLiteral(@">
                        <td>
                            Internet
                            Explorer 5.5
                        </td>
                        <td>Win 95+</td>
                        <td class=""center"">5.5</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Trident</td>
                        <td>
                            Internet
                            Explorer 6
                        </td>
                        <td>Win 98+</td>
                        <td class=""center"">6</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Trident</td>
                        <td>Internet Explorer 7</td>
                        <td>Win XP SP2+</td>
                        <td class=""center"">7</td>
                        <td class=""center"">A</td>
                    </tr>
  ");
            WriteLiteral(@"                  <tr class=""gradeA"">
                        <td>Trident</td>
                        <td>AOL browser (AOL desktop)</td>
                        <td>Win XP</td>
                        <td class=""center"">6</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Firefox 1.0</td>
                        <td>Win 98+ / OSX.2+</td>
                        <td class=""center"">1.7</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Firefox 1.5</td>
                        <td>Win 98+ / OSX.2+</td>
                        <td class=""center"">1.8</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
              ");
            WriteLiteral(@"          <td>Firefox 2.0</td>
                        <td>Win 98+ / OSX.2+</td>
                        <td class=""center"">1.8</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Firefox 3.0</td>
                        <td>Win 2k+ / OSX.3+</td>
                        <td class=""center"">1.9</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Camino 1.0</td>
                        <td>OSX.2+</td>
                        <td class=""center"">1.8</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Camino 1.5</td>
                        <td>OSX.3+</td>
                        <td class=""c");
            WriteLiteral(@"enter"">1.8</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Netscape 7.2</td>
                        <td>Win 95+ / Mac OS 8.6-9.2</td>
                        <td class=""center"">1.7</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Netscape Browser 8</td>
                        <td>Win 98SE+</td>
                        <td class=""center"">1.7</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Netscape Navigator 9</td>
                        <td>Win 98+ / OSX.2+</td>
                        <td class=""center"">1.8</td>
                        <td class=""center"">A</td>
           ");
            WriteLiteral(@"         </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Mozilla 1.0</td>
                        <td>Win 95+ / OSX.1+</td>
                        <td class=""center"">1</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Mozilla 1.1</td>
                        <td>Win 95+ / OSX.1+</td>
                        <td class=""center"">1.1</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Mozilla 1.2</td>
                        <td>Win 95+ / OSX.1+</td>
                        <td class=""center"">1.2</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
  ");
            WriteLiteral(@"                      <td>Mozilla 1.3</td>
                        <td>Win 95+ / OSX.1+</td>
                        <td class=""center"">1.3</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Mozilla 1.4</td>
                        <td>Win 95+ / OSX.1+</td>
                        <td class=""center"">1.4</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Mozilla 1.5</td>
                        <td>Win 95+ / OSX.1+</td>
                        <td class=""center"">1.5</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Mozilla 1.6</td>
                        <td>Win 95+ / OSX.1+</td>
  ");
            WriteLiteral(@"                      <td class=""center"">1.6</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Mozilla 1.7</td>
                        <td>Win 98+ / OSX.1+</td>
                        <td class=""center"">1.7</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Mozilla 1.8</td>
                        <td>Win 98+ / OSX.1+</td>
                        <td class=""center"">1.8</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Seamonkey 1.1</td>
                        <td>Win 98+ / OSX.2+</td>
                        <td class=""center"">1.8</td>
                        <td class=""center"">A");
            WriteLiteral(@"</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Gecko</td>
                        <td>Epiphany 2.20</td>
                        <td>Gnome</td>
                        <td class=""center"">1.8</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Webkit</td>
                        <td>Safari 1.2</td>
                        <td>OSX.3</td>
                        <td class=""center"">125.5</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Webkit</td>
                        <td>Safari 1.3</td>
                        <td>OSX.3</td>
                        <td class=""center"">312.8</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Webkit</td>
        ");
            WriteLiteral(@"                <td>Safari 2.0</td>
                        <td>OSX.4+</td>
                        <td class=""center"">419.3</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Webkit</td>
                        <td>Safari 3.0</td>
                        <td>OSX.4+</td>
                        <td class=""center"">522.1</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Webkit</td>
                        <td>OmniWeb 5.5</td>
                        <td>OSX.4+</td>
                        <td class=""center"">420</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Webkit</td>
                        <td>iPod Touch / iPhone</td>
                        <td>iPod</td>
                        <td class=""ce");
            WriteLiteral(@"nter"">420.1</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Webkit</td>
                        <td>S60</td>
                        <td>S60</td>
                        <td class=""center"">413</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Presto</td>
                        <td>Opera 7.0</td>
                        <td>Win 95+ / OSX.1+</td>
                        <td class=""center"">-</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Presto</td>
                        <td>Opera 7.5</td>
                        <td>Win 95+ / OSX.2+</td>
                        <td class=""center"">-</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr cla");
            WriteLiteral(@"ss=""gradeA"">
                        <td>Presto</td>
                        <td>Opera 8.0</td>
                        <td>Win 95+ / OSX.2+</td>
                        <td class=""center"">-</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Presto</td>
                        <td>Opera 8.5</td>
                        <td>Win 95+ / OSX.2+</td>
                        <td class=""center"">-</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Presto</td>
                        <td>Opera 9.0</td>
                        <td>Win 95+ / OSX.3+</td>
                        <td class=""center"">-</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Presto</td>
                        <td>Opera 9.2</td>
       ");
            WriteLiteral(@"                 <td>Win 88+ / OSX.3+</td>
                        <td class=""center"">-</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Presto</td>
                        <td>Opera 9.5</td>
                        <td>Win 88+ / OSX.3+</td>
                        <td class=""center"">-</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Presto</td>
                        <td>Opera for Wii</td>
                        <td>Wii</td>
                        <td class=""center"">-</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Presto</td>
                        <td>Nokia N800</td>
                        <td>N800</td>
                        <td class=""center"">-</td>
                        <td cla");
            WriteLiteral(@"ss=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Presto</td>
                        <td>Nintendo DS browser</td>
                        <td>Nintendo DS</td>
                        <td class=""center"">8.5</td>
                        <td class=""center"">C/A<sup>1</sup></td>
                    </tr>
                    <tr class=""gradeC"">
                        <td>KHTML</td>
                        <td>Konqureror 3.1</td>
                        <td>KDE 3.1</td>
                        <td class=""center"">3.1</td>
                        <td class=""center"">C</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>KHTML</td>
                        <td>Konqureror 3.3</td>
                        <td>KDE 3.3</td>
                        <td class=""center"">3.3</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeA"">
   ");
            WriteLiteral(@"                     <td>KHTML</td>
                        <td>Konqureror 3.5</td>
                        <td>KDE 3.5</td>
                        <td class=""center"">3.5</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeX"">
                        <td>Tasman</td>
                        <td>Internet Explorer 4.5</td>
                        <td>Mac OS 8-9</td>
                        <td class=""center"">-</td>
                        <td class=""center"">X</td>
                    </tr>
                    <tr class=""gradeC"">
                        <td>Tasman</td>
                        <td>Internet Explorer 5.1</td>
                        <td>Mac OS 7.6-9</td>
                        <td class=""center"">1</td>
                        <td class=""center"">C</td>
                    </tr>
                    <tr class=""gradeC"">
                        <td>Tasman</td>
                        <td>Internet Explorer 5.2</td>
 ");
            WriteLiteral(@"                       <td>Mac OS 8-X</td>
                        <td class=""center"">1</td>
                        <td class=""center"">C</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Misc</td>
                        <td>NetFront 3.1</td>
                        <td>Embedded devices</td>
                        <td class=""center"">-</td>
                        <td class=""center"">C</td>
                    </tr>
                    <tr class=""gradeA"">
                        <td>Misc</td>
                        <td>NetFront 3.4</td>
                        <td>Embedded devices</td>
                        <td class=""center"">-</td>
                        <td class=""center"">A</td>
                    </tr>
                    <tr class=""gradeX"">
                        <td>Misc</td>
                        <td>Dillo 0.8</td>
                        <td>Embedded devices</td>
                        <td class=""center"">-</td>
           ");
            WriteLiteral(@"             <td class=""center"">X</td>
                    </tr>
                    <tr class=""gradeX"">
                        <td>Misc</td>
                        <td>Links</td>
                        <td>Text only</td>
                        <td class=""center"">-</td>
                        <td class=""center"">X</td>
                    </tr>
                    <tr class=""gradeX"">
                        <td>Misc</td>
                        <td>Lynx</td>
                        <td>Text only</td>
                        <td class=""center"">-</td>
                        <td class=""center"">X</td>
                    </tr>
                    <tr class=""gradeC"">
                        <td>Misc</td>
                        <td>IE Mobile</td>
                        <td>Windows Mobile 6</td>
                        <td class=""center"">-</td>
                        <td class=""center"">C</td>
                    </tr>
                    <tr class=""gradeC"">
                        <td");
            WriteLiteral(@">Misc</td>
                        <td>PSP browser</td>
                        <td>PSP</td>
                        <td class=""center"">-</td>
                        <td class=""center"">C</td>
                    </tr>
                    <tr class=""gradeU"">
                        <td>Other browsers</td>
                        <td>All others</td>
                        <td>-</td>
                        <td class=""center"">-</td>
                        <td class=""center"">U</td>
                    </tr>
                </tbody>
            </table>
        </div>

        <div class=""modal fade"" id=""itemModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""itemModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Vendor Entry</h5>
                        <button type=""button"" class=""close"" data-");
            WriteLiteral(@"dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""row"">
                            <div class=""col-xs-12"">
                                <section class=""panel"">
                                    <header class=""panel-heading"">
                                        <div class=""panel-actions"">
                                            <a href=""#"" class=""fa fa-caret-down""></a>
                                            <a href=""#"" class=""fa fa-times""></a>
                                        </div>

                                        <h2 class=""panel-title"">Vendor Entry</h2>
                                    </header>
                                    <div class=""panel-body"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ab4b1e2ef5f81d6e26ef7509a780ff3250c75026862", async() => {
                WriteLiteral(@"
                                            <div class=""form-group"">
                                                <label class=""col-md-3 control-label"" for=""txtItemName"">Item Name</label>
                                                <div class=""col-md-6"">
                                                    <input type=""text"" class=""form-control input-rounded"" id=""txtItemName"" name=""ItemName"" autocomplete=""off"">
                                                </div>
                                            </div>
                                            <div class=""form-group"">
                                                <label class=""col-md-3 control-label"" for=""txtDescription"">Description</label>
                                                <div class=""col-md-6"">
                                                    <textarea class=""form-control input-rounded"" name=""address"" rows=""3"" id=""txtDescription"" data-plugin-textarea-autosize></textarea>
                                   ");
                WriteLiteral(@"             </div>
                                            </div>
                                            <div class=""form-group"">
                                                <label class=""col-md-3 control-label"" for=""txtVendorName"">Item No</label>
                                                <div class=""col-md-6"">
                                                    <input type=""text"" class=""form-control input-rounded"" id=""txtItemNo"" name=""ItemNo"" disabled=""disabled"">
                                                </div>
                                            </div>
                                            <div class=""form-group"">
                                                <label class=""col-md-3 control-label"">Item Group</label>
                                                <div class=""col-md-6"">
                                                    <select data-plugin-selectTwo class=""form-control populate"">
                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ab4b1e2ef5f81d6e26ef7509a780ff3250c75029259", async() => {
                    WriteLiteral("California");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ab4b1e2ef5f81d6e26ef7509a780ff3250c75030543", async() => {
                    WriteLiteral("Nevada");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ab4b1e2ef5f81d6e26ef7509a780ff3250c75031823", async() => {
                    WriteLiteral("Oregon");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ab4b1e2ef5f81d6e26ef7509a780ff3250c75033103", async() => {
                    WriteLiteral("Washington");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    </select>\r\n                                                </div>\r\n                                            </div>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </section>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                        <button type=""button"" class=""btn btn-primary"">Save changes</button>
                    </div>
                </div>
            </div>
        </div>
    </section>
<!-- end: page -->
");
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
