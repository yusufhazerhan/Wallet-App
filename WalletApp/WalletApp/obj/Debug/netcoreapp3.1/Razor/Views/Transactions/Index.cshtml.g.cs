#pragma checksum "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c99d31a1e52b7d9638d23012b6da892aa2fb7eab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transactions_Index), @"mvc.1.0.view", @"/Views/Transactions/Index.cshtml")]
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
#line 1 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\_ViewImports.cshtml"
using WalletApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
using WalletApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99d31a1e52b7d9638d23012b6da892aa2fb7eab", @"/Views/Transactions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"641812f1fb94090242ad7923a50bbde2300c4b63", @"/Views/_ViewImports.cshtml")]
    public class Views_Transactions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Transaction>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
  
    ViewData["Title"] = localizer["Index"];
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<table class=\"table table-borderless\">\r\n    <tr>\r\n        <th>");
#nullable restore
#line 12 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
       Write(localizer["Id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 13 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
       Write(localizer["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 14 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
       Write(localizer["Type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 15 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
       Write(localizer["Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 16 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
       Write(localizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 17 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
       Write(localizer["Update"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <tr>\r\n    <td>");
#nullable restore
#line 21 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
   Write(x.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    <td>");
#nullable restore
#line 22 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
   Write(x.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    <td>");
#nullable restore
#line 23 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
   Write(x.type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
   Write(x.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 662, "\"", 706, 2);
            WriteAttributeValue("", 669, "/Transactions/DetailTransaction/", 669, 32, true);
#nullable restore
#line 25 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
WriteAttributeValue("", 701, x.Id, 701, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">");
#nullable restore
#line 25 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
                                                                           Write(localizer["Update"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 773, "\"", 817, 2);
            WriteAttributeValue("", 780, "/Transactions/DeleteTransaction/", 780, 32, true);
#nullable restore
#line 26 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
WriteAttributeValue("", 812, x.Id, 812, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">");
#nullable restore
#line 26 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
                                                                          Write(localizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n</tr>");
#nullable restore
#line 27 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Transactions/NewTransaction\" class=\"btn btn-primary\">");
#nullable restore
#line 29 "C:\Users\Yusuf\source\repos\WalletApp\WalletApp\Views\Transactions\Index.cshtml"
                                                          Write(localizer["Add new Transaction"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
