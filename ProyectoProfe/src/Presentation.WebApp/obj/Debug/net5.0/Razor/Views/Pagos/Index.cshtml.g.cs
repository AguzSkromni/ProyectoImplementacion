#pragma checksum "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4ae744ca63602e8197f77e7511aa47732356b0c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4ae744ca63602e8197f77e7511aa47732356b0c", @"/Views/Pagos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9a9b19f64c40fd988cb99b185ecaec7dfffde2", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Domain.Pago>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml"
  
    ViewData["Title"] = "Pagos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4ae744ca63602e8197f77e7511aa47732356b0c4624", async() => {
                WriteLiteral(@"<svg xmlns=""http://www.w3.org/2000/svg"" class=""icon icon-tabler icon-tabler-user-plus""
            width=""44"" height=""44"" viewBox=""0 0 24 24"" stroke-width=""2"" stroke=""#005F9B"" fill=""none""
            stroke-linecap=""round"" stroke-linejoin=""round"">
            <path stroke=""none"" d=""M0 0h24v24H0z"" fill=""none"" />
            <circle cx=""9"" cy=""7"" r=""4"" />
            <path d=""M3 21v-2a4 4 0 0 1 4 -4h4a4 4 0 0 1 4 4v2"" />
            <path d=""M16 11h6m-3 -3v6"" />
        </svg>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<h1>\r\n    Mostrar:\r\n</h1>\r\n\r\n<table class=\"table table-striped text-center\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>TOTAL</th>\r\n        <th>FECHA</th>\r\n        <th>FACTURA</th>\r\n    </tr>\r\n");
#nullable restore
#line 29 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml"
     foreach (var e in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 32 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml"
           Write(e.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 33 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml"
           Write(e.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <th>");
#nullable restore
#line 34 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml"
           Write(e.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 959, "\"", 972, 1);
#nullable restore
#line 35 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml"
WriteAttributeValue("", 965, e.Foto, 965, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"80\" width=\"80\"></td>\r\n\r\n            <td>\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4ae744ca63602e8197f77e7511aa47732356b0c8083", async() => {
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml"
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
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4ae744ca63602e8197f77e7511aa47732356b0c11058", async() => {
                WriteLiteral(@"<svg xmlns=""http://www.w3.org/2000/svg""
                    class=""icon icon-tabler icon-tabler-edit"" width=""36"" height=""36"" viewBox=""0 0 24 24""
                    stroke-width=""2"" stroke=""#005F9B"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round"">
                        <path stroke=""none"" d=""M0 0h24v24H0z"" fill=""none"" />
                        <path d=""M9 7h-3a2 2 0 0 0 -2 2v9a2 2 0 0 0 2 2h9a2 2 0 0 0 2 -2v-3"" />
                        <path d=""M9 15h3l8.5 -8.5a1.5 1.5 0 0 0 -3 -3l-8.5 8.5v3"" />
                        <line x1=""16"" y1=""5"" x2=""19"" y2=""8"" />
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
#line 51 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml"
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
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4ae744ca63602e8197f77e7511aa47732356b0c13924", async() => {
                WriteLiteral(@"<svg xmlns=""http://www.w3.org/2000/svg""
                    class=""icon icon-tabler icon-tabler-trash"" width=""36"" height=""36"" viewBox=""0 0 24 24""
                    stroke-width=""2"" stroke=""#005F9B"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round"">
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml"
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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 73 "E:\Implementacion\ImplementacionMain\ProyectoProfe\src\Presentation.WebApp\Views\Pagos\Index.cshtml"
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
