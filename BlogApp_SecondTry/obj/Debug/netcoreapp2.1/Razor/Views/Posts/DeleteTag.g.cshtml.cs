#pragma checksum "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\DeleteTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee56d64095657f62ac07468b925d2408cd91aced"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_DeleteTag), @"mvc.1.0.view", @"/Views/Posts/DeleteTag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/DeleteTag.cshtml", typeof(AspNetCore.Views_Posts_DeleteTag))]
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
#line 1 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\DeleteTag.cshtml"
using BlogApp_SecondTry.BdModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee56d64095657f62ac07468b925d2408cd91aced", @"/Views/Posts/DeleteTag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"891c782deb5f3ac37b0057952bc2c1f05cf19410", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_DeleteTag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostTag>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\DeleteTag.cshtml"
  
    ViewData["Title"] = "DeleteTag";

#line default
#line hidden
            BeginContext(97, 48, true);
            WriteLiteral("\r\n<h4>DeleteTag</h4>\r\n<p>Are you shure?</p>\r\n<p>");
            EndContext();
            BeginContext(146, 19, false);
#line 9 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\DeleteTag.cshtml"
Write(ViewBag.Tag.TextTag);

#line default
#line hidden
            EndContext();
            BeginContext(165, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
            BeginContext(173, 418, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "409cbd3327dd4bc29c0c72cbcdbe403b", async() => {
                BeginContext(202, 26, true);
                WriteLiteral("\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 228, "\"", 252, 1);
#line 12 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\DeleteTag.cshtml"
WriteAttributeValue("", 236, ViewBag.Post.Id, 236, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(253, 43, true);
                WriteLiteral(" name=\"PostId\" />\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 296, "\"", 317, 1);
#line 13 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\DeleteTag.cshtml"
WriteAttributeValue("", 304, ViewBag.Post, 304, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(318, 43, true);
                WriteLiteral(" name=\"Post\" />\r\n\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 361, "\"", 384, 1);
#line 15 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\DeleteTag.cshtml"
WriteAttributeValue("", 369, ViewBag.Tag.Id, 369, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(385, 42, true);
                WriteLiteral(" name=\"TagId\" />\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 427, "\"", 447, 1);
#line 16 "D:\Проекты\Программирование\Git\TestBlog\BlogApp_SecondTry\Views\Posts\DeleteTag.cshtml"
WriteAttributeValue("", 435, ViewBag.Tag, 435, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(448, 96, true);
                WriteLiteral(" name=\"Tag\" />\r\n\r\n\r\n    <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n\r\n    ");
                EndContext();
                BeginContext(544, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e28b8e061746479b9b2f589bf6b9c321", async() => {
                    BeginContext(566, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(582, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
