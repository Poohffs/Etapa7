#pragma checksum "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\Home\Confirmacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a964c478f0d2e8f2acd239489ba6b295a38ae77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Confirmacao), @"mvc.1.0.view", @"/Views/Home/Confirmacao.cshtml")]
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
#line 2 "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\_ViewImports.cshtml"
using etapa3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a964c478f0d2e8f2acd239489ba6b295a38ae77", @"/Views/Home/Confirmacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"238228b11cd2f1966cb3469ddba8c99aa4bd304a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirmacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\Home\Confirmacao.cshtml"
  
    ViewData["Title"] = "Confirmação";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html lang=\"PT-br\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a964c478f0d2e8f2acd239489ba6b295a38ae773438", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""shortcut icon"" href=""img/logo.png"" type=""image/x-icon"">
    <style type=""text/css"">
body{
  background-color: #1231bb4b;
}
h1{
  font-size: 5rem;
  color: black;
}
p{
  font-size: 2rem;
  color: rgb(7, 1, 1);
}

hr{
  background-color: black;
}

</style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a964c478f0d2e8f2acd239489ba6b295a38ae774873", async() => {
                WriteLiteral("\r\n<h1><center>Mensagem enviada com sucesso!</center></h1>\r\n<hr>\r\n<h2><center>Aguarde e entraremos em Contato o mais rápido possivel!</center></h2>\r\n\r\n<p>Nome: ");
#nullable restore
#line 34 "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\Home\Confirmacao.cshtml"
    Write(ViewBag.nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n<p>E-mail: ");
#nullable restore
#line 35 "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\Home\Confirmacao.cshtml"
      Write(ViewBag.email);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n<p>Mensagem: ");
#nullable restore
#line 36 "E:\melissa\Curso de TI Melissa\entregues\etapa3\Views\Home\Confirmacao.cshtml"
        Write(ViewBag.mensagem);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
