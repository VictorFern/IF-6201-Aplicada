#pragma checksum "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a0af368722cd32f1ddb66c790eeb4fd4fb6478f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_producto), @"mvc.1.0.view", @"/Views/Cliente/producto.cshtml")]
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
#line 1 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\_ViewImports.cshtml"
using IF6201_TomeYLleve;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\_ViewImports.cshtml"
using IF6201_TomeYLleve.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a0af368722cd32f1ddb66c790eeb4fd4fb6478f", @"/Views/Cliente/producto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a45a74b3b2fc8d24eb2f804364bd53d1e764124", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_producto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IF6201_TomeYLleve.Models.ProductoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fit-image  rounded d-block m-l-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Responsive image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
  
    ViewData["Title"] = "Buscar Producto";
    Layout = "_LayoutCliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
         foreach (ProductoModel tem in ViewBag.Detalle)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6\">\r\n                <div id=\"box1\">\r\n                    <figure>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6a0af368722cd32f1ddb66c790eeb4fd4fb6478f5199", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 425, "~/img/", 425, 6, true);
#nullable restore
#line 14 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
AddHtmlAttributeValue("", 431, tem.foto, 431, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </figure>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n\r\n                <div id=\"box2\">\r\n                    <div class=\"title\">\r\n                        <br>\r\n                        <h4>");
#nullable restore
#line 23 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
                       Write(tem.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </div>\r\n\r\n                    <div class=\"text\">\r\n                        <span>Descripci??n: ");
#nullable restore
#line 27 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
                                      Write(tem.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"caption\">\r\n                        <h3>\r\n                            Precio: ???");
#nullable restore
#line 31 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
                                Write(tem.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h3>\r\n                    </div>\r\n                    <div class=\"caption\">\r\n                        <h3>\r\n                            Tama??o: ");
#nullable restore
#line 36 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
                               Write(tem.dimension);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h3>\r\n                    </div>\r\n                    <div class=\"caption\">\r\n                        <h3>\r\n                            Otras caracteristicas: ");
#nullable restore
#line 41 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
                                              Write(tem.otrascaracteristicas);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h3>\r\n                    </div>\r\n                    <div class=\"caption\">\r\n                        <h3>\r\n                            Disponibles: ");
#nullable restore
#line 46 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
                                    Write(tem.cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </h3>
                    </div>
                </div>
            </div>
            <br />
            <div class=""col-md-6"" style=""margin-top:25px;"">
                <div id=""box3"">
                    <div class=""form-group"">
                        <input type=""hidden"" class=""form-control"" id=""idP"" name=""idP""");
            BeginWriteAttribute("value", " value=\"", 1949, "\"", 1964, 1);
#nullable restore
#line 55 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
WriteAttributeValue("", 1957, tem.id, 1957, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <input  type=\"hidden\" class=\"form-control\" id=\"idU\" name=\"idE\"");
            BeginWriteAttribute("value", " value=\"", 2056, "\"", 2080, 1);
#nullable restore
#line 56 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
WriteAttributeValue("", 2064, ViewBag.Session, 2064, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <select id=\"cantidades\" class=\"form-control\" name=\"ListaSub\" style=\"width:100px;\" required>\r\n\r\n");
#nullable restore
#line 59 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
                              
                                var cont = 1;
                                string cantId;
                                var cantStock = 1;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
                             while (cantStock <= tem.cantidad)
                            {
                                cantId = "CantId" + cont;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a0af368722cd32f1ddb66c790eeb4fd4fb6478f12676", async() => {
                WriteLiteral(" ");
#nullable restore
#line 69 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
                                                       Write(cantStock);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
                                   WriteLiteral(cantStock);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"

                                cont++;
                                cantStock++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </select><br>

                        <input type=""button"" name=""carrito"" class=""btn btn-primary"" value=""A??adir a carrito"" href=""javascript:;"" onclick=""AgregarCarrito($('#idP').val(), $('#idU').val(), $('#cantidades').val()); return false;"">
                        <div>
                            <br />
                            <span id=""resultado""></span>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <a");
            BeginWriteAttribute("href", " href=\'", 3303, "\'", 3364, 1);
#nullable restore
#line 84 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
WriteAttributeValue("", 3310, Url.Action("comprar", "Cliente", new { id = tem.id }), 3310, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input type=\"submit\" value=\"Comprar\" class=\"btn btn-primary\" style=\"width:120px;\" />\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 90 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\producto.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IF6201_TomeYLleve.Models.ProductoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
