#pragma checksum "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fec501d7ba0b15f549c22806602be4f7a314d20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contrato__ListClientsSelect), @"mvc.1.0.view", @"/Views/Contrato/_ListClientsSelect.cshtml")]
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
#nullable restore
#line 1 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
using BusesControl.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fec501d7ba0b15f549c22806602be4f7a314d20", @"/Views/Contrato/_ListClientsSelect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87fd3c0e3804f3f0554f6b7d07627a2d447e6cfb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contrato__ListClientsSelect : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelsContrato>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DeleteClientSelect.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
 if (Model.ListPessoaFisicaSelect.Count == 0 && Model.ListPessoaJuridicaSelect.Count == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>Nenhum cliente selecionado!</td>\n    </tr>\n");
#nullable restore
#line 7 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
}
else {
    if (Model.ListPessoaFisicaSelect.Count > 0) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
         foreach (var item in Model.ListPessoaFisicaSelect) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 12 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
               Write(item.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><b>CPF:</b> ");
#nullable restore
#line 13 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
                           Write(item.ReturnCpfCliente());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><a style=\"padding: 0px;\" class=\"link-trash remove-ajax\"");
            BeginWriteAttribute("cliente-id", " cliente-id =\"", 538, "\"", 560, 1);
#nullable restore
#line 14 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
WriteAttributeValue("", 552, item.Id, 552, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash-alt link-trash\"></i></a></td>\n            </tr>\n");
#nullable restore
#line 16 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
         
    }
    if (Model.ListPessoaJuridicaSelect.Count > 0) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
         foreach (var item in Model.ListPessoaJuridicaSelect) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 21 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
               Write(item.RazaoSocial.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><b>CNPJ:</b> ");
#nullable restore
#line 22 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
                            Write(item.ReturnCnpjCliente());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><a style=\"padding: 0px;\" class=\"link-trash link-trash remove-ajax\"");
            BeginWriteAttribute("cliente-id", " cliente-id =\"", 984, "\"", 1006, 1);
#nullable restore
#line 23 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
WriteAttributeValue("", 998, item.Id, 998, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash-alt link-trash\"></i></a></td>\n            </tr>\n");
#nullable restore
#line 25 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Antonio\Faculdade\Sétimo período\BusesControl--TCC-master\BusesControl\Views\Contrato\_ListClientsSelect.cshtml"
         
    }
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fec501d7ba0b15f549c22806602be4f7a314d208402", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModelsContrato> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
