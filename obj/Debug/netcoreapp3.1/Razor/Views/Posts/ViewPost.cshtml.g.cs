#pragma checksum "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Posts/ViewPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b922b30d5d128734e6aa81e7c45266df2abf466"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_ViewPost), @"mvc.1.0.view", @"/Views/Posts/ViewPost.cshtml")]
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
#line 1 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/_ViewImports.cshtml"
using FruityNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/_ViewImports.cshtml"
using FruityNET.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Posts/ViewPost.cshtml"
using FruityNET.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b922b30d5d128734e6aa81e7c45266df2abf466", @"/Views/Posts/ViewPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d21de4c8441600b2df7cae93404b93e78c1beda4", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_ViewPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostViewDetaisDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n");
            WriteLiteral("\n");
#nullable restore
#line 7 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Posts/ViewPost.cshtml"
  
    ViewData["Title"] = " View Post";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card\">\n  <div class=\"card-body\">\n    <h4 class=\"card-title\">");
#nullable restore
#line 13 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Posts/ViewPost.cshtml"
                      Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <p class=\"card-text\">");
#nullable restore
#line 14 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Posts/ViewPost.cshtml"
                    Write(Model.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 15 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Posts/ViewPost.cshtml"
                                             Write(Model.DatePosted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n\n    </div></div><br>\n\n<h3>Comments</h3>\n");
#nullable restore
#line 20 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Posts/ViewPost.cshtml"
 foreach (var comment in Model.comments)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\n  <div class=\"card-body\">\n    <h4 class=\"card-title\">");
#nullable restore
#line 24 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Posts/ViewPost.cshtml"
                      Write(comment.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 25 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Posts/ViewPost.cshtml"
                                         Write(comment.DatePosted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n    <p class=\"card-text\">");
#nullable restore
#line 26 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Posts/ViewPost.cshtml"
                    Write(comment.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    \n  </div></div><br>\n");
#nullable restore
#line 29 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Posts/ViewPost.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostViewDetaisDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
