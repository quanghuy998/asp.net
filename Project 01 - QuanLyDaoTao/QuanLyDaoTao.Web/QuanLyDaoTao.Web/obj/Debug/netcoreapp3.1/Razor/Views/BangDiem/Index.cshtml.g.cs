#pragma checksum "F:\QuanLyDaoTao.Final\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\BangDiem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bfb632e4c859b5a4604a43fbd686fe239344c7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BangDiem_Index), @"mvc.1.0.view", @"/Views/BangDiem/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bfb632e4c859b5a4604a43fbd686fe239344c7a", @"/Views/BangDiem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4127fd792eb740c22f9bf7e17bc0b0179fe27ad6", @"/Views/_ViewImports.cshtml")]
    public class Views_BangDiem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\QuanLyDaoTao.Final\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\BangDiem\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table--database\">\r\n    <div class=\"container\">\r\n        <div class=\"section--title\">\r\n            <h3>DANH S??CH B???NG ??I???M</h3>\r\n        </div>\r\n        <div class=\"box-bordertop\">\r\n            <table class=\"table table-hover table-bordered\"");
            BeginWriteAttribute("id", " id=\"", 344, "\"", 349, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>M?? CT</th>
                        <th>M?? l???p</th>
                        <th>H??? t??n</th>
                        <th>M?? m??n h???c</th>
                        <th>T??n m??n h???c</th>
                        <th>??i???m thi</th>
                        <th>L???n thi</th>
                        <th>Ch???c n??ng</th>
                    </tr>
                </thead>
                <tbody id=""table-body""></tbody>
            </table>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
    $(document).ready(function () {
        LoadClassList();
    })

    function LoadClassList() {
        $.ajax({
            url: '/BangDiem/DanhSach',
            type: 'GET',
            data: {
                ctDaoTaoID: null,
                lopHocID: null,
                hocVienID: null,
                monHocID: null
            },
            success: function (data) {
                if (data.code == 200) {
                    let stt = 0;
                    $.each(data.bangdiem, function (key, value) {
                        stt = stt + 1;
                        let tr = '<tr id=""' + value.id + '"">';
                        tr += '<td>' + stt + '</td>';
                        tr += '<td>' + value.maCT + '</td>';
                        tr += '<td>' + value.maLop + '</td>';
                        tr += '<td>' + value.hoTen + '</td>';
                        tr += '<td>' + value.maMonHoc + '</td>';
                        tr += '<td>' + value.tenMonHo");
                WriteLiteral(@"c + '</td>';
                        tr += '<td>' + value.diemThi + '</td>';
                        tr += '<td>' + value.lanThi + '</td>';
                        tr += '<td>'
                        tr += '<button class=""btn btn-sm btn-info"" id=""btnEdit"" name=""edit""><i class=""fa fa-info-circle""></i></button>';
                        tr += '<button class=""btn btn-sm btn-danger"" id=""btnDelete"" name=""delete""><i class=""fa fa-trash""></i></button>';
                        tr += '</td>'
                        tr += '</tr>'
                        $('#table-body').append(tr);
                    });
                }
            }
        });
    }
    </script>
");
            }
            );
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
