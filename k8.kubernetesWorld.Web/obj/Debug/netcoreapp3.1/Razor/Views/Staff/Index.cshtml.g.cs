#pragma checksum "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\Staff\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f8f3573f30c653fe55c3e47f576506231e66352"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Index), @"mvc.1.0.view", @"/Views/Staff/Index.cshtml")]
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
#line 1 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\_ViewImports.cshtml"
using k8.kubernetesWorld.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\_ViewImports.cshtml"
using k8.kubernetesWorld.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f8f3573f30c653fe55c3e47f576506231e66352", @"/Views/Staff/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e5979eca52fd989cd0fae3025238028054b0ac8", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<k8.kubernetesWorld.Web.Staff>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\Staff\Index.cshtml"
  
    ViewData["Title"] = "Staff";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>Staff View (Core APi)</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\Staff\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\Staff\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\Staff\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\Staff\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\Staff\Index.cshtml"
           Write(Html.DisplayNameFor(model => model._message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\Staff\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\Staff\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\Staff\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\Staff\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\Staff\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 54 "C:\_dev\_github\Azure-Container-App\k8.kubernetesWorld.Web\Views\Staff\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<k8.kubernetesWorld.Web.Staff>> Html { get; private set; }
    }
}
#pragma warning restore 1591
