#pragma checksum "C:\Users\Asaf\source\repos\KodluyoruzBursaDotnet\DotnetMVCBaslangic\DotnetMVCBaslangic\Views\Ogrenci\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9903d37e12c9fac1b4940e1271cc03cfa618c5ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ogrenci_Index), @"mvc.1.0.view", @"/Views/Ogrenci/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ogrenci/Index.cshtml", typeof(AspNetCore.Views_Ogrenci_Index))]
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
#line 1 "C:\Users\Asaf\source\repos\KodluyoruzBursaDotnet\DotnetMVCBaslangic\DotnetMVCBaslangic\Views\_ViewImports.cshtml"
using DotnetMVCBaslangic;

#line default
#line hidden
#line 1 "C:\Users\Asaf\source\repos\KodluyoruzBursaDotnet\DotnetMVCBaslangic\DotnetMVCBaslangic\Views\Ogrenci\Index.cshtml"
using DotnetMVCBaslangic.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9903d37e12c9fac1b4940e1271cc03cfa618c5ea", @"/Views/Ogrenci/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ff906ba7e13d527d181c8d6d689c793e316821e", @"/Views/_ViewImports.cshtml")]
    public class Views_Ogrenci_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ogrenci>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Asaf\source\repos\KodluyoruzBursaDotnet\DotnetMVCBaslangic\DotnetMVCBaslangic\Views\Ogrenci\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(104, 24, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n<ul>\r\n");
            EndContext();
#line 9 "C:\Users\Asaf\source\repos\KodluyoruzBursaDotnet\DotnetMVCBaslangic\DotnetMVCBaslangic\Views\Ogrenci\Index.cshtml"
     foreach (Ogrenci item in Model)
    {

#line default
#line hidden
            BeginContext(173, 17, true);
            WriteLiteral("        <li>Adi: ");
            EndContext();
            BeginContext(191, 8, false);
#line 11 "C:\Users\Asaf\source\repos\KodluyoruzBursaDotnet\DotnetMVCBaslangic\DotnetMVCBaslangic\Views\Ogrenci\Index.cshtml"
            Write(item.Adi);

#line default
#line hidden
            EndContext();
            BeginContext(199, 9, true);
            WriteLiteral(" Soyadi: ");
            EndContext();
            BeginContext(209, 11, false);
#line 11 "C:\Users\Asaf\source\repos\KodluyoruzBursaDotnet\DotnetMVCBaslangic\DotnetMVCBaslangic\Views\Ogrenci\Index.cshtml"
                              Write(item.Soyadi);

#line default
#line hidden
            EndContext();
            BeginContext(220, 13, true);
            WriteLiteral(" Ogrenci No: ");
            EndContext();
            BeginContext(234, 14, false);
#line 11 "C:\Users\Asaf\source\repos\KodluyoruzBursaDotnet\DotnetMVCBaslangic\DotnetMVCBaslangic\Views\Ogrenci\Index.cshtml"
                                                       Write(item.OgrenciNo);

#line default
#line hidden
            EndContext();
            BeginContext(248, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 12 "C:\Users\Asaf\source\repos\KodluyoruzBursaDotnet\DotnetMVCBaslangic\DotnetMVCBaslangic\Views\Ogrenci\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(262, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ogrenci>> Html { get; private set; }
    }
}
#pragma warning restore 1591