#pragma checksum "C:\Sirclo Test\berat\Berat.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17e5af8bb40419837a0d8863fffb191827b6f8e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Sirclo Test\berat\Berat.Web\Views\_ViewImports.cshtml"
using Berat.Web;

#line default
#line hidden
#line 2 "C:\Sirclo Test\berat\Berat.Web\Views\_ViewImports.cshtml"
using Berat.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17e5af8bb40419837a0d8863fffb191827b6f8e3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e80369a5070cd184492be6be6c614c816dfbcbc2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Sirclo Test\berat\Berat.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index Page";

#line default
#line hidden
            BeginContext(46, 453, true);
            WriteLiteral(@"
<div class=""clearfix""> <br /> </div>

<table id=""tblBerat"" class=""table table-striped"">
    <thead>
        <tr>
            <th>Tanggal</th>
            <th>Max</th>
            <th>Min</th>
            <th>Perbedaan</th>
        </tr>
    </thead>
    <tbody></tbody>
    <tfoot>
        <tr>
            <td>Rata Rata</td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </tfoot>
</table>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(516, 2474, true);
                WriteLiteral(@"
    <script>
        var oTable;
        $(document).ready(function () {
            oTable = $('#tblBerat').DataTable({
                ""ajax"": ""/Home/DataTableAjaxHandler/"",
                ""processing"": true,
                ""serverSide"": true,
                ""bAutoWidth"": false,
                ""sortable"": false,
                ""orderable"": false,
                ""columns"": [
                    { ""data"": ""tanggal"" },
                    { ""data"": ""beratMax"" },
                    { ""data"": ""beratMin"" },
                    { ""data"": null },
                    { ""data"": ""id"", ""visible"": false }
                ],
                ""columnDefs"": [
                    {
                        ""render"": function (data, type, row, meta) {
                            var baseUrl = ""/Home/Edit/"" + row.id;
                            return '<a href=""' + baseUrl + '"">' + data + '</a>';
                        },
                        ""targets"": 0
                    },              ");
                WriteLiteral(@"      
                    {
                        ""render"": function (data, type, row, meta) {
                            return parseInt(row.beratMax) - parseInt(row.beratMin);
                        },
                        ""targets"": 3
                    }
                ],
                ""footerCallback"": function (row, data, start, end, display) {                                        
                    var api = this.api(), data;
                    // Total over all pages
                    avgMax = api
                        .column(1)
                        .data()
                        .reduce(function (a, b) {
                            return ((a * 1) + (b * 1) / data.length).toFixed(1);
                        }, 0);

                    // Total over this page
                    avgMin = api
                        .column(2)
                        .data()
                        .reduce(function (a, b) {
                            return ((a * 1) + (");
                WriteLiteral(@"b * 1) / data.length).toFixed(1);
                        }, 0);

                    avgPerbedaan = (avgMax - avgMin).toFixed(1);
                    // Update footer
                    $(api.column(1).footer()).html(avgMax);
                    $(api.column(2).footer()).html(avgMin);
                    $(api.column(3).footer()).html(avgPerbedaan);
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
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
