#pragma checksum "C:\Users\Daniela\Downloads\Semestre 11\Programación web\Unidad 2\Unidad2Practica4\Unidad2Practica4\Views\Home\Informacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd2bebc7cde13407abac7f08086c9ad22178c776"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Informacion), @"mvc.1.0.view", @"/Views/Home/Informacion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd2bebc7cde13407abac7f08086c9ad22178c776", @"/Views/Home/Informacion.cshtml")]
    public class Views_Home_Informacion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Unidad2Practica4.Models.Carreras>
    {
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
#line 2 "C:\Users\Daniela\Downloads\Semestre 11\Programación web\Unidad 2\Unidad2Practica4\Unidad2Practica4\Views\Home\Informacion.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>\r\n    <a class=\"btn\" href=\"javascript: history.back()\">&#x25c0;  Regresar</a>\r\n\r\n    ");
#nullable restore
#line 8 "C:\Users\Daniela\Downloads\Semestre 11\Programación web\Unidad 2\Unidad2Practica4\Unidad2Practica4\Views\Home\Informacion.cshtml"
Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n\r\n<div class=\"info\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bd2bebc7cde13407abac7f08086c9ad22178c7763298", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 220, "~/images/", 220, 9, true);
#nullable restore
#line 12 "C:\Users\Daniela\Downloads\Semestre 11\Programación web\Unidad 2\Unidad2Practica4\Unidad2Practica4\Views\Home\Informacion.cshtml"
AddHtmlAttributeValue("", 229, Model.Id, 229, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 240, ".jpg", 240, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <a class=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 268, "\"", 314, 2);
#nullable restore
#line 13 "C:\Users\Daniela\Downloads\Semestre 11\Programación web\Unidad 2\Unidad2Practica4\Unidad2Practica4\Views\Home\Informacion.cshtml"
WriteAttributeValue("", 275, Model.Nombre.Replace(" ","-"), 275, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 305, "/Reticula", 305, 9, true);
            EndWriteAttribute();
            WriteLiteral(">Ver mapa curricular</a>\r\n</div>\r\n<div class=\"info\">\r\n    <dl>\r\n        <dt>Descripción:</dt>\r\n        <dd>");
#nullable restore
#line 18 "C:\Users\Daniela\Downloads\Semestre 11\Programación web\Unidad 2\Unidad2Practica4\Unidad2Practica4\Views\Home\Informacion.cshtml"
       Write(Model.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt>Plan de estudios:</dt>\r\n        <dd>");
#nullable restore
#line 20 "C:\Users\Daniela\Downloads\Semestre 11\Programación web\Unidad 2\Unidad2Practica4\Unidad2Practica4\Views\Home\Informacion.cshtml"
       Write(Model.Plan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt>Especialidad:</dt>\r\n        <dd>");
#nullable restore
#line 22 "C:\Users\Daniela\Downloads\Semestre 11\Programación web\Unidad 2\Unidad2Practica4\Unidad2Practica4\Views\Home\Informacion.cshtml"
       Write(Model.Especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Unidad2Practica4.Models.Carreras> Html { get; private set; }
    }
}
#pragma warning restore 1591
