#pragma checksum "C:\Users\99470\Desktop\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Genre\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38d745182073b0794daf2dd711568cf4a1b88ff2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Genre_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Genre/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\99470\Desktop\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38d745182073b0794daf2dd711568cf4a1b88ff2", @"/Areas/Manage/Views/Genre/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a27f8d6a14170253c1281d451c93248c211ffe87", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Genre_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\99470\Desktop\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Genre\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-10 mx-auto"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">Name</th>
                      
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 19 "C:\Users\99470\Desktop\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Genre\Index.cshtml"
                     foreach (var genre in Model)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 23 "C:\Users\99470\Desktop\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Genre\Index.cshtml"
                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\99470\Desktop\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Genre\Index.cshtml"
                           Write(genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           \r\n                        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\99470\Desktop\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Genre\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
