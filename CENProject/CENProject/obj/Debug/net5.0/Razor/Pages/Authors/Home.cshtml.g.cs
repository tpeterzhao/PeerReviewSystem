#pragma checksum "C:\Users\tpete\Desktop\Project\CENProject\CENProject\Pages\Authors\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82b31fec96c33265944dda44709a81baae6458b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CENProject.Pages.Authors.Pages_Authors_Home), @"mvc.1.0.razor-page", @"/Pages/Authors/Home.cshtml")]
namespace CENProject.Pages.Authors
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
#line 1 "C:\Users\tpete\Desktop\Project\CENProject\CENProject\Pages\_ViewImports.cshtml"
using CENProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82b31fec96c33265944dda44709a81baae6458b7", @"/Pages/Authors/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e874572d9a5bb13fc1ea58d7ded042102793ac6b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Authors_Home : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
    <div class=""navbar"">
        <button type=""button"" class=""header-button"">Home</button>
        <button type=""button"" class=""header-button"">New Paper</button>
        <button type=""button"" class=""header-button"">My Paper</button>
        <button type=""button"" class=""header-button"">My Account</button>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CENProject.Pages.Authors.HomeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CENProject.Pages.Authors.HomeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CENProject.Pages.Authors.HomeModel>)PageContext?.ViewData;
        public CENProject.Pages.Authors.HomeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
