#pragma checksum "C:\Users\Jason\Desktop\CodingDojo\CSharp\EntityFramework\ChefsNDishes\Views\Home\Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d054c109a065582089e02c470f0b12572626380a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "C:\Users\Jason\Desktop\CodingDojo\CSharp\EntityFramework\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#line 2 "C:\Users\Jason\Desktop\CodingDojo\CSharp\EntityFramework\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d054c109a065582089e02c470f0b12572626380a", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewDish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 5px; margin-bottom: 5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Jason\Desktop\CodingDojo\CSharp\EntityFramework\ChefsNDishes\Views\Home\Dishes.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(64, 87, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Chefs & <u>Dishes</u></h1>\r\n    ");
            EndContext();
            BeginContext(151, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d054c109a065582089e02c470f0b12572626380a5838", async() => {
                BeginContext(233, 5, true);
                WriteLiteral("Chefs");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(242, 10, true);
            WriteLiteral("<br>\r\n    ");
            EndContext();
            BeginContext(252, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d054c109a065582089e02c470f0b12572626380a7588", async() => {
                BeginContext(381, 9, true);
                WriteLiteral(" ADD DISH");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(394, 133, true);
            WriteLiteral("<br>\r\n    \r\n</div>\r\n\r\n<table class=\"list-group\">\r\n        <li class=\"list-group-item list-group-item-dark\">List of our Dishes:</li>\r\n");
            EndContext();
#line 15 "C:\Users\Jason\Desktop\CodingDojo\CSharp\EntityFramework\ChefsNDishes\Views\Home\Dishes.cshtml"
     foreach(var d in Model)
    {

#line default
#line hidden
            BeginContext(564, 83, true);
            WriteLiteral("        <li class=\"list-group-item list-group-item-secondary\" asp-action=\"ShowDish\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 647, "\"", 671, 1);
#line 17 "C:\Users\Jason\Desktop\CodingDojo\CSharp\EntityFramework\ChefsNDishes\Views\Home\Dishes.cshtml"
WriteAttributeValue("", 662, d.DishID, 662, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(672, 23, true);
            WriteLiteral(" asp-controller=\"Home\">");
            EndContext();
            BeginContext(696, 6, false);
#line 17 "C:\Users\Jason\Desktop\CodingDojo\CSharp\EntityFramework\ChefsNDishes\Views\Home\Dishes.cshtml"
                                                                                                                              Write(d.Name);

#line default
#line hidden
            EndContext();
            BeginContext(702, 4, true);
            WriteLiteral(" by ");
            EndContext();
            BeginContext(707, 19, false);
#line 17 "C:\Users\Jason\Desktop\CodingDojo\CSharp\EntityFramework\ChefsNDishes\Views\Home\Dishes.cshtml"
                                                                                                                                         Write(d.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(726, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(728, 18, false);
#line 17 "C:\Users\Jason\Desktop\CodingDojo\CSharp\EntityFramework\ChefsNDishes\Views\Home\Dishes.cshtml"
                                                                                                                                                              Write(d.Creator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(746, 18, true);
            WriteLiteral(" Tastiness Level: ");
            EndContext();
            BeginContext(765, 11, false);
#line 17 "C:\Users\Jason\Desktop\CodingDojo\CSharp\EntityFramework\ChefsNDishes\Views\Home\Dishes.cshtml"
                                                                                                                                                                                                   Write(d.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(776, 11, true);
            WriteLiteral(" Calories: ");
            EndContext();
            BeginContext(788, 10, false);
#line 17 "C:\Users\Jason\Desktop\CodingDojo\CSharp\EntityFramework\ChefsNDishes\Views\Home\Dishes.cshtml"
                                                                                                                                                                                                                          Write(d.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(798, 8, true);
            WriteLiteral(" </li>\r\n");
            EndContext();
#line 18 "C:\Users\Jason\Desktop\CodingDojo\CSharp\EntityFramework\ChefsNDishes\Views\Home\Dishes.cshtml"
    }

#line default
#line hidden
            BeginContext(813, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
