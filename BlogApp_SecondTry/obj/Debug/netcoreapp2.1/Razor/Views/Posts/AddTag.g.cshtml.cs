#pragma checksum "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\AddTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ed9f14efb6f6c0a720a7e8fffafc832ec2430d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_AddTag), @"mvc.1.0.view", @"/Views/Posts/AddTag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/AddTag.cshtml", typeof(AspNetCore.Views_Posts_AddTag))]
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
#line 1 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\_ViewImports.cshtml"
using BlogApp_SecondTry;

#line default
#line hidden
#line 2 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\_ViewImports.cshtml"
using BlogApp_SecondTry.Models;

#line default
#line hidden
#line 1 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\AddTag.cshtml"
using BlogApp_SecondTry.BdModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ed9f14efb6f6c0a720a7e8fffafc832ec2430d1", @"/Views/Posts/AddTag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"891c782deb5f3ac37b0057952bc2c1f05cf19410", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_AddTag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostTag>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\AddTag.cshtml"
  
    ViewData["Title"] = "AddTag";

#line default
#line hidden
            BeginContext(96, 21, true);
            WriteLiteral("\r\n<h2>AddTag</h2>\r\n\r\n");
            EndContext();
            BeginContext(117, 374, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad8b4d7d37894308b44af12cb2c43f80", async() => {
                BeginContext(143, 26, true);
                WriteLiteral("\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 169, "\"", 193, 1);
#line 11 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\AddTag.cshtml"
WriteAttributeValue("", 177, ViewBag.Post.Id, 177, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(194, 43, true);
                WriteLiteral(" name=\"PostId\" />\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 237, "\"", 258, 1);
#line 12 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\AddTag.cshtml"
WriteAttributeValue("", 245, ViewBag.Post, 245, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(259, 74, true);
                WriteLiteral(" name=\"Post\" />\r\n \r\n     <p>\r\n        \"Тэг: \"\r\n    </p>\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(334, 70, false);
#line 18 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\AddTag.cshtml"
   Write(Html.DropDownListFor(model => model.TagId, ViewBag.Tags as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(404, 80, true);
                WriteLiteral("\r\n    </p>\r\n    <p>\r\n        <input type=\"submit\" value=\"Add Tag\" />\r\n    </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(491, 15, true);
            WriteLiteral("\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(507, 45, false);
#line 26 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\AddTag.cshtml"
Write(Html.ActionLink("К списку постов: ", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(552, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostTag> Html { get; private set; }
    }
}
#pragma warning restore 1591
