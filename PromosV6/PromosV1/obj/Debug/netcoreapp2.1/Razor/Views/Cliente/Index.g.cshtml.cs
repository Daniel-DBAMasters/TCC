#pragma checksum "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "945f01e7937885dfbc690fb1eaa90ef7ec40da08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Index.cshtml", typeof(AspNetCore.Views_Cliente_Index))]
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
#line 1 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\_ViewImports.cshtml"
using PromosV1;

#line default
#line hidden
#line 2 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\_ViewImports.cshtml"
using PromosV1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"945f01e7937885dfbc690fb1eaa90ef7ec40da08", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e97f336ad9d370ca4a78991c1068d0bdcb29e6d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClienteViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(72, 678, true);
            WriteLiteral(@"
<br />
<h2 style=""color:black;"">Lista de Clientes</h2>



<br /> <br />

       <div style=""overflow-x:auto;"">

           <a href=""/cliente/create"" class=""glyphicon glyphicon-plus"">Adicionar</a>

           <a href="""" class=""glyphicon glyphicon-plus"">Adicionar Carimbos</a>


           <table class=""table table-bordered"">
               <tr>


                   <th scope=""col"">CPF</th>
                   <th scope=""col"">Nome</th>
                   <th scope=""col"">E-mail</th>
                   <th scope=""col"">Telefone</th>
                   <th scope=""col"">Cidade</th>
                   <th scope=""col"">Estado</th>

               </tr>

");
            EndContext();
#line 33 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\Cliente\Index.cshtml"
                foreach (var cliente in Model)
               {



#line default
#line hidden
            BeginContext(820, 21, true);
            WriteLiteral("                   <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 841, "\"", 875, 2);
            WriteAttributeValue("", 848, "cliente/Edit?id=", 848, 16, true);
#line 37 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 864, cliente.Id, 864, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(876, 63, true);
            WriteLiteral(" class=\"glyphicon glyphicon-pencil\"></a>\r\n                   <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 939, "\"", 983, 3);
            WriteAttributeValue("", 946, "javascript:apagarcliente(", 946, 25, true);
#line 38 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 971, cliente.Id, 971, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 982, ")", 982, 1, true);
            EndWriteAttribute();
            BeginContext(984, 42, true);
            WriteLiteral(" class=\"glyphicon glyphicon-trash\"></a> \r\n");
            EndContext();
            BeginContext(1028, 52, true);
            WriteLiteral("                   <tr>\r\n                       <td>");
            EndContext();
            BeginContext(1081, 11, false);
#line 41 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\Cliente\Index.cshtml"
                      Write(cliente.Cpf);

#line default
#line hidden
            EndContext();
            BeginContext(1092, 34, true);
            WriteLiteral("</td>\r\n                       <td>");
            EndContext();
            BeginContext(1127, 12, false);
#line 42 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\Cliente\Index.cshtml"
                      Write(cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1139, 34, true);
            WriteLiteral("</td>\r\n                       <td>");
            EndContext();
            BeginContext(1174, 13, false);
#line 43 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\Cliente\Index.cshtml"
                      Write(cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1187, 34, true);
            WriteLiteral("</td>\r\n                       <td>");
            EndContext();
            BeginContext(1222, 16, false);
#line 44 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\Cliente\Index.cshtml"
                      Write(cliente.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(1238, 34, true);
            WriteLiteral("</td>\r\n                       <td>");
            EndContext();
            BeginContext(1273, 14, false);
#line 45 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\Cliente\Index.cshtml"
                      Write(cliente.Cidade);

#line default
#line hidden
            EndContext();
            BeginContext(1287, 34, true);
            WriteLiteral("</td>\r\n                       <td>");
            EndContext();
            BeginContext(1322, 14, false);
#line 46 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\Cliente\Index.cshtml"
                      Write(cliente.Estado);

#line default
#line hidden
            EndContext();
            BeginContext(1336, 74, true);
            WriteLiteral("</td>\r\n                       \r\n                       <td class=\"hidden\">");
            EndContext();
            BeginContext(1411, 13, false);
#line 48 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\Cliente\Index.cshtml"
                                     Write(cliente.Senha);

#line default
#line hidden
            EndContext();
            BeginContext(1424, 63, true);
            WriteLiteral("</td>\r\n                   </tr>\r\n                   <tr></tr>\r\n");
            EndContext();
#line 51 "C:\Users\Denilson\Desktop\Promos V1\PromosV6\PromosV1\Views\Cliente\Index.cshtml"
               }

#line default
#line hidden
            BeginContext(1505, 216, true);
            WriteLiteral("           </table>\r\n\r\n       </div>\r\n<script>\r\n    function apagarcliente(id) {\r\n        if (confirm(\'Confirma a exclusão do registro?\'))\r\n            location.href = \'cliente/Delete?id=\' + id;\r\n    }\r\n</script>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClienteViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
