#pragma checksum "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "343c05a6e59473bbd84ab47a92fb7707f06517b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_ViewRecipe), @"mvc.1.0.view", @"/Views/Recipe/ViewRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipe/ViewRecipe.cshtml", typeof(AspNetCore.Views_Recipe_ViewRecipe))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"343c05a6e59473bbd84ab47a92fb7707f06517b2", @"/Views/Recipe/ViewRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e86bbc2e51f7939139159a0ef435c4ffc7f602d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_ViewRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RecipeList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("View all recipes added by this user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Go to chef profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Chef", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewChef", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnterRecipeDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex-align-self-start btn btn-large"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("View recipes added by this user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Remove review"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/remove.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReviewRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex-align-self-center btn btn-large"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
  
    ViewBag.Title = $"{Model.Name} | Centennial Recipes";

#line default
#line hidden
            BeginContext(81, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(88, 10, false);
#line 6 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(98, 90, true);
            WriteLiteral("</h1>\r\n\r\n<div class=\"flex-vertical-padded bg-lighter-solid-border\">\r\n    <!-- Author -->\r\n");
            EndContext();
#line 10 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
      
        string user = User.Identity.Name == Model.User ? $"{Model.User} (You)" : Model.User;
    

#line default
#line hidden
            BeginContext(297, 44, true);
            WriteLiteral("    <i class=\"flex-align-self-end\">Added by ");
            EndContext();
            BeginContext(341, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1e9d640e14b49588b2a90665f1d60dc", async() => {
                BeginContext(465, 3, true);
                WriteLiteral("<b>");
                EndContext();
                BeginContext(469, 4, false);
#line 13 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
                                                                                                                                                                      Write(user);

#line default
#line hidden
                EndContext();
                BeginContext(473, 4, true);
                WriteLiteral("</b>");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-user", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
                                                                                                   WriteLiteral(Model.User);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["user"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-user", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["user"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(481, 64, true);
            WriteLiteral("</i>\r\n\r\n    <!-- Description -->\r\n    <h2>Description</h2>\r\n    ");
            EndContext();
            BeginContext(546, 17, false);
#line 17 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(563, 42, true);
            WriteLiteral("\r\n\r\n    <!-- Chef -->\r\n    <h3>Chef</h3>\r\n");
            EndContext();
#line 21 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
     if (Model.ChefId == 1)
    {

#line default
#line hidden
            BeginContext(641, 14, true);
            WriteLiteral("        <span>");
            EndContext();
            BeginContext(656, 14, false);
#line 23 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
         Write(Model.ChefName);

#line default
#line hidden
            EndContext();
            BeginContext(670, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 24 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(703, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(711, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45e06c216a6e4b31b06f026cf8a8af0f", async() => {
                BeginContext(851, 21, false);
#line 30 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
                                   Write(Model.Chef.ToString());

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
             WriteLiteral(Model.ChefId);

#line default
#line hidden
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
            EndContext();
            BeginContext(876, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
    }

#line default
#line hidden
            BeginContext(885, 68, true);
            WriteLiteral("\r\n    <!-- Preparation Time -->\r\n    <h3>Preparation Time</h3>\r\n    ");
            EndContext();
            BeginContext(954, 21, false);
#line 35 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
Write(Model.PreparationTime);

#line default
#line hidden
            EndContext();
            BeginContext(975, 66, true);
            WriteLiteral("\r\n\r\n    <!-- INGREDIENTS -->\r\n    <h2>Ingredients</h2>\r\n    <ul>\r\n");
            EndContext();
#line 40 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
         foreach (string ingredient in Model.GetIngredients())
        {

#line default
#line hidden
            BeginContext(1116, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(1133, 10, false);
#line 42 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
           Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(1143, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 43 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
        }

#line default
#line hidden
            BeginContext(1161, 50, true);
            WriteLiteral("    </ul>\r\n\r\n    <!-- \'Update Recipe\' button -->\r\n");
            EndContext();
#line 47 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
     if (User.Identity.IsAuthenticated && ((User.IsInRole("Admin")) ||
     (User.IsInRole("User") && User.Identity.Name == Model.User)))
    {

#line default
#line hidden
            BeginContext(1358, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1366, 259, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c408e518e6fc4ac99d8b2fc5622dc057", async() => {
                BeginContext(1608, 13, true);
                WriteLiteral("Update Recipe");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
             WriteLiteral(Model.RecipeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
                    WriteLiteral(ViewContext.HttpContext.Request.Path);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1625, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1629, 16, true);
            WriteLiteral("        <hr />\r\n");
            EndContext();
#line 57 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
    }

#line default
#line hidden
            BeginContext(1652, 41, true);
            WriteLiteral("\r\n    <!-- REVIEWS -->\r\n    <h2>Reviews (");
            EndContext();
            BeginContext(1694, 22, false);
#line 60 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
            Write(Model.GetReviewCount());

#line default
#line hidden
            EndContext();
            BeginContext(1716, 8, true);
            WriteLiteral(")</h2>\r\n");
            EndContext();
#line 61 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
     foreach (RecipeReview review in Model.Reviews.OrderByDescending(r => r.DateAdded))
    {

#line default
#line hidden
            BeginContext(1820, 128, true);
            WriteLiteral("        <div class=\"reviewDiv flex-horizontal flex-align-self-start\">\r\n            <div class=\"review\">\r\n                <span>\"");
            EndContext();
            BeginContext(1949, 14, false);
#line 65 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
                  Write(review.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1963, 87, true);
            WriteLiteral("\"</span>\r\n                <div>—————</div>\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(2050, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa6ca20618d34671aa918b89c1aa7f2e", async() => {
                BeginContext(2195, 3, true);
                WriteLiteral("<b>");
                EndContext();
                BeginContext(2199, 11, false);
#line 70 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
                                                             Write(review.User);

#line default
#line hidden
                EndContext();
                BeginContext(2210, 4, true);
                WriteLiteral("</b>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-user", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
                           WriteLiteral(review.User);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["user"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-user", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["user"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2218, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(2221, 54, false);
#line 70 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
                                                                                   Write(review.DateAdded.ToString("MMMM dd, yyyy hh:mm:ss tt"));

#line default
#line hidden
            EndContext();
            BeginContext(2275, 164, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <!-- The admin, the author of the recipe, and the writer of the review can perform review deletion -->\r\n");
            EndContext();
#line 75 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
             if (User.IsInRole("Admin") || (User.IsInRole("User") &&
               (User.Identity.Name == Model.User || User.Identity.Name == review.User)))
            {

#line default
#line hidden
            BeginContext(2614, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2630, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "749be34c62f2434783769c305b1d9f5c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2644, "confirmDeleteReview(", 2644, 20, true);
#line 78 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
AddHtmlAttributeValue("", 2664, review.RecipeReviewId, 2664, 22, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2686, ",", 2686, 1, true);
#line 78 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
AddHtmlAttributeValue(" ", 2687, review.RecipeId, 2688, 16, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2704, ")", 2704, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2779, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 80 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
            }

#line default
#line hidden
            BeginContext(2796, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 82 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
    }

#line default
#line hidden
            BeginContext(2819, 42, true);
            WriteLiteral("\r\n    <!-- \'Add a Review\' button -->\r\n    ");
            EndContext();
            BeginContext(2861, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87326c984fa4b5cb92e8ebec62a6649", async() => {
                BeginContext(3014, 12, true);
                WriteLiteral("Add a Review");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 87 "C:\Users\John\source\repos\COMP 229\CentennialRecipes\CentennialRecipes\Views\Recipe\ViewRecipe.cshtml"
         WriteLiteral(Model.RecipeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3030, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
