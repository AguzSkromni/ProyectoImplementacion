#pragma checksum "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49c92fc7faff55763a9341a4c5e79f2afef11d07"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49c92fc7faff55763a9341a4c5e79f2afef11d07", @"/Views/Citas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9a9b19f64c40fd988cb99b185ecaec7dfffde2", @"/Views/_ViewImports.cshtml")]
    public class Views_Citas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Domain.Cita>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
  
    ViewData["Title"] = "Citas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h1>\r\n    Mostrar:\r\n</h1>\r\n\r\n<table class=\"table table-striped text-center\">\r\n    <tr>\r\n        <td>Id</td>\r\n        <td>Paciente Id</td>\r\n        <td>Nombre</td>\r\n        <td>Estatus</td>\r\n        <td>Fecha</td>\r\n    </tr>\r\n");
#nullable restore
#line 20 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
     foreach (var e in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
           Write(e.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
           Write(e.Paciente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
           Write(e.Paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
            Write((Domain.Estatus)e.Estatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
           Write(e.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49c92fc7faff55763a9341a4c5e79f2afef11d076253", async() => {
                WriteLiteral(@"<svg xmlns=""http://www.w3.org/2000/svg""
                class=""icon icon-tabler icon-tabler-id"" width=""36"" height=""36"" viewBox=""0 0 24 24"" stroke-width=""2""
                stroke=""#005F9B"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round"">
                    <path stroke=""none"" d=""M0 0h24v24H0z"" fill=""none"" />
                    <rect x=""3"" y=""4"" width=""18"" height=""16"" rx=""3"" />
                    <circle cx=""9"" cy=""10"" r=""2"" />
                    <line x1=""15"" y1=""8"" x2=""17"" y2=""8"" />
                    <line x1=""15"" y1=""12"" x2=""17"" y2=""12"" />
                    <line x1=""7"" y1=""16"" x2=""17"" y2=""16"" />
                </svg>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
                                      WriteLiteral(e.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\r\n");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49c92fc7faff55763a9341a4c5e79f2afef11d079184", async() => {
                WriteLiteral(@"<svg xmlns=""http://www.w3.org/2000/svg""
                class=""icon icon-tabler icon-tabler-edit"" width=""36"" height=""36"" viewBox=""0 0 24 24"" stroke-width=""2""
                stroke=""#005F9B"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round"">
                    <path stroke=""none"" d=""M0 0h24v24H0z"" fill=""none"" />
                    <path d=""M9 7h-3a2 2 0 0 0 -2 2v9a2 2 0 0 0 2 2h9a2 2 0 0 0 2 -2v-3"" />
                    <path d=""M9 15h3l8.5 -8.5a1.5 1.5 0 0 0 -3 -3l-8.5 8.5v3"" />
                    <line x1=""16"" y1=""5"" x2=""19"" y2=""8"" />
                </svg>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
                                   WriteLiteral(e.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\r\n");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49c92fc7faff55763a9341a4c5e79f2afef11d0712013", async() => {
                WriteLiteral(@"<svg xmlns=""http://www.w3.org/2000/svg""
                class=""icon icon-tabler icon-tabler-trash"" width=""36"" height=""36"" viewBox=""0 0 24 24"" stroke-width=""2""
                stroke=""#005F9B"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round"">
                    <path stroke=""none"" d=""M0 0h24v24H0z"" fill=""none"" />
                    <line x1=""4"" y1=""7"" x2=""20"" y2=""7"" />
                    <line x1=""10"" y1=""11"" x2=""10"" y2=""17"" />
                    <line x1=""14"" y1=""11"" x2=""14"" y2=""17"" />
                    <path d=""M5 7l1 12a2 2 0 0 0 2 2h8a2 2 0 0 0 2 -2l1 -12"" />
                    <path d=""M9 7v-3a1 1 0 0 1 1 -1h4a1 1 0 0 1 1 1v3"" />
                </svg>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
                                     WriteLiteral(e.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Citas\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n");
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
