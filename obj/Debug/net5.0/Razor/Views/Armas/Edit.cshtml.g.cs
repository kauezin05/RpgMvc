#pragma checksum "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4640f3dc8638d586f17046a00048d32f95333873"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Armas_Edit), @"mvc.1.0.view", @"/Views/Armas/Edit.cshtml")]
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
#line 1 "D:\Etec\M2\DS\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Etec\M2\DS\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4640f3dc8638d586f17046a00048d32f95333873", @"/Views/Armas/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Armas_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.ArmaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
  
    ViewBag.Title = "Editar Personagem";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 10 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 11 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Configura????o para exibir mensagem de erro -->\r\n");
#nullable restore
#line 13 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 16 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 17 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Editar dados da Arma</h2>\r\n");
#nullable restore
#line 21 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
       Write(Html.LabelFor(model => model.Id, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 29 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
           Write(Html.EditorFor(model => model.Id, new { htmlAttributes = new { @class = "form-control", @readonly =
            "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 34 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 36 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 40 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
       Write(Html.LabelFor(model => model.Dano, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 42 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
           Write(Html.EditorFor(model => model.Dano, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 47 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
       Write(Html.DisplayName("Personagem"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 49 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
           Write(Html.DropDownListFor(model => model.PersonagemId, new SelectList(@ViewBag.PersonagemId,"Id", "Nome"),
            "---Selecione---", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-6\">\r\n                <input type=\"submit\" value=\"Salvar altera????es\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 59 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 61 "D:\Etec\M2\DS\RpgMvc\Views\Armas\Edit.cshtml"
Write(Html.ActionLink("Retornar", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.ArmaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
