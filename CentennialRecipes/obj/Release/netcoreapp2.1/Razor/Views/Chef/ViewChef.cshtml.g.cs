#pragma checksum "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d19dbf514c26ca569f482d64c46041abe3db2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chef_ViewChef), @"mvc.1.0.view", @"/Views/Chef/ViewChef.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chef/ViewChef.cshtml", typeof(AspNetCore.Views_Chef_ViewChef))]
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
#line 2 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\_ViewImports.cshtml"
using CentennialRecipes.Models;

#line default
#line hidden
#line 3 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\_ViewImports.cshtml"
using CentennialRecipes.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5d19dbf514c26ca569f482d64c46041abe3db2f", @"/Views/Chef/ViewChef.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e86bbc2e51f7939139159a0ef435c4ffc7f602d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Chef_ViewChef : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chef>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-large flex-align-self-start"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnterChefDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RecipeList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("View recipes created by this chef"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-large"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
  
    string header;

    header = "Chef Details";
    ViewBag.Title = Model.ToString() + " | Centennial Recipes";

#line default
#line hidden
            BeginContext(137, 26, true);
            WriteLiteral("\r\n<!-- Chef Name -->\r\n<h1>");
            EndContext();
            BeginContext(164, 16, false);
#line 10 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
Write(Model.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(180, 127, true);
            WriteLiteral("</h1>\r\n\r\n<div class=\"flex-vertical-padded bg-lighter-solid-border\">\r\n\r\n    <!-- Description -->\r\n    <h2>Description</h2>\r\n    ");
            EndContext();
            BeginContext(308, 17, false);
#line 16 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(325, 64, true);
            WriteLiteral("\r\n\r\n    <!-- Specialty -->\r\n    <h2>Specialty Cuisine</h2>\r\n    ");
            EndContext();
            BeginContext(390, 15, false);
#line 20 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
Write(Model.Specialty);

#line default
#line hidden
            EndContext();
            BeginContext(405, 26, true);
            WriteLiteral("\r\n\r\n    <!-- Website -->\r\n");
            EndContext();
#line 23 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
     if (Model.Website != "" && Model.Website != null)
    {

#line default
#line hidden
            BeginContext(494, 36, true);
            WriteLiteral("        <h3>Website</h3>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 530, "\"", 551, 1);
#line 26 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
WriteAttributeValue("", 537, Model.Website, 537, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(552, 56, true);
            WriteLiteral(" target=\"_blank\" title=\"Open chef website in a new tab\">");
            EndContext();
            BeginContext(609, 13, false);
#line 26 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
                                                                                   Write(Model.Website);

#line default
#line hidden
            EndContext();
            BeginContext(622, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 27 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
    }

#line default
#line hidden
            BeginContext(635, 27, true);
            WriteLiteral("\r\n    <!-- Restaurant -->\r\n");
            EndContext();
#line 30 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
     if (Model.Restaurant != "" && Model.Restaurant != null)
    {

#line default
#line hidden
            BeginContext(731, 43, true);
            WriteLiteral("        <h3>Restaurant</h3>\r\n        <span>");
            EndContext();
            BeginContext(775, 16, false);
#line 33 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
         Write(Model.Restaurant);

#line default
#line hidden
            EndContext();
            BeginContext(791, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 34 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
    }

#line default
#line hidden
            BeginContext(807, 107, true);
            WriteLiteral("\r\n    <hr />\r\n\r\n    <div class=\"flex-horizontal\">\r\n        <!-- Update Button (visible to admin only) -->\r\n");
            EndContext();
#line 40 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
         if (User.IsInRole("Admin"))
        {

#line default
#line hidden
            BeginContext(963, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(975, 268, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a00f9ca0c574ab3856d9f79819e8765", async() => {
                BeginContext(1228, 11, true);
                WriteLiteral("Update Chef");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
                 WriteLiteral(Model.ChefId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
                        WriteLiteral(ViewContext.HttpContext.Request.Path);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1243, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
        }

#line default
#line hidden
            BeginContext(1256, 48, true);
            WriteLiteral("\r\n        <!-- View Recipes button -->\r\n        ");
            EndContext();
            BeginContext(1304, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "123f6202eb9e458d974745661c20be6b", async() => {
                BeginContext(1500, 12, true);
                WriteLiteral("View Recipes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-chefId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Chef\ViewChef.cshtml"
                 WriteLiteral(Model.ChefId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["chefId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-chefId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["chefId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1516, 24, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chef> Html { get; private set; }
    }
}
#pragma warning restore 1591