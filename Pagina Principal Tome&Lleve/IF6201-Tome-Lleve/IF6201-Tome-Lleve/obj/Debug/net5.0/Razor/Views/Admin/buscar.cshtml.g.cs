#pragma checksum "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Admin\buscar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ace5f96e1a30548f2ff67853623796e3d2e7aef4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_buscar), @"mvc.1.0.view", @"/Views/Admin/buscar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ace5f96e1a30548f2ff67853623796e3d2e7aef4", @"/Views/Admin/buscar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a45a74b3b2fc8d24eb2f804364bd53d1e764124", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_buscar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IF6201_TomeYLleve.Models.ProductoModel>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Admin\buscar.cshtml"
  
    ViewData["Title"] = "Buscar Producto";
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Admin\buscar.cshtml"
         foreach (ProductoModel tem in ViewBag.Lista)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-6\" style=\"margin-top:50px;\">\r\n                <div id=\"box1\">\r\n                    <figure>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ace5f96e1a30548f2ff67853623796e3d2e7aef45058", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 444, "~/img/", 444, 6, true);
#nullable restore
#line 13 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Admin\buscar.cshtml"
AddHtmlAttributeValue("", 450, tem.foto, 450, 9, false);

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
            WriteLiteral(@"
                    </figure>
                </div>
            </div>
            <div class=""col-lg-3"">
                <div id=""box2"">
                    <div class=""title"">
                        <br>
                        <h4>
                            Producto: ");
#nullable restore
#line 22 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Admin\buscar.cshtml"
                                 Write(tem.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h4>\r\n                    </div>\r\n                    <div class=\"title\">\r\n                        <br>\r\n                        <h4>\r\n                            Detalle: ");
#nullable restore
#line 28 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Admin\buscar.cshtml"
                                Write(tem.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h4>\r\n                    </div>\r\n                    <div class=\"title\">\r\n                        <br>\r\n                        <h4>\r\n                            Precio: ₡");
#nullable restore
#line 34 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Admin\buscar.cshtml"
                                Write(tem.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h4>\r\n                    </div>\r\n                    <div class=\"title\">\r\n                        <br>\r\n                        <h4>\r\n                            Proveedor: ");
#nullable restore
#line 40 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Admin\buscar.cshtml"
                                  Write(tem.proveedorModel.proveedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h4>\r\n                    </div>\r\n                    <br />\r\n                </div>\r\n            </div>\r\n            <hr class=\"linea\">\r\n");
#nullable restore
#line 47 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Admin\buscar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    \r\n</div>\r\n");
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
