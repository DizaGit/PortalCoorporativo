#pragma checksum "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\Services\GroupBy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7ed89f26da5290ed9347aabb4439e3a3d5da881"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_GroupBy), @"mvc.1.0.view", @"/Views/Services/GroupBy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7ed89f26da5290ed9347aabb4439e3a3d5da881", @"/Views/Services/GroupBy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df62a5065c9bcd260d9fa28b7934bb4aa68beff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_GroupBy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JDSolutionsPOC.Models.Service>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-link my-2 d-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\Services\GroupBy.cshtml"
  
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            $('#slider').layerSlider({
                sliderVersion: '6.0.0',
                type: 'fullwidth',
                responsiveUnder: 0,
                layersContainer: 1200,
                maxRatio: 1,
                parallaxScrollReverse: true,
                hideUnder: 0,
                hideOver: 100000,
                skin: 'v5',
                showBarTimer: false,
                thumbnailNavigation: 'disabled',
                allowRestartOnResize: true,
                skinsPath: 'assets/skins/',
                height: 940
            });

        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n<!--Banner servicios  -->\r\n<div class=\"full-row page-banner-image\"");
            BeginWriteAttribute("style", " style=\"", 875, "\"", 1013, 9);
            WriteAttributeValue("", 883, "background-image:", 883, 17, true);
            WriteAttributeValue(" ", 900, "url(", 901, 5, true);
#nullable restore
#line 32 "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\Services\GroupBy.cshtml"
WriteAttributeValue("", 905, Url.Content("~/images/banners/b_abstract.jpg"), 905, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 952, ");", 952, 2, true);
            WriteAttributeValue(" ", 954, "background-position:", 955, 21, true);
            WriteAttributeValue(" ", 975, "center", 976, 7, true);
            WriteAttributeValue(" ", 982, "center;", 983, 8, true);
            WriteAttributeValue(" ", 990, "background-size:", 991, 17, true);
            WriteAttributeValue(" ", 1007, "cover", 1008, 6, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""container"">
        <div class=""row mt-4"">
            <div class=""col-lg-12 mt-5"">
                <span class=""text-white text-center mt-4 sub-title jd-sub-title jd-w-70 w-sm-100 mx-auto"">Empatizamos con nuestros clientes para entender sus objetivos y actuamos en conjunto  para obtener el mejor producto.</span>
            </div>
        </div>
    </div>
</div>

<!-- breadcrumb -->
<div class=""full-row breadcrumb-bar bg-gray py-3"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6"">
                <h3>Servicios</h3>
            </div>
            <div class=""col-lg-6 col-md-6"">
                <nav aria-label=""breadcrumb"" class=""float-right"">
                    <ol class=""breadcrumb mb-0 bg-transparent p-0"">
                        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7ed89f26da5290ed9347aabb4439e3a3d5da8818290", async() => {
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
            WriteLiteral("</li>\r\n                        <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7ed89f26da5290ed9347aabb4439e3a3d5da8819708", async() => {
                WriteLiteral("Servicios");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 54 "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\Services\GroupBy.cshtml"
                                                                          Write(Model.First().group);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
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
            <div class=""col-lg-12 mb-5"">
                <h2 class=""main-title down-line w-50 m-auto text-center w-sm-100"">¿Qué ofrecemos?</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""w-75 text-center mx-auto d-block w-sm-100"">
                    <p>Somos expertos capaces de desarrollar el software y las soluciones que tus proyectos necesitan para alcanzar tus objetivos. </p>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-12"">
");
#nullable restore
#line 80 "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\Services\GroupBy.cshtml"
                 foreach (Service service in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"feature-thumb-border hover-text-white bg-light transation w-50 w-sm-100 d-flex float-left p-4\">\r\n                        <span class=\"float-left d-table mt-2\"><i");
            BeginWriteAttribute("class", " class=\"", 3231, "\"", 3277, 3);
#nullable restore
#line 83 "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\Services\GroupBy.cshtml"
WriteAttributeValue("", 3239, service.icon, 3239, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3252, "flat-medium", 3253, 12, true);
            WriteAttributeValue(" ", 3264, "text-primary", 3265, 13, true);
            EndWriteAttribute();
            WriteLiteral("></i></span>\r\n                        <div class=\"pl-3\">\r\n                            <span class=\"text-primary d-table tagline\">");
#nullable restore
#line 85 "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\Services\GroupBy.cshtml"
                                                                  Write(service.group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <h5 class=\"text-dark mb-3 text-uppercase\">");
#nullable restore
#line 86 "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\Services\GroupBy.cshtml"
                                                                 Write(service.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>");
#nullable restore
#line 87 "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\Services\GroupBy.cshtml"
                          Write(service.preview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7ed89f26da5290ed9347aabb4439e3a3d5da88114357", async() => {
                WriteLiteral("Conoce más");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-serviceId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\Services\GroupBy.cshtml"
                                                                                         WriteLiteral(service.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-serviceId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 91 "C:\Proyectos\PortalCoorporativo\JDSolutionsPOC\Views\Services\GroupBy.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<div class=""full-row bg-primary py-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7 col-md-12 wow fadeIn"" data-wow-delay=""100ms"" data-wow-duration=""1000ms"">
                <h4 class=""text-white mb-2"">Queremos ayudarte a alcanzar tus objetivos</h4>
                <p class=""text-white"">If you interested in out theme don't wait to purchase or call us</p>
            </div>
            <div class=""col-lg-5 col-md-12 wow fadeIn"" data-wow-delay=""200ms"" data-wow-duration=""1000ms"">
                <div class=""y-center position-relative d-table ml-auto sm-margin-none text-white"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7ed89f26da5290ed9347aabb4439e3a3d5da88117864", async() => {
                WriteLiteral("Contacta a nuestros expertos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JDSolutionsPOC.Models.Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
