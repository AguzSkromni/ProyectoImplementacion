#pragma checksum "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caa8a89b4335a0010d8e73c24eb74cc29bc8e743"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Citas_Details), @"mvc.1.0.view", @"/Views/Citas/Details.cshtml")]
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
#line 1 "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\_ViewImports.cshtml"
using Presentation.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\_ViewImports.cshtml"
using Presentation.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caa8a89b4335a0010d8e73c24eb74cc29bc8e743", @"/Views/Citas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9a9b19f64c40fd988cb99b185ecaec7dfffde2", @"/Views/_ViewImports.cshtml")]
    public class Views_Citas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Cita>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Details.cshtml"
  
    ViewData["Title"] = "Citas > Detalle";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <dl class=\"row\">\r\n\r\n            Id: <dd>");
#nullable restore
#line 11 "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Details.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <br>\r\n            Estatus: <dd>");
#nullable restore
#line 13 "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Details.cshtml"
                     Write((Domain.Estatus)Model.Estatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <br>\r\n            Fecha: <dd>");
#nullable restore
#line 15 "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Details.cshtml"
                  Write(Model.Fecha.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n<hr />\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <dl class=\"row\">\r\n\r\n            Id: <dd>");
#nullable restore
#line 24 "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Details.cshtml"
               Write(Model.Paciente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <br>\r\n            Nombre: <dd>");
#nullable restore
#line 26 "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Details.cshtml"
                   Write(Model.Paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <br>\r\n            Edad: <dd>");
#nullable restore
#line 28 "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Details.cshtml"
                 Write(Model.Paciente.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <br>\r\n            Direccion: <dd>");
#nullable restore
#line 30 "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Details.cshtml"
                      Write(Model.Paciente.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <br>\r\n            Telefono: <dd>");
#nullable restore
#line 32 "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Details.cshtml"
                     Write(Model.Paciente.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <br>\r\n            Expediente: <dd><img");
            BeginWriteAttribute("src", " src=\"", 848, "\"", 880, 1);
#nullable restore
#line 34 "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Details.cshtml"
WriteAttributeValue("", 854, Model.Paciente.Expediente, 854, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ></dd>\r\n            <br>\r\n            Foto: <dd><img");
            BeginWriteAttribute("src", " src=\"", 934, "\"", 960, 1);
#nullable restore
#line 36 "C:\Users\acelv\Documents\GitHub\ProyectoImplementacion\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Details.cshtml"
WriteAttributeValue("", 940, Model.Paciente.Foto, 940, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></dd>\r\n\r\n        </dl>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caa8a89b4335a0010d8e73c24eb74cc29bc8e7438002", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Cita> Html { get; private set; }
    }
}
#pragma warning restore 1591
