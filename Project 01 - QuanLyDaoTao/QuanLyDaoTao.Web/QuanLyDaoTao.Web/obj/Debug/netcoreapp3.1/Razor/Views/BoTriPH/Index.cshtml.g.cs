#pragma checksum "F:\QuanLyDaoTao.Final\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\BoTriPH\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15242298ca6426942cb29be19a9b4e019d7ae4d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BoTriPH_Index), @"mvc.1.0.view", @"/Views/BoTriPH/Index.cshtml")]
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
#line 1 "F:\QuanLyDaoTao.Final\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\_ViewImports.cshtml"
using QuanLyDaoTao.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\QuanLyDaoTao.Final\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\_ViewImports.cshtml"
using QuanLyDaoTao.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15242298ca6426942cb29be19a9b4e019d7ae4d2", @"/Views/BoTriPH/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4127fd792eb740c22f9bf7e17bc0b0179fe27ad6", @"/Views/_ViewImports.cshtml")]
    public class Views_BoTriPH_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\QuanLyDaoTao.Final\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\BoTriPH\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table--database"">
    <div class=""container"">
        <div class=""section--title"">
            <h3>DANH SÁCH BỐ TRÍ PHÒNG HỌC</h3>
        </div>
        <div class=""box-bordertop"">
            <table class=""table table-hover table-bordered""");
            BeginWriteAttribute("id", " id=\"", 472, "\"", 477, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>Chức năng</th>
                    </tr>
                </thead>
                <tbody id=""table-body""></tbody>
            </table>
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
