#pragma checksum "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b57e00922b1d66850c7273f2b92990bc519a0b18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\_ViewImports.cshtml"
using CasaDeShow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\_ViewImports.cshtml"
using CasaDeShow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b57e00922b1d66850c7273f2b92990bc519a0b18", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e14b4a6b6de72f110567a0b7dc451115319be6d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CasaDeShow.Models.Evento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml"
  
    Layout= "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <section id=""eventos"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12 text-center"">
                        <br>
                        <h2>Eventos</h2>
                        
                    </div>
                </div>
                <div class=""row"">
");
#nullable restore
#line 17 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml"
                     foreach(var evento in Model){
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml"
                         if(evento.Categoria.Status == true && evento.CasaShow.Status == true){
 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-4 col-sm-6 produto\">\n                                <div class=\"card\" style=\"width: 18rem; min-= \">\n                                    <img");
            BeginWriteAttribute("src", " src=", 748, "", 753, 0);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 22 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml"
                                         Write(evento.img);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"card-img-top\" style=\"height: 18rem;\" alt=\"...\">\n                                    <div class=\"card-body\">\n                                        <h5 class=\"card-title\">");
#nullable restore
#line 24 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml"
                                                          Write(evento.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                        <p class=\"card-text\">Gênero: ");
#nullable restore
#line 25 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml"
                                                                Write(evento.Categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                        <p class=\"card-text\">Casa de Show: ");
#nullable restore
#line 26 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml"
                                                                      Write(evento.CasaShow.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                        <p class=\"card-text\">Local: ");
#nullable restore
#line 27 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml"
                                                               Write(evento.CasaShow.Local);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                        \n");
#nullable restore
#line 29 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml"
                                         if(evento.QuantDeIngressos == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"btn btn-danger\"> Ingressos Esgotados!</a> \n");
#nullable restore
#line 31 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml"
                                        }else{
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b57e00922b1d66850c7273f2b92990bc519a0b187384", async() => {
                WriteLiteral("\n                                                \n                                                <button class=\"btn btn-danger\">Ilustrativo</button>\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 37 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml"
                                                
                                            
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        \n                                    </div>\n                                </div>  \n                            </div>      \n");
#nullable restore
#line 44 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\EJDH\MyProjectsCSharp\CasaDeShow\Views\Admin\Index.cshtml"
                          
                    }                     

#line default
#line hidden
#nullable disable
            WriteLiteral("       \n \n                </div>\n         </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CasaDeShow.Models.Evento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
