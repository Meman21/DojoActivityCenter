#pragma checksum "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01eab635b025008f139d46508cc02134eaf93cba"
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
#line 1 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/_ViewImports.cshtml"
using DojoActivityCenter;

#line default
#line hidden
#line 2 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/_ViewImports.cshtml"
using DojoActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01eab635b025008f139d46508cc02134eaf93cba", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e72ab6140e435fa7efd67238cade4d60e8f980", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DojoActivityCenter.Models.Activity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("join"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("leave"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 13, true);
            WriteLiteral("<h3>Welcome, ");
            EndContext();
            BeginContext(14, 22, false);
#line 1 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
        Write(ViewBag.UserInfo.fname);

#line default
#line hidden
            EndContext();
            BeginContext(36, 275, true);
            WriteLiteral(@"</h3>
<br>
<a href=""/logout"">Log Off</a>
<br>
<br>
<table>
    <tr>
        <td>Activity</td>
        <td>Date and Time</td>
        <td>Duration</td>
        <td>Event Coordinator</td>
        <td>Number of Participants</td>
        <td>Actions</td>
    </tr>
");
            EndContext();
            BeginContext(364, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 16 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
         foreach(var e in Model){

#line default
#line hidden
            BeginContext(399, 41, true);
            WriteLiteral("            <tr>\r\n                <td> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 440, "\"", 473, 2);
            WriteAttributeValue("", 447, "showactivity/", 447, 13, true);
#line 18 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
WriteAttributeValue("", 460, e.ActivityId, 460, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(474, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(476, 7, false);
#line 18 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
                                                     Write(e.title);

#line default
#line hidden
            EndContext();
            BeginContext(483, 31, true);
            WriteLiteral("</a></td>\r\n                <td>");
            EndContext();
            BeginContext(515, 24, false);
#line 19 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
               Write(e.date.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
            BeginContext(539, 4, true);
            WriteLiteral(" -  ");
            EndContext();
            BeginContext(544, 27, false);
#line 19 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
                                            Write(e.time.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(571, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(599, 10, false);
#line 20 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
               Write(e.duration);

#line default
#line hidden
            EndContext();
            BeginContext(609, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(611, 16, false);
#line 20 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
                           Write(e.durationlength);

#line default
#line hidden
            EndContext();
            BeginContext(627, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(655, 13, false);
#line 21 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
               Write(e.coordinator);

#line default
#line hidden
            EndContext();
            BeginContext(668, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(696, 20, false);
#line 22 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
               Write(e.UserActivity.Count);

#line default
#line hidden
            EndContext();
            BeginContext(716, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 23 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
                 if( e.coordinator == ViewBag.UserInfo.UserId){

#line default
#line hidden
            BeginContext(788, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(838, 241, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01eab635b025008f139d46508cc02134eaf93cba8880", async() => {
                BeginContext(874, 68, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"ActivityId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 942, "\"", 963, 1);
#line 26 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
WriteAttributeValue("", 950, e.ActivityId, 950, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(964, 108, true);
                WriteLiteral(">\r\n                            <button type=\"submit\" name=\"delete\">Delete</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1079, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 30 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
                }else{
                    if(e.UserActivity.Where(u => u.UserId == ViewBag.UserInfo.UserId).SingleOrDefault() == null)
                    {

#line default
#line hidden
            BeginContext(1269, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(1327, 286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01eab635b025008f139d46508cc02134eaf93cba11639", async() => {
                BeginContext(1361, 76, true);
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"ActivityId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1437, "\"", 1458, 1);
#line 35 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
WriteAttributeValue("", 1445, e.ActivityId, 1445, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1459, 147, true);
                WriteLiteral(">\r\n                                    <button type=\"submit\" name=\"join\">Join</button>                               \r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1613, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 39 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
                    }else{

#line default
#line hidden
            BeginContext(1674, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(1732, 250, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01eab635b025008f139d46508cc02134eaf93cba14323", async() => {
                BeginContext(1767, 72, true);
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"ActivityId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1839, "\"", 1860, 1);
#line 42 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
WriteAttributeValue("", 1847, e.ActivityId, 1847, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1861, 114, true);
                WriteLiteral(">\r\n                                <button type=\"submit\" name=\"leave\">Leave</button>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1982, 55, true);
            WriteLiteral("\r\n                        </td>                      \r\n");
            EndContext();
#line 46 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2079, 55, true);
            WriteLiteral("                \r\n                \r\n            </tr>\r\n");
            EndContext();
#line 51 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2145, 70, true);
            WriteLiteral("</table>\r\n<br>\r\n<a href=\"/new\"><button>Add New Activity</button></a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DojoActivityCenter.Models.Activity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
