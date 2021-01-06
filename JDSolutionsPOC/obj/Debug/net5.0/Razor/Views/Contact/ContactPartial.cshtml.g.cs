#pragma checksum "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\Contact\ContactPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "308a0a949b00212e53f160c6eb4cc7a980beaafe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_ContactPartial), @"mvc.1.0.view", @"/Views/Contact/ContactPartial.cshtml")]
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
#line 1 "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\_ViewImports.cshtml"
using JDSolutionsPOC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\_ViewImports.cshtml"
using JDSolutionsPOC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308a0a949b00212e53f160c6eb4cc7a980beaafe", @"/Views/Contact/ContactPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df62a5065c9bcd260d9fa28b7934bb4aa68beff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_ContactPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""col-lg-4"">
    <div class=""sidebar page-sidebar"">
        <div class=""widget widget-email bg-gray"">
            <h4 class=""widget-title mb-3"">Escríbenos</h4>
            <p>Contacta a uno de nuestros expertos para una consultoria acerca de este producto.</p>
            <div class=""jd-mensajes"">
                <div id=""enviado"" style=""display:none"">
                    <span><i class=""fas fa-check-circle""></i>&nbsp; ¡Gracias por tu mensaje! En breve nos pondremos en contacto contigo.</span>
                </div>
                <div id=""error"" style=""display:none"">
                    <span><i class=""fas fa-exclamation-circle""></i>&nbsp; ¡Ups! Ocurrió un error durante el proceso. Porfavor intenta más tarde.</span>
                </div>
                <div id=""no-enviado"" style=""display:none"">
                    <span><i class=""fas fa-times-circle""></i>&nbsp; No se pudo enviar el mensaje al equipo de JD. Por favor intenta de nuevo más tarde o escribe un correo directo a <a href=");
            WriteLiteral("\"mailto:contacto@jdsolutions.com.mx\">contacto@jdsolutions.com.mx</a></span>\r\n                </div>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "308a0a949b00212e53f160c6eb4cc7a980beaafe4828", async() => {
                WriteLiteral(@"
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <input type=""text"" class=""form-control bg-white"" placeholder=""Nombre"" name=""name"">
                    </div>
                    <div class=""col-md-12"">
                        <input type=""email"" class=""form-control bg-white"" placeholder=""Correo electrónico"" name=""email"">
                    </div>
                    <div class=""col-md-12"">
                        <input type=""text"" class=""form-control bg-white"" placeholder=""Título"" name=""subject"">
                    </div>
                    <div class=""col-md-12"">
                        <textarea class=""form-control bg-white"" rows=""5"" placeholder=""Mensaje"" name=""message""></textarea>
                    </div>
                    <div class=""col-md-12"">
                        <button type=""submit"" class=""btn btn-primary"">Enviar</button>
                    </div>
                </div>
            ");
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
            WriteLiteral(@"
        </div>
        <!--<div class=""widget widget-notice bg-primary text-white"">
            <h4 class=""widget-title text-white mb-3"">Download Notice</h4>
            <p>Fusce consectetuer natoque senectus nascetur dui facilisis tincidunt pede iculus eros. Eget elit, feugiat lementum montes risus suspendisse nostra agnis justo justo Facilisi mollis ullamcorper ommodo. Per nonummy nascetur ad facilisi ipsum suscipit facilisi dictumst Mattis tincidunt commodo neque, iam ut diam, curae; felis conubia. Magnis Tellus commodo malesuada.</p>

            <a href=""#"" class=""btn btn-secondary w-100"">Download Notice Files</a>
        </div>-->
    </div>
</div>");
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