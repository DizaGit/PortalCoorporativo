#pragma checksum "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\AboutUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68f64b533397c25571dd44b6107182881f40c7a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AboutUs_Index), @"mvc.1.0.view", @"/Views/AboutUs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f64b533397c25571dd44b6107182881f40c7a1", @"/Views/AboutUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df62a5065c9bcd260d9fa28b7934bb4aa68beff1", @"/Views/_ViewImports.cshtml")]
    public class Views_AboutUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\AboutUs\Index.cshtml"
  
    Layout = "_Layout2";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-banner-image"" style=""background-image: url(images/banners/b_nosotros.jpg); background-position: center center;"">
    <div class=""container"">
        <div class=""row"" style=""padding: 120px 0"">
            <div class=""col-lg-12"">
                <h1 class=""text-white down-line-white"">Acerca de JD Solutions</h1>
                <span class=""text-white mt-4 sub-title w-50 w-sm-100"">Somos una empresa mexicana creada por un equipo de profesionales con 8 años de experiencia en el desarrollo de software. Desarrollamos aplicaciones web y sistemas; ofrecemos consultoría informática a la medida de cada uno de nuestros proyectos. </span>
            </div>
        </div>
    </div>
</div>


<!-- breadcrumb -->
<div class=""full-row py-3"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <nav aria-label=""breadcrumb"" class=""float-left"">
                    <ol class=""breadcrumb mb-0 bg-transparent p-0"">
                        <li");
            WriteLiteral(" class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f64b533397c25571dd44b6107182881f40c7a15622", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Nosotros</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</div>
<!-- breadcrumb -->

<div class=""full-row"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h2 class=""text-center down-line mb-20"">EL OBJETIVO DE TODO</h2>
                <span class=""text-general text-center mt-4 w-sm-100 mb-5 sub-title"">Eficientar los procesos de nuestros clientes desarrollando herramientas digitales y estrategias enfocadas 100% en el usuario. Colaborar para que todos los proyectos en los que trabajemos alcancen sus metas de rendimiento y rentabilidad mediante acompañamiento continuo: desde la planeación y el lanzamiento, hasta la operación cotidiana.</span>
            </div>
        </div>
        <!--<div class=""row"">
            <div class=""col-lg-6"">
                <h5>Metodología Ágil</h5>
                <p");
            WriteLiteral(@">Implementamos una metodología ágil de desarrollo de software basada en módulos funcionales para que nuestras soluciones sean escalables y adaptables al futuro. Esta forma de trabajo garantiza dos aspectos importantes: la satisfacción de nuestros clientes y la creación de un producto de calidad que aporta valor a cada negocio.</p>
            </div>
            <div class=""col-lg-6"">
                <p>La metodología Agile se usa para proyectos largos o en los cuales no se tienen metas finales definidas. A través del proceso de desarrollo y gracias a la flexibilidad de la metodología, los objetivos se van aclarando y los cambios pueden adaptarse de manera sencilla en las partes iniciales del proyecto.</p>
            </div>
        </div>-->
    </div>
</div>

<div class=""row"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7 mb-5"">
                <h2 class=""down-line"">LA METODOLOGÍA DE JD</h2>
                <span class=""mt-4 mb-30 sub-title"">Implementamo");
            WriteLiteral(@"s una metodología ágil de desarrollo de software basada en módulos funcionales para que nuestras soluciones sean escalables y adaptables al futuro. Esta forma de trabajo garantiza dos aspectos importantes: la satisfacción de nuestros clientes y la creación de un producto de calidad que aporta valor a cada negocio.</span>
                <h5 class=""mt-4"">Metodología ágil (Agile)</h5>
                <span class=""mt-4 mb-30 sub-title"">El proceso de desarrollo de software Agile es una metodología adaptativa y repetitiva basada en una aproximación por fragmentos. Nos permite hacer cambios en requerimientos, acompañada de retroalimentación y comunicación constantes con el cliente con el fin de evitar errores cuanto antes.</span>
                <p><b class=""text-primary"">Nuestro equipo multifuncional labora en un fragmento del producto sobre un periodo específico (un sprint). Organizan, rastrean y coordinan su trabajo con herramientas como JIRA y se comunican de manera continua con el cliente.</b></p>
        ");
            WriteLiteral(@"        <p>La metodología Agile se usa para proyectos largos o en los cuales no se tienen metas finales definidas. A través del proceso de desarrollo y gracias a la flexibilidad de la metodología, los objetivos se van aclarando y los cambios pueden adaptarse de manera sencilla en las partes iniciales del proyecto.</p>
                <!--<ul class=""list-half-width list-bullate"">
                    <li>Master key systems</li>
                    <li>High security cylinders</li>
                    <li>Changing and rekeying locks</li>
                    <li>Keyless entry systems</li>
                    <li>Fast lock out service</li>
                    <li>Installation and repair of locks</li>
                    <li>Window locks</li>
                    <li>Deadlocks & Padlocks</li>
                </ul>-->
            </div>
            <div class=""col-lg-5"">
                <img src=""images/nosotros/n_equipo.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5149, "\"", 5155, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
        </div>
    </div>
</div>
<div class=""full-row pt-0"">
    <div class=""container"">
        <div class=""row pt-5 border-top border-bottom"">
            <div class=""col-12 mb-4"">
                <h5 class=""down-line"">Ventajas de usar metodologías ágiles</h5>
            </div>
            <div class=""col-lg-4 wow fadeIn"" data-wow-delay=""100ms"" data-wow-duration=""1000ms"">
                <div class=""simple-thumb mb-30"">
                    <span class=""h4 mb-2 text-primary"">01</span>
                    <p>Las partes del producto de software se entregan en etapas tempranas del proyecto para recibir comentarios del cliente.</p>
                </div>
            </div>
            <div class=""col-lg-4 wow fadeIn"" data-wow-delay=""300ms"" data-wow-duration=""1000ms"">
                <div class=""simple-thumb mb-30"">
                    <span class=""h4 mb-2 text-primary"">02</span>
                    <p>Los cambios y correcciones son más sencillos de adaptar, incluso cuand");
            WriteLiteral(@"o estamos en las etapas finales del proyecto.</p>
                </div>
            </div>
            <div class=""col-lg-4 wow fadeIn"" data-wow-delay=""500ms"" data-wow-duration=""1000ms"">
                <div class=""simple-thumb mb-30"">
                    <span class=""h4 mb-2 text-primary"">03</span>
                    <p>Las tareas se mantienen actualizadas. Se desperdician menos recursos y se logran tiempos de respuesta más rápidos.</p>
                </div>
            </div>
            <div class=""col-lg-4 wow fadeIn"" data-wow-delay=""500ms"" data-wow-duration=""1000ms"">
                <div class=""simple-thumb mb-30"">
                    <span class=""h4 mb-2 text-primary"">04</span>
                    <p>Los errores y defectos se detectan de manera rápida y son más sencillos de reparar en etapas tempranas del proyecto.</p>
                </div>
            </div>
            <div class=""col-lg-4 wow fadeIn"" data-wow-delay=""500ms"" data-wow-duration=""1000ms"">
                <div class=""si");
            WriteLiteral(@"mple-thumb mb-30"">
                    <span class=""h4 mb-2 text-primary"">05</span>
                    <p>Con la retroalimentación del área de Quality Assurance, los desarrolladores mejoran sus habilidades para codificar.</p>
                </div>
            </div>
            <div class=""col-lg-4 wow fadeIn"" data-wow-delay=""500ms"" data-wow-duration=""1000ms"">
                <div class=""simple-thumb mb-30"">
                    <span class=""h4 mb-2 text-primary"">06</span>
                    <p>Se puede enfocar mejor la atención en la excelencia técnica y en el buen diseño durante el desarrollo del proyecto.</p>
                </div>
            </div>
            <div class=""col-lg-4 wow fadeIn"" data-wow-delay=""500ms"" data-wow-duration=""1000ms"">
                <div class=""simple-thumb mb-30"">
                    <span class=""h4 mb-2 text-primary"">07</span>
                    <p>Tanto clientes como líderes de proyecto, desarrolladores y probadores están en comunicación constante entre ellos");
            WriteLiteral(@".</p>
                </div>
            </div>
            <div class=""col-lg-4 wow fadeIn"" data-wow-delay=""500ms"" data-wow-duration=""1000ms"">
                <div class=""simple-thumb mb-30"">
                    <span class=""h4 mb-2 text-primary"">08</span>
                    <p>Su flexibilidad permite al equipo de desarrollo adaptar el flujo de acuerdo a las necesidades del proyecto.</p>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Our Partner Section Start -->
<div class=""full-row jd-paddingt-40"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 mb-5"">
                <h2 class=""main-title down-line w-50 m-auto text-center w-sm-100"">Algunos de nuestros casos de éxito a lo largo de 8 años</h2>
            </div>
            <div class=""col-md-12"">
                <div class=""owl-carousel partner-slider"">
                    <div class=""item bg-white""><img src=""images/clientes/logo01.jpg"" alt=""Image not found!"" /><");
            WriteLiteral(@"/div>
                    <div class=""item bg-white""><img src=""images/clientes/logo02.jpg"" alt=""Image not found!"" /></div>
                    <div class=""item bg-white""><img src=""images/clientes/logo03.jpg"" alt=""Image not found!"" /></div>
                    <div class=""item bg-white""><img src=""images/clientes/logo04.jpg"" alt=""Image not found!"" /></div>
                    <div class=""item bg-white""><img src=""images/clientes/logo05.jpg"" alt=""Image not found!"" /></div>
                </div>
            </div>
            <div class=""col-md-12"">
                <div class=""owl-carousel partner-slider"">
                    <div class=""item bg-white""><img src=""images/clientes/logo07.jpg"" alt=""Image not found!"" /></div>
                    <div class=""item bg-white""><img src=""images/clientes/logo08.jpg"" alt=""Image not found!"" /></div>
                    <div class=""item bg-white""><img src=""images/clientes/logo09.jpg"" alt=""Image not found!"" /></div>
                    <div class=""item bg-white""><img");
            WriteLiteral(@" src=""images/clientes/logo10.jpg"" alt=""Image not found!"" /></div>
                    <div class=""item bg-white""><img src=""images/clientes/logo12.jpg"" alt=""Image not found!"" /></div>
                </div>
            </div>
            <div class=""col-md-12"">
                <div class=""owl-carousel partner-slider"">
                    <div class=""item bg-white""><img src=""images/clientes/logo14.jpg"" alt=""Image not found!"" /></div>
                    <div class=""item bg-white""><img src=""images/clientes/logo16.jpg"" alt=""Image not found!"" /></div>
                    <div class=""item bg-white""><img src=""images/clientes/logo17.jpg"" alt=""Image not found!"" /></div>
                    <div class=""item bg-white""><img src=""images/clientes/logo18.jpg"" alt=""Image not found!"" /></div>
                    <div class=""item bg-white""><img src=""images/clientes/logo06.jpg"" alt=""Image not found!"" /></div>

                </div>
            </div>
        </div>
    </div>
</div>
<!-- Our Partner Section En");
            WriteLiteral(@"d -->
<!-- Banner de contacto START -->
<div class=""full-row bg-primary py-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7 col-md-12 wow fadeIn"" data-wow-delay=""100ms"" data-wow-duration=""1000ms"">
                <h4 class=""text-white mb-2"">Queremos ayudarte a alcanzar tus objetivos</h4>
                <p class=""text-white"">Concreta una cita con nuestros expertos para tener atención personalizada.</p>
            </div>
            <div class=""col-lg-5 col-md-12 wow fadeIn"" data-wow-delay=""200ms"" data-wow-duration=""1000ms"">
                <div class=""y-center position-relative d-table ml-auto sm-margin-none text-white"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f64b533397c25571dd44b6107182881f40c7a118517", async() => {
                WriteLiteral("Contáctanos &nbsp;<i class=\"fas fa-long-arrow-alt-right text-white\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Banner de contacto END -->\r\n");
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
