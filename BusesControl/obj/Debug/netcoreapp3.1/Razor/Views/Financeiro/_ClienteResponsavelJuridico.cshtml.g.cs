#pragma checksum "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Financeiro\_ClienteResponsavelJuridico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df50dac67673a8b4009f58caa8c3abb0f8a7a232"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Financeiro__ClienteResponsavelJuridico), @"mvc.1.0.view", @"/Views/Financeiro/_ClienteResponsavelJuridico.cshtml")]
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
#line 1 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\_ViewImports.cshtml"
using BusesControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\_ViewImports.cshtml"
using BusesControl.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df50dac67673a8b4009f58caa8c3abb0f8a7a232", @"/Views/Financeiro/_ClienteResponsavelJuridico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87fd3c0e3804f3f0554f6b7d07627a2d447e6cfb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Financeiro__ClienteResponsavelJuridico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PessoaJuridica>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Financeiro\_ClienteResponsavelJuridico.cshtml"
 if (Model != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"font-min\">\n        <b>Nome:</b> ");
#nullable restore
#line 4 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Financeiro\_ClienteResponsavelJuridico.cshtml"
                Write(Model.RazaoSocial);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\n        <b>CNPJ: </b> ");
#nullable restore
#line 5 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Financeiro\_ClienteResponsavelJuridico.cshtml"
                 Write(Model.ReturnCnpjCliente());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\n        <b>Inscrição estadual: </b> ");
#nullable restore
#line 6 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Financeiro\_ClienteResponsavelJuridico.cshtml"
                               Write(Model.InscricaoEstadual);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\n        <b>Inscrição municipal: </b> ");
#nullable restore
#line 7 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Financeiro\_ClienteResponsavelJuridico.cshtml"
                                Write(Model.InscricaoMunicipal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\n        <b>Telefone: </b> ");
#nullable restore
#line 8 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Financeiro\_ClienteResponsavelJuridico.cshtml"
                     Write(Model.ReturnTelefoneCliente());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\n        <b>E-mail: </b> ");
#nullable restore
#line 9 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Financeiro\_ClienteResponsavelJuridico.cshtml"
                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\n    </p>\n");
#nullable restore
#line 11 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Financeiro\_ClienteResponsavelJuridico.cshtml"

}
else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"text-align: center;\">Desculpe, ID não foi encontrado.</p>\n");
#nullable restore
#line 15 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Financeiro\_ClienteResponsavelJuridico.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PessoaJuridica> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
