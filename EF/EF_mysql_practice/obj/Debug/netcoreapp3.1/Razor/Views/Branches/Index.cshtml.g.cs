#pragma checksum "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96659c2e2134a02710d7a1b62df2a799b562c567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branches_Index), @"mvc.1.0.view", @"/Views/Branches/Index.cshtml")]
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
#line 1 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/_ViewImports.cshtml"
using EF_mysql_practice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/_ViewImports.cshtml"
using EF_mysql_practice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96659c2e2134a02710d7a1b62df2a799b562c567", @"/Views/Branches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b374b1886fd324cd591e9ea12db12a74199e13e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Branches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
  
        var branches = (List<BranchModel>)ViewData["Branches"];
        var d = ViewData["d"];
        var g = (List<BranchModel>)ViewData["g"];

    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Branches index</h1>\n    <table class=\"table\">\n        <thead>\n        <th>ID</th>\n        <th>Address</th>\n        <th>Name</th>\n        <th>Area</th>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 16 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
             foreach (var b in branches)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 19 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
                   Write(b.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 20 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
                   Write(b.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 21 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
                   Write(b.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 22 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
                   Write(b.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 24 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n\n\n    <h2>");
#nullable restore
#line 29 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
   Write(d);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n");
#nullable restore
#line 30 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
     foreach(var gg in g)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <h4>");
#nullable restore
#line 32 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
            Write(gg.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 32 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
                      Write(gg.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
#nullable restore
#line 33 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"

           }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\n");
#nullable restore
#line 36 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
  
    var a = (List<BranchModel>)ViewData["aa"];

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
 foreach(var aa in a)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
           Write(aa.Address);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/hanans/Projects/EF_mysql_practice/EF_mysql_practice/Views/Branches/Index.cshtml"
                           
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
