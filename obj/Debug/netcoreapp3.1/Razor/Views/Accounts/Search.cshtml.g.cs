#pragma checksum "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c908aa40c817cfc648dddcd21359ce2e19e4fc70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Search), @"mvc.1.0.view", @"/Views/Accounts/Search.cshtml")]
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
#line 1 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
using FruityNET.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
using FruityNET.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c908aa40c817cfc648dddcd21359ce2e19e4fc70", @"/Views/Accounts/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d21de4c8441600b2df7cae93404b93e78c1beda4", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchUserDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search by Username"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewProfileOfUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FriendList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendFriendInvite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
            WriteLiteral("\n\n");
            WriteLiteral("\n\n\n");
            WriteLiteral("\n");
#nullable restore
#line 15 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
  
    ViewData["Title"] = "Search User";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 20 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
 if (!ViewData.ModelState.IsValid && ViewData.ModelState["Error"].Errors.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">");
#nullable restore
#line 22 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
                               Write(ViewData.ModelState["Error"].Errors.First().ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 24 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
 if (!String.IsNullOrEmpty(ViewBag.Message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\"> User has been Successfully added to group.\n    </div>\n");
#nullable restore
#line 29 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c908aa40c817cfc648dddcd21359ce2e19e4fc709670", async() => {
                WriteLiteral("\n\n\n           \n\n\n                <div class=\"form-group >\n                    \n                    <label asp-for=\"Username\">Search for a User\n                    </label>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c908aa40c817cfc648dddcd21359ce2e19e4fc7010127", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 42 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Username);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                       <button class=\"btn btn-default btn-circle\" type=\"submit\"><i class=\"fa fa-search\" style=\"color: black;\"></i></button>\n\n                </div>                                    \n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c908aa40c817cfc648dddcd21359ce2e19e4fc7012137", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 46 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Username);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                <br>\n               \n\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<br>\n\n");
#nullable restore
#line 54 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
 if(Model.Username != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
     foreach (var result in Model.Users)
    {
      

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-hover"">
  <thead>
    <tr>
      <th scope=""col"">Result</th>
      <th scope=""col"">Username </th>
      <th scope=""col"">First Name </th>
      <th scope=""col"">Last Name </th>
      <th scope=""col"">Role </th>
      <th scope=""col""> </th>
            <th scope=""col""> </th>
");
#nullable restore
#line 69 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
              if(result.RequestIsPending){

#line default
#line hidden
#nullable disable
            WriteLiteral("<th></th>");
#nullable restore
#line 69 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n    </tr>\n  </thead>\n    <tbody>\n        <tr class=\"table-success\">\n      <th scope=\"row\">Success</th>\n      <td>");
#nullable restore
#line 78 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
     Write(result.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 79 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
     Write(result.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 80 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
     Write(result.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 81 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
     Write(result.UserType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td> \n");
#nullable restore
#line 83 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
         if(result.UserId == UserManager.GetUserId(User))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c908aa40c817cfc648dddcd21359ce2e19e4fc7017826", async() => {
                WriteLiteral("\n                        Your Profile\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 90 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c908aa40c817cfc648dddcd21359ce2e19e4fc7019327", async() => {
                WriteLiteral("\n                        View Profile\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
                           WriteLiteral(result.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 98 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\n        <td>\n");
#nullable restore
#line 101 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
         if(result.UserId != UserManager.GetUserId(User) && (result.isFriendsOfCurrentUser is false && result.RequestIsPending is false) )
        {
       

#line default
#line hidden
#nullable disable
            WriteLiteral("             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c908aa40c817cfc648dddcd21359ce2e19e4fc7022152", async() => {
                WriteLiteral("\n                        <i class=\'fas fa-user-plus\' style=\'font-size:14px;color:white\'></i>\n                          Send Friend Request\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
                           WriteLiteral(result.ResultUserFriendListID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 113 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
         
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
         if(result.isFriendsOfCurrentUser )
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>You and ");
#nullable restore
#line 117 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
                  Write(result.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" are friends.</p>\n");
#nullable restore
#line 118 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 120 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
         if(result.RequestIsPending)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Pending Request</p>\n");
#nullable restore
#line 123 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n       \n        \n        \n        \n\n        </td>\n    \n          \n        \n\n    </tr>\n    </tbody>\n        </table>\n");
#nullable restore
#line 138 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
     


    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "/Users/jasonampah/Documents/Dev/C#/MVCApps/FruityNET/Views/Accounts/Search.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchUserDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
