#pragma checksum "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cf7d9c3cdd8dd8dbf9be6da128f7b602f740a75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagos_Index), @"mvc.1.0.view", @"/Views/Pagos/Index.cshtml")]
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
#line 1 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\_ViewImports.cshtml"
using Presentation.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\_ViewImports.cshtml"
using Presentation.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cf7d9c3cdd8dd8dbf9be6da128f7b602f740a75", @"/Views/Pagos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9a9b19f64c40fd988cb99b185ecaec7dfffde2", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Domain.Pago>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml"
  
    ViewData["Title"] = "Pagos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<p>\r\n    <!-- ToDo -->\r\n</p>\r\n\r\n<table class=\"table table-striped text-center\">\r\n    <!-- ToDo -->\r\n");
#nullable restore
#line 13 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml"
     foreach (var e in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- ToDo -->\r\n");
#nullable restore
#line 16 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Domain.Pago>> Html { get; private set; }
    }
}
#pragma warning restore 1591
