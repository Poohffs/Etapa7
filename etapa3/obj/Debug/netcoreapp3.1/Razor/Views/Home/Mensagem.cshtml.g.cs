#pragma checksum "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\Home\Mensagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9212dfb953ca5184e900e4acfa8f137fcfa0c44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Mensagem), @"mvc.1.0.view", @"/Views/Home/Mensagem.cshtml")]
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
#line 1 "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\_ViewImports.cshtml"
using etapa3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\Home\Mensagem.cshtml"
using etapa3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9212dfb953ca5184e900e4acfa8f137fcfa0c44", @"/Views/Home/Mensagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"238228b11cd2f1966cb3469ddba8c99aa4bd304a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Mensagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contato>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\Home\Mensagem.cshtml"
  
    ViewData["Title"] = "Mensagem";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""css/Mensagem.css""/>

<h2>Descrição da Mensagem</h2>

<table border=""1"">
    <thead>
        <tr>
            <th>Nome</th>
            <th>E-mail</th>
            <th>Mensagem</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 21 "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\Home\Mensagem.cshtml"
         foreach (Contato item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\Home\Mensagem.cshtml"
               Write(item.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\Home\Mensagem.cshtml"
               Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\Home\Mensagem.cshtml"
               Write(item.mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\Home\Mensagem.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contato>> Html { get; private set; }
    }
}
#pragma warning restore 1591