#pragma checksum "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/SolvedErrors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b91181cd1c2d9d7888f2849d60b996b8088e692f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SolvedErrors), @"mvc.1.0.view", @"/Views/Home/SolvedErrors.cshtml")]
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
#line 1 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/_ViewImports.cshtml"
using LiveErrorDisplayApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/_ViewImports.cshtml"
using LiveErrorDisplayApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b91181cd1c2d9d7888f2849d60b996b8088e692f", @"/Views/Home/SolvedErrors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a41aea3f20705486d9f48ecb3e2d8a0663dbfa02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SolvedErrors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Error>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/SolvedErrors.cshtml"
Write(await Html.PartialAsync("_errorPartial"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Error>> Html { get; private set; }
    }
}
#pragma warning restore 1591
