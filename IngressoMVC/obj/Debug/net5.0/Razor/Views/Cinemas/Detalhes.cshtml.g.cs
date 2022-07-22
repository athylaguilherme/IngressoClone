#pragma checksum "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\Cinemas\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "891c9accdaa11cdcf7cbebfe6ce28308be770db8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cinemas_Detalhes), @"mvc.1.0.view", @"/Views/Cinemas/Detalhes.cshtml")]
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
#line 1 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\_ViewImports.cshtml"
using IngressoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\_ViewImports.cshtml"
using IngressoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"891c9accdaa11cdcf7cbebfe6ce28308be770db8", @"/Views/Cinemas/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90dadc298928da2f8002a0b94f003128977605ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Cinemas_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cinema>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n     <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 95, "\"", 115, 1);
#nullable restore
#line 5 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\Cinemas\Detalhes.cshtml"
WriteAttributeValue("", 101, Model.LogoURL, 101, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n        <h1 class=\"text-light\">");
#nullable restore
#line 8 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\Cinemas\Detalhes.cshtml"
                          Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p class=\"text-light\">");
#nullable restore
#line 9 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\Cinemas\Detalhes.cshtml"
                         Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>        \r\n    </div>\r\n\r\n</div>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\Cinemas\Detalhes.cshtml"
 if(@Model.Filmes.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div id=\"carouselExampleControls\" class=\"carousel slide col-md-4 offset-md-4\" data-ride=\"carousel\">\r\n            <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 19 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\Cinemas\Detalhes.cshtml"
                 foreach(var filme in @Model.Filmes)
                {
                    if(filme == @Model.Filmes.First())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item active\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 746, "\"", 767, 1);
#nullable restore
#line 24 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\Cinemas\Detalhes.cshtml"
WriteAttributeValue("", 752, filme.ImageURL, 752, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\">\r\n                        </div>\r\n");
#nullable restore
#line 26 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\Cinemas\Detalhes.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 982, "\"", 1003, 1);
#nullable restore
#line 30 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\Cinemas\Detalhes.cshtml"
WriteAttributeValue("", 988, filme.ImageURL, 988, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\">\r\n                        </div>\r\n");
#nullable restore
#line 32 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\Cinemas\Detalhes.cshtml"
                    }
                }            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <button class=""carousel-control-prev"" type=""button"" data-target=""#carouselExampleControls"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-target=""#carouselExampleControls"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </button>
        </div>
    </div>
");
#nullable restore
#line 45 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\Cinemas\Detalhes.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Sem filmes em Estreia para ");
#nullable restore
#line 48 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\Cinemas\Detalhes.cshtml"
                              Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "891c9accdaa11cdcf7cbebfe6ce28308be770db88502", async() => {
                WriteLiteral("\r\n        <i class=\"fa-solid fa-pen-to-square\"></i>\r\n        Editar\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\athyla.gjpires\Documents\Project\IngressoMVC\IngressoMVC\Views\Cinemas\Detalhes.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cinema> Html { get; private set; }
    }
}
#pragma warning restore 1591
