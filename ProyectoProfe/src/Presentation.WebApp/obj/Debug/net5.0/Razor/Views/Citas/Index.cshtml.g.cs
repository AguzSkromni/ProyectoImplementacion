#pragma checksum "C:\Users\Riskmathics10\Documents\GithubNetlify\Implementacion\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "094425e733b3a2706b19a8b2cf5da21945b7ed99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Citas_Index), @"mvc.1.0.view", @"/Views/Citas/Index.cshtml")]
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
#line 1 "C:\Users\Riskmathics10\Documents\GithubNetlify\Implementacion\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\_ViewImports.cshtml"
using Presentation.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Riskmathics10\Documents\GithubNetlify\Implementacion\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\_ViewImports.cshtml"
using Presentation.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"094425e733b3a2706b19a8b2cf5da21945b7ed99", @"/Views/Citas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9a9b19f64c40fd988cb99b185ecaec7dfffde2", @"/Views/_ViewImports.cshtml")]
    public class Views_Citas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Domain.Cita>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Riskmathics10\Documents\GithubNetlify\Implementacion\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
  
    ViewData["Title"] = "Citas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table class=\"table table-striped text-center\">\r\n    <!-- ToDo -->\r\n");
#nullable restore
#line 9 "C:\Users\Riskmathics10\Documents\GithubNetlify\Implementacion\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
     foreach (var e in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- ToDo -->\r\n");
#nullable restore
#line 12 "C:\Users\Riskmathics10\Documents\GithubNetlify\Implementacion\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Domain.Cita>> Html { get; private set; }
    }
}
#pragma warning restore 1591
