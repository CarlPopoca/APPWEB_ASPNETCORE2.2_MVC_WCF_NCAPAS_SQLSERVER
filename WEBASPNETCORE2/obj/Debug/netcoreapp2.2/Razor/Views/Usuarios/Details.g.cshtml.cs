#pragma checksum "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b8fae752d31d9d5a8f2ab84710e94596fadb5b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Details), @"mvc.1.0.view", @"/Views/Usuarios/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Details.cshtml", typeof(AspNetCore.Views_Usuarios_Details))]
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
#line 1 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\_ViewImports.cshtml"
using WEBASPNETCORE2;

#line default
#line hidden
#line 2 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\_ViewImports.cshtml"
using WEBASPNETCORE2.Models;

#line default
#line hidden
#line 3 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b8fae752d31d9d5a8f2ab84710e94596fadb5b8", @"/Views/Usuarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f6ef9c5add77130885f4d6ae06eea0da40c13ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEBASPNETCORE2.Models.UsuariosViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Details.cshtml"
  
    ViewBag.Title = "Detalles";

#line default
#line hidden
            BeginContext(90, 164, true);
            WriteLiteral("\r\n<h2>Detalles</h2>\r\n\r\n<div>\r\n    <h4>Usuarios</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n    </dl>\r\n</div>\r\n\r\n<dl class=\"dl-horizontal\">\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(255, 41, false);
#line 18 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.UsuId));

#line default
#line hidden
            EndContext();
            BeginContext(296, 33, true);
            WriteLiteral("\r\n    </dt>\r\n\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(330, 37, false);
#line 22 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Details.cshtml"
   Write(Html.DisplayFor(model => model.UsuId));

#line default
#line hidden
            EndContext();
            BeginContext(367, 33, true);
            WriteLiteral("\r\n    </dd>\r\n\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(401, 45, false);
#line 26 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.UsuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(446, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(478, 41, false);
#line 29 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Details.cshtml"
   Write(Html.DisplayFor(model => model.UsuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(519, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(551, 47, false);
#line 32 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.UsuPassword));

#line default
#line hidden
            EndContext();
            BeginContext(598, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(630, 43, false);
#line 35 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Details.cshtml"
   Write(Html.DisplayFor(model => model.UsuPassword));

#line default
#line hidden
            EndContext();
            BeginContext(673, 29, true);
            WriteLiteral("\r\n    </dd>\r\n</dl>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(703, 59, false);
#line 39 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Details.cshtml"
Write(Html.ActionLink("Editar", "Edit", new { id = Model.UsuId }));

#line default
#line hidden
            EndContext();
            BeginContext(762, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(771, 36, false);
#line 40 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Details.cshtml"
Write(Html.ActionLink("Regresar", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(807, 8, true);
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEBASPNETCORE2.Models.UsuariosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591