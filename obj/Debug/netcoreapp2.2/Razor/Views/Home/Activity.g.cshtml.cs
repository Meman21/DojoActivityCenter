#pragma checksum "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Activity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc0744198db6784543673369ef8e803f8032a1ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Activity), @"mvc.1.0.view", @"/Views/Home/Activity.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Activity.cshtml", typeof(AspNetCore.Views_Home_Activity))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc0744198db6784543673369ef8e803f8032a1ef", @"/Views/Home/Activity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e72ab6140e435fa7efd67238cade4d60e8f980", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Activity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("join"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 73, true);
            WriteLiteral("<p><a href=\"/dashboard\">Home</a> | <a href=\"/logout\">Log Off</a></p>\n<h1>");
            EndContext();
            BeginContext(74, 23, false);
#line 2 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Activity.cshtml"
Write(ViewBag.showevent.title);

#line default
#line hidden
            EndContext();
            BeginContext(97, 20, true);
            WriteLiteral("</h1>\n<br>\n<td>\n    ");
            EndContext();
            BeginContext(117, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc0744198db6784543673369ef8e803f8032a1ef4344", async() => {
                BeginContext(151, 47, true);
                WriteLiteral("\n        <input type=\"hidden\" name=\"ActivityId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 198, "\"", 235, 1);
#line 6 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Activity.cshtml"
WriteAttributeValue("", 206, ViewBag.showevent.ActivityId, 206, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(236, 93, true);
                WriteLiteral(">\n        <button type=\"submit\" name=\"join\">Join</button>                               \n    ");
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
            BeginContext(336, 35, true);
            WriteLiteral("\n</td>\n<br>\n<h3>Event Coordinator: ");
            EndContext();
            BeginContext(372, 29, false);
#line 11 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Activity.cshtml"
                  Write(ViewBag.showevent.coordinator);

#line default
#line hidden
            EndContext();
            BeginContext(401, 36, true);
            WriteLiteral("</h3>\n<br>\n<h4>Description:</h4>\n<p>");
            EndContext();
            BeginContext(438, 22, false);
#line 14 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Activity.cshtml"
Write(ViewBag.showevent.desc);

#line default
#line hidden
            EndContext();
            BeginContext(460, 38, true);
            WriteLiteral("</p>\n<br>\n<br>\n<h4>Participants:</h4>\n");
            EndContext();
#line 18 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Activity.cshtml"
 foreach(var p in ViewBag.showevent.UserActivity){

#line default
#line hidden
            BeginContext(549, 5, true);
            WriteLiteral("  <p>");
            EndContext();
            BeginContext(555, 12, false);
#line 19 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Activity.cshtml"
Write(p.User.fname);

#line default
#line hidden
            EndContext();
            BeginContext(567, 7, true);
            WriteLiteral("</p>  \n");
            EndContext();
#line 20 "/Users/hanificicek/Desktop/CSharp/DojoActivityCenter/Views/Home/Activity.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591