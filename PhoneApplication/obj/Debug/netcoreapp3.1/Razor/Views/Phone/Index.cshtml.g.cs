#pragma checksum "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bc7117861a8488a1c0410c007a0cea4283d0d9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phone_Index), @"mvc.1.0.view", @"/Views/Phone/Index.cshtml")]
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
#line 1 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\_ViewImports.cshtml"
using PhoneApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\_ViewImports.cshtml"
using PhoneApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc7117861a8488a1c0410c007a0cea4283d0d9b", @"/Views/Phone/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd9768cf0ecf4274ac6298a6db8438e0a8cd3c4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Phone_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PhoneApplication.Models.Phone>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 10 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 15 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 18 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Manufacturer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 21 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.MSRP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 24 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ScreenSize));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 27 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.DateReleased));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Manufacturer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MSRP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ScreenSize));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateReleased));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.PhoneID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 52 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.PhoneID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 53 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.PhoneID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Owner\source\repos\PhoneApplication\PhoneApplication\Views\Phone\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PhoneApplication.Models.Phone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
