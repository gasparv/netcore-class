#pragma checksum "E:\SKOLENIE .NET TEMP\Ex_14_EfCore_CodeFirst\Ex_14_EfCore_CodeFirst\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb8142dc0ffe5529536bc2369a447e236bf0459a"
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
#line 1 "E:\SKOLENIE .NET TEMP\Ex_14_EfCore_CodeFirst\Ex_14_EfCore_CodeFirst\Views\_ViewImports.cshtml"
using Ex_14_EfCore_CodeFirst.Models.DbModels;

#line default
#line hidden
#line 2 "E:\SKOLENIE .NET TEMP\Ex_14_EfCore_CodeFirst\Ex_14_EfCore_CodeFirst\Views\_ViewImports.cshtml"
using Ex_14_EfCore_CodeFirst;

#line default
#line hidden
#line 3 "E:\SKOLENIE .NET TEMP\Ex_14_EfCore_CodeFirst\Ex_14_EfCore_CodeFirst\Views\_ViewImports.cshtml"
using Ex_14_EfCore_CodeFirst.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8142dc0ffe5529536bc2369a447e236bf0459a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ebee94bff7b52c9b30b66663f5bbc5ebb9b13ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Coffee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\SKOLENIE .NET TEMP\Ex_14_EfCore_CodeFirst\Ex_14_EfCore_CodeFirst\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(75, 9, true);
            WriteLiteral("\r\n<div>\r\n");
            EndContext();
#line 8 "E:\SKOLENIE .NET TEMP\Ex_14_EfCore_CodeFirst\Ex_14_EfCore_CodeFirst\Views\Home\Index.cshtml"
      
        if (Model != null)
        {
            if (Model.Any())
            {
                foreach(var coffee in Model)
                {

#line default
#line hidden
            BeginContext(241, 25, true);
            WriteLiteral("                    <div>");
            EndContext();
            BeginContext(268, 67, false);
#line 15 "E:\SKOLENIE .NET TEMP\Ex_14_EfCore_CodeFirst\Ex_14_EfCore_CodeFirst\Views\Home\Index.cshtml"
                     Write(coffee.Name + " is a type of " + coffee.Brand + " and is drank by:");

#line default
#line hidden
            EndContext();
            BeginContext(336, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 16 "E:\SKOLENIE .NET TEMP\Ex_14_EfCore_CodeFirst\Ex_14_EfCore_CodeFirst\Views\Home\Index.cshtml"
                    foreach(var drinker in coffee.EmployeeCoffee)
                    {

#line default
#line hidden
            BeginContext(434, 32, true);
            WriteLiteral("                        <div> - ");
            EndContext();
            BeginContext(468, 61, false);
#line 18 "E:\SKOLENIE .NET TEMP\Ex_14_EfCore_CodeFirst\Ex_14_EfCore_CodeFirst\Views\Home\Index.cshtml"
                            Write(drinker.Employee.Name + " from " + drinker.Employee.Workplace);

#line default
#line hidden
            EndContext();
            BeginContext(530, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 19 "E:\SKOLENIE .NET TEMP\Ex_14_EfCore_CodeFirst\Ex_14_EfCore_CodeFirst\Views\Home\Index.cshtml"

                    }

                }
            }
        }
    

#line default
#line hidden
            BeginContext(617, 10, true);
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Coffee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
