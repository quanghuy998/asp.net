#pragma checksum "F:\TuongLeHoi\TuongLeHoi\Areas\Admin\Views\ThuocTinh\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53e79af22f40665bd237b8ab1081843e0eff3696"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ThuocTinh_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ThuocTinh/Index.cshtml")]
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
#line 1 "F:\TuongLeHoi\TuongLeHoi\Areas\Admin\Views\_ViewImports.cshtml"
using TuongLeHoi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\TuongLeHoi\TuongLeHoi\Areas\Admin\Views\_ViewImports.cshtml"
using TuongLeHoi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53e79af22f40665bd237b8ab1081843e0eff3696", @"/Areas/Admin/Views/ThuocTinh/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637b12cab491273c85147eb105d7ab28d0b21296", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ThuocTinh_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\TuongLeHoi\TuongLeHoi\Areas\Admin\Views\ThuocTinh\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""section--title"">
    <h3>DANH SÁCH THUỘC TÍNH</h3>
</div>
<div class=""box-bordertop"">
    <div class=""row justify-content-end"">
        <a class=""p-2 bg-success text-white"" id=""btnCreate"">
            <i class=""fa fa-plus""></i>
            <span>Thêm mới</span>
        </a>
    </div>
    <table class=""table table-hover table-bordered"">
        <thead>
            <tr>
                <th class=""text-center"">STT</th>
                <th class=""text-center"">Tên nhóm</th>
                <th class=""text-center"">Tên thuộc tính</th>
                <th class=""text-center"">Kiểu dữ liệu</th>
                <th class=""text-center"">Mô tả</th>
                <th class=""text-center"">Chức năng</th>
            </tr>
        </thead>
        <tbody id=""table-body""></tbody>
    </table>
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content container"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53e79af22f40665bd237b8ab1081843e0eff36966044", async() => {
                WriteLiteral("\r\n                <h2 class=\"text-center m-2\">THUỘC TÍNH</h2>\r\n                <input id=\"hiddenvalue\" hidden type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1284, "\"", 1292, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <div class=""errorTxt"" id=""errorTxt""></div>
                <div class=""form-group"">
                    <label class=""control-label"">Nhóm thuộc tính</label>
                    <select class=""form-control"" id=""maNhom"" name=""maNhom"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53e79af22f40665bd237b8ab1081843e0eff36966880", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group"">
                    <label class=""control-label"">Tên thuộc tính</label>
                    <input class=""form-control"" id=""tenThuocTinh"" name=""tenThuocTinh"" />
                </div>
             
                <div class=""form-group"">
                    <label class=""control-label"">Kiểu dữ liệu</label>
                    <select class=""form-control"" id=""kieuDuLieu"" name=""kieuDuLieu"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53e79af22f40665bd237b8ab1081843e0eff36968476", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group"">
                    <label class=""control-label"">Mô tả</label>
                    <textarea class=""form-control"" rows=""3"" id=""moTa"" name=""moTa""></textarea>
                </div>
                <div class=""form-group"">
                    <button type=""button"" class=""btn btn-success"" id=""btnSubmit"">Lưu lại</button>
                    <button type=""button"" class=""btn btn-danger"" id=""btnClose"" data-dismiss=""modal"">Đóng</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<div class=""modal fade"" id=""notification"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Thông báo</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"" id=""notiMessenger""></div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-success"" id=""btnConfirm"">Xác nhận</button>
                <button type=""button"" class=""btn btn-danger"" id=""btnClose"" data-dismiss=""modal"">Đóng lại</button>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            LoadDataList();
            NhomThuocTinhData();
            KieuDuLieuData();
        });
        function LoadDataList() {
            $.ajax({
                url: '/Admin/ThuocTinh/DanhSach',
                type: 'GET',
                success: function (data) {
                    if (data.code == 200) {
                        let stt = 0;
                        $.each(data.danhsach, function (key, value) {
                            stt = stt + 1;
                            let tr = '<tr id=""' + value.id + '"">';
                            tr += '<td class=""text-center"">' + stt + '</td>';
                            tr += '<td>' + value.tenNhom + '</td>';
                            tr += '<td>' + value.tenThuocTinh + '</td>';
                            tr += '<td class=""text-center"">' + value.tenKieuDuLieu + '</td>';
                            if (value.moTa == null) { tr += '<td>' + """" + '</td>'; }
         ");
                WriteLiteral(@"                   else { tr += '<td>' + value.moTa + '</td>'; };
                            tr += '<td class=""text-center"">'
                            tr += '<a id=""btnEdit""><i class=""fa fa-edit text-primary mr-2""></i></a>';
                            tr += '<a id=""btnDelete""><i class=""fa fa-trash text-danger""></i></a>';
                            tr += '</td>'
                            tr += '</tr>'
                            $('#table-body').append(tr);
                        });
                    }
                }
            });
        };
        function ThongBao(messenger) {
            $(""#notiMessenger"").empty();
            $(""#notiMessenger"").append(messenger);
            $(""#btnConfirm"").hide();
            $(""#notification"").modal();
        };
        function ResetForm() {
            $(""#maNhom"").val('');
            $(""#tenThuocTinh"").val('');
            $(""#kieuDuLieu"").val('');
            $(""#moTa"").val('');
        };
        function NhomThuocTinhD");
                WriteLiteral(@"ata() {
            $.ajax({
                url: '/Admin/NhomThuocTinh/DanhSach',
                type: 'GET',
                success: function (data) {
                    if (data.code === 200) {
                        $.each(data.danhsach, function (key, value) {
                            let option = '<option  value=""' + value.id + '"" class=""form-control"">' + value.tenNhom + '</option>';
                            $('#maNhom').append(option);
                        });
                    }
                }
            })
        };
        function KieuDuLieuData() {
            $.ajax({
                url: '/Admin/KieuDuLieu/DanhSach',
                type: 'GET',
                success: function (data) {
                    if (data.code === 200) {
                        $.each(data.danhsach, function (key, value) {
                            let option = '<option  value=""' + value.id + '"" class=""form-control"">' + value.tenKieuDuLieu + '</option>';
                    ");
                WriteLiteral(@"        $('#kieuDuLieu').append(option);
                        });
                    }
                }
            })
        };

        $('#btnSubmit').click(function () {
            let hiddenvalue = $('#hiddenvalue').val();

            let maNhom = $('#maNhom').val().trim();
            let tenThuocTinh = $('#tenThuocTinh').val().trim();
            let kieuDuLieu = $('#kieuDuLieu').val().trim();
            let moTa = $('#moTa').val().trim();

            let formData1 = new FormData();
            formData1.append('maNhom', maNhom);
            formData1.append('tenThuocTinh', tenThuocTinh);
            formData1.append('kieuDuLieu', kieuDuLieu);
            formData1.append('moTa', moTa);

            let formData2 = new FormData();
            formData2 = formData1;
            formData2.append('id', hiddenvalue);

            if ($(""#form"").valid()) {
                if (hiddenvalue.length == 0) {
                    //Thêm mới
                    $.ajax({
       ");
                WriteLiteral(@"                 url: '/Admin/ThuocTinh/TaoMoi',
                        type: 'post',
                        data: formData1,
                        contentType: false,
                        processData: false,
                        success: function (data) {
                            if (data.code == 200) {
                                ResetForm();
                                $('#table-body').empty();
                                $('#btnClose').click();
                                ThongBao(data.msg);
                                LoadDataList();
                            } else {
                                $('#btnClose').click();
                                ThongBao(data.msg);
                            }
                        }
                    });
                }
                else if (hiddenvalue.length != 0) {
                    //Chỉnh sửa
                    $.ajax({
                        url: '/Admin/ThuocTinh/ChinhSua',
         ");
                WriteLiteral(@"               type: 'PUT',
                        data: formData2,
                        contentType: false,
                        processData: false,
                        success: function (data) {
                            if (data.code == 200) {
                                $('#table-body').empty();
                                $('#btnClose').click();
                                ThongBao(data.msg);
                                LoadDataList();
                            } else {
                                $('#btnClose').click();
                                ThongBao(data.msg);
                            }
                        }
                    })
                }
            }


        });
        $(document).on('click', ""a[id='btnCreate']"", function () {
            $('#hiddenvalue').val(''); // Hidden id
            $(""#modal"").modal();
            ResetForm();
        });
        $(document).on('click', ""a[id='btnEdit']"", function () {
                WriteLiteral(@"
            let id = $(this).closest('tr').attr('id');
            $('#hiddenvalue').val(id);
            ResetForm();

            $.ajax({
                url: '/Admin/ThuocTinh/LayID',
                type: 'GET',
                data: { id: id },
                success: function (data) {
                    console.log(data);
                    $('#maNhom').val(data.data.maNhom);
                    $('#tenThuocTinh').val(data.data.tenThuocTinh);
                    $('#kieuDuLieu').val(data.data.kieuDuLieu);
                    $('#moTa').val(data.data.moTa);
                    $(""#modal"").modal();
                }
            });
        });
        $(document).on('click', ""a[id='btnDelete']"", function () {
            let id = $(this).closest('tr').attr('id');
            var noti = confirm(""Bạn có muốn xóa không?"");
            if (noti == true) {
                $.ajax({
                    url: '/Admin/ThuocTinh/XoaBo',
                    type: 'delete',
              ");
                WriteLiteral(@"      data: { id: id },
                    success: function (data) {
                        if (data.code === 200) {
                            $('#table-body').empty();
                            LoadDataList();
                            ThongBao(data.msg);
                        }
                        else ThongBao(data.msg);
                    }
                })
            } else {
                alert(""You pressed Cancel!"");
            }
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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