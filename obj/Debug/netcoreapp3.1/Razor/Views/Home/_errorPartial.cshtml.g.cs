#pragma checksum "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12375aeb597ec4318a69e0a5d2df1029379b39db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__errorPartial), @"mvc.1.0.view", @"/Views/Home/_errorPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12375aeb597ec4318a69e0a5d2df1029379b39db", @"/Views/Home/_errorPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a41aea3f20705486d9f48ecb3e2d8a0663dbfa02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__errorPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Resolve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
 if(Model.Count==0){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No error(s) found!</p>\n");
#nullable restore
#line 3 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
}else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <table class=""table table-condensed table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>Error Message</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 14 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
             foreach(var e in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 16 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
                   Write(e.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 17 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
                   Write(e.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 18 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
                     if(e.IsResolved){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\n                            Resolved By: <span class=\"badge badge-primary m-2\">");
#nullable restore
#line 20 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
                                                                          Write(e.ResolvedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            Resolved On: <span class=\"badge badge-primary m-2\">");
#nullable restore
#line 21 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
                                                                          Write(e.ResolvedOn.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </td>\n");
#nullable restore
#line 23 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12375aeb597ec4318a69e0a5d2df1029379b39db6583", async() => {
                WriteLiteral("\n                            ");
#nullable restore
#line 29 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
                        Write(e.IsResolved?"Resolved":"Resolve");

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
                              WriteLiteral(e.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 28 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
AddHtmlAttributeValue("", 1015, e.IsResolved? "btn btn-primary disabled": "btn btn-danger", 1015, 61, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </td>\n");
#nullable restore
#line 32 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\n");
#nullable restore
#line 34 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n");
#nullable restore
#line 38 "/Users/madanuprety/Documents/videos/LiveError/LiveErrorDisplayApp/Views/Home/_errorPartial.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
