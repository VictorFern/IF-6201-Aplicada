#pragma checksum "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a2c0a406f943705ce5d8620babe072ce6622466"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Listar), @"mvc.1.0.view", @"/Views/Producto/Listar.cshtml")]
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
#line 1 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\_ViewImports.cshtml"
using ProvedorCorion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\_ViewImports.cshtml"
using ProvedorCorion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a2c0a406f943705ce5d8620babe072ce6622466", @"/Views/Producto/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3f6786f9bd3ba98e7b012189c348ddcf7583ee9", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProvedorCorion.Models.ProductoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-rounded img-hover mg-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("190"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("190"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml"
  
    ViewData["Title"] = "Ver Productos";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a2c0a406f943705ce5d8620babe072ce66224665285", async() => {
                WriteLiteral("\r\n    <div id=\"info\" class=\"text-center\">\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table class=""table"">
    <tr>
        <th>ID</th>
        <th>Nombre</th>
        <th>Marca</th>
        <th>Categoria</th>
        <th>Precio</th>
        <th>Dimensiones</th>
        <th>Descripcion</th>
        <th>Imagen</th>
        <th>Acciones</th>
    </tr>
");
#nullable restore
#line 22 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml"
     foreach (ProductoModel temp in ViewBag.Productos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml"
   Write(temp.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml"
   Write(temp.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml"
   Write(temp.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml"
   Write(temp.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml"
   Write(temp.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 30 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml"
   Write(temp.Dimensiones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 31 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml"
   Write(temp.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3a2c0a406f943705ce5d8620babe072ce66224669259", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 797, "~/img/", 797, 6, true);
#nullable restore
#line 32 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml"
AddHtmlAttributeValue("", 803, temp.Foto, 803, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n    <td>\r\n        <a class=\"btnTable\" type=\"button\" href=\"javascript:;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 918, "\"", 971, 5);
            WriteAttributeValue("", 928, "actualizarProducto(", 928, 19, true);
#nullable restore
#line 34 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml"
WriteAttributeValue("", 947, temp.Id, 947, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 955, ");", 955, 2, true);
            WriteAttributeValue(" ", 957, "return", 958, 7, true);
            WriteAttributeValue(" ", 964, "false;", 965, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Actualizar</a>\r\n        |\r\n        <a class=\"btnTable\" type=\"button\" href=\"javascript:;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1061, "\"", 1112, 5);
            WriteAttributeValue("", 1071, "eliminarProducto(", 1071, 17, true);
#nullable restore
#line 36 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml"
WriteAttributeValue("", 1088, temp.Id, 1088, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1096, ");", 1096, 2, true);
            WriteAttributeValue(" ", 1098, "return", 1099, 7, true);
            WriteAttributeValue(" ", 1105, "false;", 1106, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Eliminar</a>\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 39 "C:\Users\rivai\Documents\GitHub\ProvedorCorion\ProvedorCorion\Views\Producto\Listar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProvedorCorion.Models.ProductoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
