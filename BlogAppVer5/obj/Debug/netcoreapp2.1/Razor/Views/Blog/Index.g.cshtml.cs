#pragma checksum "D:\Apps\BlogApp\BlogAppVer5\BlogAppVer5\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3534e1259d990aec2012f937ed4005c85e92b403"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Index.cshtml", typeof(AspNetCore.Views_Blog_Index))]
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
#line 1 "D:\Apps\BlogApp\BlogAppVer5\BlogAppVer5\Views\_ViewImports.cshtml"
using BlogAppVer5;

#line default
#line hidden
#line 2 "D:\Apps\BlogApp\BlogAppVer5\BlogAppVer5\Views\_ViewImports.cshtml"
using BlogAppVer5.Models;

#line default
#line hidden
#line 1 "D:\Apps\BlogApp\BlogAppVer5\BlogAppVer5\Views\Blog\Index.cshtml"
using BlogAppVer5.BdModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3534e1259d990aec2012f937ed4005c85e92b403", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebb031904dcded95120d4ec5be9dff37e8c09567", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 5, false);
#line 2 "D:\Apps\BlogApp\BlogAppVer5\BlogAppVer5\Views\Blog\Index.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(35, 23, true);
            WriteLiteral("= IEnumerable<Post>\r\n\r\n");
            EndContext();
#line 4 "D:\Apps\BlogApp\BlogAppVer5\BlogAppVer5\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Тут представление статей";

#line default
#line hidden
            BeginContext(118, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 9 "D:\Apps\BlogApp\BlogAppVer5\BlogAppVer5\Views\Blog\Index.cshtml"
 foreach (Post post in Model)
{

#line default
#line hidden
            BeginContext(156, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(165, 10, false);
#line 11 "D:\Apps\BlogApp\BlogAppVer5\BlogAppVer5\Views\Blog\Index.cshtml"
   Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(175, 16, true);
            WriteLiteral("</h2>\r\n    <div>");
            EndContext();
            BeginContext(192, 9, false);
#line 12 "D:\Apps\BlogApp\BlogAppVer5\BlogAppVer5\Views\Blog\Index.cshtml"
    Write(post.Body);

#line default
#line hidden
            EndContext();
            BeginContext(201, 39, true);
            WriteLiteral("</div>\r\n    <div>\r\n      \r\n    </div>\r\n");
            EndContext();
#line 16 "D:\Apps\BlogApp\BlogAppVer5\BlogAppVer5\Views\Blog\Index.cshtml"

}

#line default
#line hidden
            BeginContext(245, 22, true);
            WriteLiteral("\r\n\r\n<h2>Index</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591