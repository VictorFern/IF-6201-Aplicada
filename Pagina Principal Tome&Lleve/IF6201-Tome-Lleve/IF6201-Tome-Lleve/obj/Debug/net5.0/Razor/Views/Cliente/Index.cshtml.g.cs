#pragma checksum "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "794af142c1ee68ce8e61378025422c48dcf3d045"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"794af142c1ee68ce8e61378025422c48dcf3d045", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a45a74b3b2fc8d24eb2f804364bd53d1e764124", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IF6201_TomeYLleve.Models.ProductoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fit-image  d-block mx-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Responsive image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fit-image  rounded d-block m-l-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Cliente";
    Layout = "_LayoutCLiente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 8 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
     if (ViewData["Sugerencia"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <h2>Productos m??s solicitados</h2>
        <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
            <!-- Carousel indicators -->
            <ol class=""carousel-indicators"">
                <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                <li data-target=""#myCarousel"" data-slide-to=""2""></li>
                <li data-target=""#myCarousel"" data-slide-to=""3""></li>
                <li data-target=""#myCarousel"" data-slide-to=""4""></li>
            </ol>

            <!-- Wrapper for carousel items -->
            <div class=""carousel-inner"" role=""listbox"">
");
#nullable restore
#line 23 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
                  int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
                 foreach (ProductoModel temp in ViewBag.Sugerencia)
                {
                    i++;
                    var active = i == 1 ? "active" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 1129, "\"", 1158, 2);
            WriteAttributeValue("", 1137, "carousel-item", 1137, 13, true);
#nullable restore
#line 28 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
WriteAttributeValue(" ", 1150, active, 1151, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <figure>\r\n                            <a");
            BeginWriteAttribute("href", " href=\'", 1226, "\'", 1289, 1);
#nullable restore
#line 30 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 1233, Url.Action("producto", "Cliente", new { id = temp.id }), 1233, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "794af142c1ee68ce8e61378025422c48dcf3d0457883", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1370, "~/img/", 1370, 6, true);
#nullable restore
#line 31 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
AddHtmlAttributeValue("", 1376, temp.foto, 1376, 10, false);

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
            WriteLiteral("\r\n                            </a>\r\n                        </figure>\r\n                        <div class=\"col-md-12 text-center\">\r\n                            <h5 id=\"text\">");
#nullable restore
#line 35 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
                                     Write(temp.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p id=\"text\">???");
#nullable restore
#line 36 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
                                     Write(temp.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 39 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <a class=""carousel-control-prev carousel-dark"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next carousel-dark"" href=""#myCarousel"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
");
#nullable restore
#line 50 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 53 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
         foreach (ProductoModel tem in ViewBag.Producto)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4 col-md-4 col-sm-4 col-xs-12\">\r\n                <div class=\"box-part text-center\">\r\n                    <div class=\"title\">\r\n                        <br>\r\n                        <h4>");
#nullable restore
#line 59 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
                       Write(tem.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </div>\r\n                    <figure>\r\n                        <a");
            BeginWriteAttribute("href", " href=\'", 2743, "\'", 2805, 1);
#nullable restore
#line 62 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 2750, Url.Action("producto", "Cliente", new { id = tem.id }), 2750, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "794af142c1ee68ce8e61378025422c48dcf3d04513421", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2891, "~/img/", 2891, 6, true);
#nullable restore
#line 63 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
AddHtmlAttributeValue("", 2897, tem.foto, 2897, 9, false);

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
            WriteLiteral("\r\n                        </a>\r\n                    </figure>\r\n                    <div class=\"caption\">\r\n                        <h3>\r\n                            ???");
#nullable restore
#line 68 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
                        Write(tem.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h3>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 73 "C:\Program Files (x86)\EasyPHP-Devserver-17\eds-www\IF-6201-Aplicada\IF-6201-Aplicada\Pagina Principal Tome&Lleve\IF6201-Tome-Lleve\IF6201-Tome-Lleve\Views\Cliente\Index.cshtml"
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
