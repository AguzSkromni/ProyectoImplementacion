#pragma checksum "E:\Implementacion\MisPruebas\im221e03\src\Presentation.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afad5f7d0238c20420ee7a9052b4bc9ba1eec218"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\Implementacion\MisPruebas\im221e03\src\Presentation.WebApp\Views\_ViewImports.cshtml"
using Presentation.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Implementacion\MisPruebas\im221e03\src\Presentation.WebApp\Views\_ViewImports.cshtml"
using Presentation.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afad5f7d0238c20420ee7a9052b4bc9ba1eec218", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9a9b19f64c40fd988cb99b185ecaec7dfffde2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Domain.Cita>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Implementacion\MisPruebas\im221e03\src\Presentation.WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\Implementacion\MisPruebas\im221e03\src\Presentation.WebApp\Views\Home\Index.cshtml"
  
    // ToDo

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--https://datatables.net/-->
<link href=""//cdn.datatables.net/1.10.25/css/dataTables.bootstrap4.min.css"" rel=""stylesheet"" type=""text/css"">
<link href=""//cdn.datatables.net/buttons/1.7.1/css/buttons.bootstrap4.min.css"" rel=""stylesheet"" type=""text/css"">

<div class=""row"">
    <div class=""col"">
        <canvas id=""myChart1"" class=""my-4 w-100 chartjs-render-monitor""></canvas>
    </div>
    <div class=""col"">
        <canvas id=""myChart2"" class=""my-4 w-100 chartjs-render-monitor""></canvas>
    </div>
</div>

<table id=""myTable"" class=""table table-striped table-bordered"">

    <!-- ToDo -->

</table>

");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <style>\r\n        ");
                WriteLiteral(@"@keyframeschartjs-render-animation {
            from {
                opacity: .99
            }

            to {
                opacity: 1
            }
        }

        .chartjs-render-monitor {
            animation: chartjs-render-animation 1ms;
            max-height: 600px;
            display: block;
        }

        .chartjs-size-monitor,
        .chartjs-size-monitor-expand,
        .chartjs-size-monitor-shrink {
            position: absolute;
            direction: ltr;
            left: 0;
            top: 0;
            right: 0;
            bottom: 0;
            overflow: hidden;
            pointer-events: none;
            visibility: hidden;
            z-index: -1
        }

            .chartjs-size-monitor-expand > div {
                position: absolute;
                width: 1000000px;
                height: 1000000px;
                left: 0;
                top: 0
            }

            .chartjs-size-monitor-shrink > div {
       ");
                WriteLiteral("         position: absolute;\r\n                width: 200%;\r\n                height: 200%;\r\n                left: 0;\r\n                top: 0\r\n            }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <!--https://datatables.net/-->
    <script src=""//cdn.datatables.net/1.10.25/js/jquery.dataTables.min.js"" type=""text/javascript"" charset=""utf-8""></script>
    <script src=""//cdn.datatables.net/1.10.25/js/dataTables.bootstrap4.min.js"" type=""text/javascript"" charset=""utf-8""></script>
    <script src=""//cdn.datatables.net/buttons/1.7.1/js/dataTables.buttons.min.js"" type=""text/javascript"" charset=""utf-8""></script>
    <script src=""//cdn.datatables.net/buttons/1.7.1/js/buttons.bootstrap4.min.js"" type=""text/javascript"" charset=""utf-8""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js"" type=""text/javascript"" charset=""utf-8""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/pdfmake.min.js"" type=""text/javascript"" charset=""utf-8""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vfs_fonts.js"" type=""text/javascript"" charset=""utf-8""></script>
    <script src=""//cdn.datatables.net/buttons/1.7.1/js/buttons.html5.min.js"" type=");
                WriteLiteral(@"""text/javascript"" charset=""utf-8""></script>

    <script>
               // ToDo
    </script>


    <!--https://www.chartjs.org/-->
    <script src=""//cdn.jsdelivr.net/npm/chart.js@3.4.1/dist/chart.min.js"" type=""text/javascript"" charset=""utf-8""></script>
    <script>

                // ToDo
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Domain.Cita>> Html { get; private set; }
    }
}
#pragma warning restore 1591