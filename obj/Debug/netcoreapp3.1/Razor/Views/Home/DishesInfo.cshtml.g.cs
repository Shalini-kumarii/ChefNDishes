#pragma checksum "C:\DOJO\Csharp\Chef_N_Dishes\Views\Home\DishesInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "892aff320f6265335aaa0882c0ebd2b27cb4590b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_DishesInfo), @"mvc.1.0.view", @"/Views/Home/DishesInfo.cshtml")]
namespace MyApp.Namespace.Home
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\DOJO\Csharp\Chef_N_Dishes\Views\Home\DishesInfo.cshtml"
using Chef_N_Dishes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DOJO\Csharp\Chef_N_Dishes\Views\Home\DishesInfo.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892aff320f6265335aaa0882c0ebd2b27cb4590b", @"/Views/Home/DishesInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1d1eb37dc6f0d82250bf784d7ea6a0b75ca51c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DishesInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "892aff320f6265335aaa0882c0ebd2b27cb4590b4069", async() => {
                WriteLiteral("\r\n    <meta charset=\'utf-8\'>\r\n    <title>Dishes!</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "892aff320f6265335aaa0882c0ebd2b27cb4590b4393", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "892aff320f6265335aaa0882c0ebd2b27cb4590b6583", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""box"">
            <div class=""col-sm-9 "" style=""background-color:lightgrey;"">
            <h1> Check out some recent dishes !</h1>
    <div class=""nav navbar-nav navbar-left""><p>
    <a href=""/chef"">Chefs |</a> Dish</p>
    </div>
    <div class=""nav navbar-nav navbar-right"">
    <a href=""/newDish"">Add a dish</a></div>
    <table class=""table table-striped"">
        <thead>
      <tr>
        <th>Dish Name</th>
        <th>Chef Name</th>
        <th>Tastiness</th>
        <th>Calories</th>
      </tr>
      </thead>
    <tbody>
    
");
#nullable restore
#line 40 "C:\DOJO\Csharp\Chef_N_Dishes\Views\Home\DishesInfo.cshtml"
      
        foreach(var x in Model){
            foreach(var y in x.DishList)
            
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n             <th>");
#nullable restore
#line 46 "C:\DOJO\Csharp\Chef_N_Dishes\Views\Home\DishesInfo.cshtml"
            Write(y.DishName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n              <th>  ");
#nullable restore
#line 47 "C:\DOJO\Csharp\Chef_N_Dishes\Views\Home\DishesInfo.cshtml"
               Write(x.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 47 "C:\DOJO\Csharp\Chef_N_Dishes\Views\Home\DishesInfo.cshtml"
                            Write(x.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n               <th> ");
#nullable restore
#line 48 "C:\DOJO\Csharp\Chef_N_Dishes\Views\Home\DishesInfo.cshtml"
               Write(y.Tastiness);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n               <th>");
#nullable restore
#line 49 "C:\DOJO\Csharp\Chef_N_Dishes\Views\Home\DishesInfo.cshtml"
              Write(y.Calories);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                </tr>\r\n");
#nullable restore
#line 51 "C:\DOJO\Csharp\Chef_N_Dishes\Views\Home\DishesInfo.cshtml"
                
            }
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n    </table>\r\n    <a href=\"/newDish\">Add a dish</a>\r\n    <a href=\"/newChef\">Add a Chef</a>\r\n    \r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591