#pragma checksum "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24b491f0bcdb7cc74bc74beb11815bcf45007d3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Disputas_IndexHabilidades), @"mvc.1.0.view", @"/Views/Disputas/IndexHabilidades.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24b491f0bcdb7cc74bc74beb11815bcf45007d3a", @"/Views/Disputas/IndexHabilidades.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Disputas_IndexHabilidades : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.DisputaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 8 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 9 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 13 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 14 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Ataque com Habilidade</h2>\r\n");
#nullable restore
#line 16 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 22 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
       Write(Html.DisplayName("Atacante"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 24 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
           Write(Html.DropDownListFor(model => model.AtacanteId, new SelectList(@ViewBag.ListaAtacantes, "Id", "Nome"),
            "---Selecione---", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n\r\n         <div class=\"form-group\">\r\n            ");
#nullable restore
#line 29 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
       Write(Html.DisplayName("Habilidade"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 31 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
           Write(Html.DropDownListFor(model => model.HabilidadeId, new SelectList(@ViewBag.ListaHabilidades,"Id", "Nome"), 
                "---Selecione---", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 36 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
       Write(Html.DisplayName("Oponente"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 38 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
           Write(Html.DropDownListFor(model => model.OponenteId, new SelectList(@ViewBag.ListaOponentes, "Id","Nome"),
            "---Selecione---", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-6"">
                <input type=""submit"" value=""Atacar com Habilidade!!!"" class=""btn btn-primary"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 48 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>");
#nullable restore
#line 49 "D:\Etec\M2\DS\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
Write(Html.ActionLink("Retornar", "Index", "Personagens"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.DisputaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
