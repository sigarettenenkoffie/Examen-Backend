#pragma checksum "C:\Users\Hannes\Desktop\EE-04-OnlineBetting-master\EE-04-OnlineBetting-master\ExamenOnlineGokken\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62ddb88aebd3888254772dbc98a98fa5a22df68c"
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
#line 1 "C:\Users\Hannes\Desktop\EE-04-OnlineBetting-master\EE-04-OnlineBetting-master\ExamenOnlineGokken\Views\_ViewImports.cshtml"
using ExamenOnlineGokken;

#line default
#line hidden
#line 2 "C:\Users\Hannes\Desktop\EE-04-OnlineBetting-master\EE-04-OnlineBetting-master\ExamenOnlineGokken\Views\_ViewImports.cshtml"
using ExamenOnlineGokken.Models;

#line default
#line hidden
#line 3 "C:\Users\Hannes\Desktop\EE-04-OnlineBetting-master\EE-04-OnlineBetting-master\ExamenOnlineGokken\Views\_ViewImports.cshtml"
using ExamenOnlineGokken.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62ddb88aebd3888254772dbc98a98fa5a22df68c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5da01c2bff5ca6a1688364d3893cc05c3768d158", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 5, true);
            WriteLiteral("\n<h4>");
            EndContext();
            BeginContext(25, 11, false);
#line 3 "C:\Users\Hannes\Desktop\EE-04-OnlineBetting-master\EE-04-OnlineBetting-master\ExamenOnlineGokken\Views\Home\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(36, 341, true);
            WriteLiteral(@"</h4>
<table class=""table mt-5"" id=""games-table"">
    <thead class=""thead-light"">
        <tr>
            <th scope=""col"">Home</th>
            <th scope=""col"">Away</th>
            <th scope=""col"">Date</th>
            <th scope=""col"">N° of Bets</th>
            <th scope=""col"">Bet!</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 15 "C:\Users\Hannes\Desktop\EE-04-OnlineBetting-master\EE-04-OnlineBetting-master\ExamenOnlineGokken\Views\Home\Index.cshtml"
         foreach (var game in Model.Games)
        {

#line default
#line hidden
            BeginContext(432, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(471, 13, false);
#line 18 "C:\Users\Hannes\Desktop\EE-04-OnlineBetting-master\EE-04-OnlineBetting-master\ExamenOnlineGokken\Views\Home\Index.cshtml"
               Write(game.AwayTeam);

#line default
#line hidden
            EndContext();
            BeginContext(484, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(512, 13, false);
#line 19 "C:\Users\Hannes\Desktop\EE-04-OnlineBetting-master\EE-04-OnlineBetting-master\ExamenOnlineGokken\Views\Home\Index.cshtml"
               Write(game.Hometeam);

#line default
#line hidden
            EndContext();
            BeginContext(525, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(553, 15, false);
#line 20 "C:\Users\Hannes\Desktop\EE-04-OnlineBetting-master\EE-04-OnlineBetting-master\ExamenOnlineGokken\Views\Home\Index.cshtml"
               Write(game.DateOfGame);

#line default
#line hidden
            EndContext();
            BeginContext(568, 66, true);
            WriteLiteral("</td>\r\n                <td><span class=\"badge bg-info text-white\">");
            EndContext();
            BeginContext(635, 26, false);
#line 21 "C:\Users\Hannes\Desktop\EE-04-OnlineBetting-master\EE-04-OnlineBetting-master\ExamenOnlineGokken\Views\Home\Index.cshtml"
                                                      Write(game.Bets.Count.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(661, 34, true);
            WriteLiteral("</span></td>\r\n                <td>");
            EndContext();
            BeginContext(695, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62ddb88aebd3888254772dbc98a98fa5a22df68c7595", async() => {
                BeginContext(795, 4, true);
                WriteLiteral("Bet!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\Hannes\Desktop\EE-04-OnlineBetting-master\EE-04-OnlineBetting-master\ExamenOnlineGokken\Views\Home\Index.cshtml"
                                                               WriteLiteral(game.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(803, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 25 "C:\Users\Hannes\Desktop\EE-04-OnlineBetting-master\EE-04-OnlineBetting-master\ExamenOnlineGokken\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(842, 77, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n    <th colspan=\"3\"></th>\r\n    </tfoot>\r\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
