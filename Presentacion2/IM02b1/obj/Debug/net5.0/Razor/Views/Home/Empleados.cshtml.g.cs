#pragma checksum "E:\Implementacion\ProyectoImplementacion\Presentacion2\IM02b1\Views\Home\Empleados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3303bad22e60960e4bfa8326868f310198fd35a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Empleados), @"mvc.1.0.view", @"/Views/Home/Empleados.cshtml")]
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
#line 1 "E:\Implementacion\ProyectoImplementacion\Presentacion2\IM02b1\Views\_ViewImports.cshtml"
using IM02b1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Implementacion\ProyectoImplementacion\Presentacion2\IM02b1\Views\_ViewImports.cshtml"
using IM02b1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3303bad22e60960e4bfa8326868f310198fd35a", @"/Views/Home/Empleados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c677a75b050b20d3bdb820a9265d322180101ca6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Empleados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Empleado>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "E:\Implementacion\ProyectoImplementacion\Presentacion2\IM02b1\Views\Home\Empleados.cshtml"
Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>");
#nullable restore
#line 4 "E:\Implementacion\ProyectoImplementacion\Presentacion2\IM02b1\Views\Home\Empleados.cshtml"
Write(Model.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Empleado> Html { get; private set; }
    }
}
#pragma warning restore 1591
