#pragma checksum "C:\Users\joven\Documents\MisPruebas\Presentacion2\IM02a3\Views\Home\Empleado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6568689928ca99c62896d09469e3cb8268d503ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Empleado), @"mvc.1.0.view", @"/Views/Home/Empleado.cshtml")]
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
#line 1 "C:\Users\joven\Documents\MisPruebas\Presentacion2\IM02a3\Views\_ViewImports.cshtml"
using IM02a3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joven\Documents\MisPruebas\Presentacion2\IM02a3\Views\_ViewImports.cshtml"
using IM02a3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6568689928ca99c62896d09469e3cb8268d503ff", @"/Views/Home/Empleado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0898de550e7e0254aba52b0bd3f991c8bd5b4dae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Empleado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Empleado>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Empleado</h1>\r\n<p>Nombre: ");
#nullable restore
#line 4 "C:\Users\joven\Documents\MisPruebas\Presentacion2\IM02a3\Views\Home\Empleado.cshtml"
      Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Edad: ");
#nullable restore
#line 4 "C:\Users\joven\Documents\MisPruebas\Presentacion2\IM02a3\Views\Home\Empleado.cshtml"
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
