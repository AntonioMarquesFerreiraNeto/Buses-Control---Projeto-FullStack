#pragma checksum "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\HomeAcessoNegado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f01a6a9c88510ef0d77b3fee3af92b70b458b95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeAcessoNegado_Index), @"mvc.1.0.view", @"/Views/HomeAcessoNegado/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f01a6a9c88510ef0d77b3fee3af92b70b458b95", @"/Views/HomeAcessoNegado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87fd3c0e3804f3f0554f6b7d07627a2d447e6cfb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HomeAcessoNegado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Funcionario>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary ms-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoClienteJuridico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contrato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoContrato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\HomeAcessoNegado\Index.cshtml"
 if (TempData["MensagemDeSucesso"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\n        ");
#nullable restore
#line 4 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\HomeAcessoNegado\Index.cshtml"
   Write(TempData["MensagemDeSucesso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <button type=\"button\" class=\"btn btn-danger btn-sm close-alert sucesso\" aria-label=\"Close\"> <i class=\"fa fa-xmark\"></i> </button>\n    </div>\n");
#nullable restore
#line 7 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\HomeAcessoNegado\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\HomeAcessoNegado\Index.cshtml"
 if (TempData["MensagemDeErro"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\" style=\"margin-bottom: 3px;\">\n        ");
#nullable restore
#line 10 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\HomeAcessoNegado\Index.cshtml"
   Write(TempData["MensagemDeErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <button type=\"button\" class=\"btn btn-danger btn-sm close-alert erro\" aria-label=\"Close\"> <i class=\"fa fa-xmark\"></i> </button>\n    </div>\n");
#nullable restore
#line 13 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\HomeAcessoNegado\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"css/home.css\">\n<section class=\"principais\">\n    <h3 id=\"titlePrincipal\">\n        <i class=\"fa fa-home\"></i> ");
#nullable restore
#line 17 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\HomeAcessoNegado\Index.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <hr style=""margin-top: 3px;"">
    </h3>
    <div class=""row"">
        <div class=""col-sm-6"">
            <div class=""card"">
                <div class=""card-body"">
                    <h3 class=""card-title"">
                        Descrição sobre os clientes
                    </h3>
                    <p class=""card-text"">
                        O cliente não se encontra cadastrado? Não perca tempo, realize o registro dele agora mesmo!
                        Sabemos da importância de ter clientes registrados na aplicação,
                        pensando neste quesito, permitimos que você cadastre seus clientes, que será essencial
                        em ações futuras.
                    </p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f01a6a9c88510ef0d77b3fee3af92b70b458b958239", async() => {
                WriteLiteral("+ Cliente físico");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f01a6a9c88510ef0d77b3fee3af92b70b458b959711", async() => {
                WriteLiteral("+ Cliente jurídico");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <br>
                </div>
            </div>
        </div>
        <div class=""col-sm-6"">
            <div class=""card"">
                <div class=""card-body"">
                    <h3 class=""card-title"">
                        Descrição sobre os contratos
                    </h3>
                    <p class=""card-text"">
                        O cliente já se encontra cadastrado? Não perca tempo, realize contrato dele agora mesmo!
                        Um dos nossos principais objetivos é auxiliar no processo de formalização de alocações,
                        e o primeiro passo é o registro do contrato. Após o registro do contrato, ele será enviado para ""aprovar contrato"".
                    </p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f01a6a9c88510ef0d77b3fee3af92b70b458b9511936", async() => {
                WriteLiteral("+ Contrato");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-sm-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <h3 class=""card-title"">
                        Descrição sobre o suporte ao sistema &copy; Buses Control
                    </h3>
                    <p class=""card-text"">
                        Qualquer problema encontrado no sistema ou sugestão de melhorias, entre em contato com a equipe de suporte do sistema. Nos quais, os canais de comunicação será informado logo abaixo.
                        Mas não esqueça de comunicar seu superior sobre o conflito ou problema.
                        <br>
                        <br>
                        <b>E-mail:</b> busescontrolmensagem@outlook.com,
                        <br>
                        <b>Celular: </b>+55 (62)98573-0236.
                    </p>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Funcionario> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
