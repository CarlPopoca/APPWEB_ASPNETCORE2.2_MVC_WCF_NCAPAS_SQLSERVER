#pragma checksum "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c41d41cf22b63916911ec6694471648d89195f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Delete), @"mvc.1.0.view", @"/Views/Usuarios/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Delete.cshtml", typeof(AspNetCore.Views_Usuarios_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c41d41cf22b63916911ec6694471648d89195f4", @"/Views/Usuarios/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f6ef9c5add77130885f4d6ae06eea0da40c13ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEBASPNETCORE2.Models.UsuariosViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Delete.cshtml"
  
    ViewBag.Title = "Eliminar";

#line default
#line hidden
            BeginContext(90, 154, true);
            WriteLiteral("\r\n<h2>Eliminar</h2>\r\n<h4>Usuarios</h4>\r\n<h3>Esta seguro de que quiere eliminarlo?</h3>\r\n<div>\r\n\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n    </dl>\r\n\r\n");
            EndContext();
#line 16 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(291, 23, false);
#line 18 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(325, 36, false);
#line 19 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Delete.cshtml"
   Write(Html.HiddenFor(model => model.UsuId));

#line default
#line hidden
            EndContext();
            BeginContext(363, 70, true);
            WriteLiteral("        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(434, 41, false);
#line 22 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.UsuId));

#line default
#line hidden
            EndContext();
            BeginContext(475, 57, true);
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(533, 37, false);
#line 26 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Delete.cshtml"
           Write(Html.DisplayFor(model => model.UsuId));

#line default
#line hidden
            EndContext();
            BeginContext(570, 57, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(628, 45, false);
#line 30 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.UsuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(673, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(729, 41, false);
#line 33 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Delete.cshtml"
           Write(Html.DisplayFor(model => model.UsuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(770, 36, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n");
            EndContext();
            BeginContext(810, 137, true);
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-default\" /> |\r\n            ");
            EndContext();
            BeginContext(948, 36, false);
#line 40 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Delete.cshtml"
       Write(Html.ActionLink("Regresar", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(984, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 42 "C:\PROYECTOS\VisualStudioNET\APPWEBMVCCORE_2.2_WCF_CAPAS\WEBASPNETCORE2\Views\Usuarios\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(1009, 8, true);
            WriteLiteral("</div>\r\n");
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