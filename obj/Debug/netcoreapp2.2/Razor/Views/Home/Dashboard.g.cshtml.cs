#pragma checksum "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c024ecf293fe4eaa055a1383313ad7ca84d7a10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\_ViewImports.cshtml"
using WedProj;

#line default
#line hidden
#line 2 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\_ViewImports.cshtml"
using WedProj.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c024ecf293fe4eaa055a1383313ad7ca84d7a10", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d414f962197583d1022e6620a00f8723634dab83", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c024ecf293fe4eaa055a1383313ad7ca84d7a104019", async() => {
                BeginContext(41, 135, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(183, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(185, 2577, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c024ecf293fe4eaa055a1383313ad7ca84d7a105347", async() => {
                BeginContext(191, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(220, 429, true);
                WriteLiteral(@"    <div class=""container"">
        <a class=""one-line"" href=""/logout"">LogOut</a>
        <p><h2 class=""one-line"">Welcome to the Wedding Planner</h2></p>
    </div>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Wedding</th>
                <th>Date</th>
                <th>Guest</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 24 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(706, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(753, 15, false);
#line 27 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"
                   Write(item.Wedder_One);

#line default
#line hidden
                EndContext();
                BeginContext(768, 3, true);
                WriteLiteral(" & ");
                EndContext();
                BeginContext(772, 15, false);
#line 27 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"
                                      Write(item.Wedder_Two);

#line default
#line hidden
                EndContext();
                BeginContext(787, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(819, 41, false);
#line 28 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"
                   Write(item.WeddingDate.ToString("MMM dd, yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(860, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(892, 17, false);
#line 29 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"
                   Write(item.Guests.Count);

#line default
#line hidden
                EndContext();
                BeginContext(909, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 30 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"
                     if (@ViewBag.UserId == @item.CreatorId)
                    {

#line default
#line hidden
                BeginContext(1001, 30, true);
                WriteLiteral("                        <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1031, "\"", 1062, 2);
                WriteAttributeValue("", 1038, "/deleteEvent/", 1038, 13, true);
#line 32 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1051, item.WedId, 1051, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1063, 18, true);
                WriteLiteral(">Delete</a></td>\r\n");
                EndContext();
#line 33 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"
                    }
                    
                    else
                    {
                        var count = 0;
                        foreach(var assoc in @item.Guests)
                        {
                            if(assoc.UId == @ViewBag.UserId)
                            {
                                count += 1;
                            }

                        }
                        if (count == 0)
                        {

#line default
#line hidden
                BeginContext(1568, 34, true);
                WriteLiteral("                            <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1602, "\"", 1626, 2);
                WriteAttributeValue("", 1609, "/rsvp/", 1609, 6, true);
#line 48 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1615, item.WedId, 1615, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1627, 16, true);
                WriteLiteral(">Rsvp</a></td>\r\n");
                EndContext();
#line 49 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"

                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1729, 34, true);
                WriteLiteral("                            <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1763, "\"", 1789, 2);
                WriteAttributeValue("", 1770, "/unrsvp/", 1770, 8, true);
#line 53 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1778, item.WedId, 1778, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1790, 19, true);
                WriteLiteral(">Un-Rsvp</a></td>\r\n");
                EndContext();
#line 54 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"

                        }
                        

#line default
#line hidden
#line 70 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"
                                                                                    
                    }

#line default
#line hidden
                BeginContext(2541, 65, true);
                WriteLiteral("                }\r\n                    }\r\n                </tr>\r\n");
                EndContext();
#line 75 "C:\Users\v-ussada\Documents\CodingDojo\EntityOrm\WedProj\Views\Home\Dashboard.cshtml"

            }

#line default
#line hidden
                BeginContext(2623, 36, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
                EndContext();
                BeginContext(2659, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c024ecf293fe4eaa055a1383313ad7ca84d7a1012124", async() => {
                    BeginContext(2682, 58, true);
                    WriteLiteral("\r\n        <button type=\"submit\">New Wedding</button>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2747, 8, true);
                WriteLiteral("\r\n    \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2762, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wedding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
