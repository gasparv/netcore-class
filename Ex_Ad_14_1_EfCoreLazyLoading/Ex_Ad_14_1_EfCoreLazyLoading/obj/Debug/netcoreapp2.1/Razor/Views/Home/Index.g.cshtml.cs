#pragma checksum "C:\Users\Gaspar\Documents\Visual Studio 2017\Projects\Ex_Ad_14_1_EfCoreLazyLoading\Ex_Ad_14_1_EfCoreLazyLoading\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc4d13e4e622202c392e106609262e5d739c7fa1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Gaspar\Documents\Visual Studio 2017\Projects\Ex_Ad_14_1_EfCoreLazyLoading\Ex_Ad_14_1_EfCoreLazyLoading\Views\_ViewImports.cshtml"
using Ex_Ad_14_1_EfCoreLazyLoading;

#line default
#line hidden
#line 2 "C:\Users\Gaspar\Documents\Visual Studio 2017\Projects\Ex_Ad_14_1_EfCoreLazyLoading\Ex_Ad_14_1_EfCoreLazyLoading\Views\_ViewImports.cshtml"
using Ex_Ad_14_1_EfCoreLazyLoading.Models;

#line default
#line hidden
#line 3 "C:\Users\Gaspar\Documents\Visual Studio 2017\Projects\Ex_Ad_14_1_EfCoreLazyLoading\Ex_Ad_14_1_EfCoreLazyLoading\Views\_ViewImports.cshtml"
using Ex_Ad_14_1_EfCoreLazyLoading.Models.DbModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc4d13e4e622202c392e106609262e5d739c7fa1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abce3c09ad7d30c4161af8c47d24f5eb3093e51d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Coffee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 14, true);
            WriteLiteral("<br /><br />\r\n");
            EndContext();
#line 3 "C:\Users\Gaspar\Documents\Visual Studio 2017\Projects\Ex_Ad_14_1_EfCoreLazyLoading\Ex_Ad_14_1_EfCoreLazyLoading\Views\Home\Index.cshtml"
 foreach (Coffee coffee in Model)
{

#line default
#line hidden
            BeginContext(80, 9, true);
            WriteLiteral("    <div>");
            EndContext();
            BeginContext(91, 39, false);
#line 5 "C:\Users\Gaspar\Documents\Visual Studio 2017\Projects\Ex_Ad_14_1_EfCoreLazyLoading\Ex_Ad_14_1_EfCoreLazyLoading\Views\Home\Index.cshtml"
     Write(coffee.Name + " from " + coffee.Origin );

#line default
#line hidden
            EndContext();
            BeginContext(131, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 6 "C:\Users\Gaspar\Documents\Visual Studio 2017\Projects\Ex_Ad_14_1_EfCoreLazyLoading\Ex_Ad_14_1_EfCoreLazyLoading\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Coffee>> Html { get; private set; }
    }
}
#pragma warning restore 1591