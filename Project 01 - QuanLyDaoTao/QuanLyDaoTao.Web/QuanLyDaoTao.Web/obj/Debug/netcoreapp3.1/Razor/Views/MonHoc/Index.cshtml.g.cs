#pragma checksum "F:\QuanLyDaoTao.Final\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\MonHoc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02bb38eb7e7fb6d8e7ce25332161b11236354db1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MonHoc_Index), @"mvc.1.0.view", @"/Views/MonHoc/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02bb38eb7e7fb6d8e7ce25332161b11236354db1", @"/Views/MonHoc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4127fd792eb740c22f9bf7e17bc0b0179fe27ad6", @"/Views/_ViewImports.cshtml")]
    public class Views_MonHoc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "null", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formLopHoc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "F:\QuanLyDaoTao.Final\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\MonHoc\Index.cshtml"
  
    ViewData["Title"] = "M??n h???c";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"toolbar\">\r\n    <div class=\"container\">\r\n        <h2>M??n h???c</h2>\r\n        <hr />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02bb38eb7e7fb6d8e7ce25332161b11236354db15383", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <label>M?? m??n</label>\r\n                    <select class=\"form-control\" id=\"search-id\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02bb38eb7e7fb6d8e7ce25332161b11236354db15856", async() => {
                    WriteLiteral("- T???t c??? - ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <label>M?? ch????ng tr??nh</label>\r\n                    <select class=\"form-control\" id=\"search-idCT\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02bb38eb7e7fb6d8e7ce25332161b11236354db17334", async() => {
                    WriteLiteral("- T???t c??? - ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            </div>
            <div class=""row d-flex justify-content-end"" style=""padding: 15px"">
                <a class=""btn btn-danger"" id=""btnSearch"">T??m ki???m</a>
                <a class=""btn btn-success"" id=""btnCreate"">
                    <i class=""fa fa-plus""></i>
                    <span>T???o m???i</span>
                </a>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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

<div class=""table--database"">
    <div class=""container"">
        <div class=""section--title"">
            <h3>DANH S??CH M??N H???C</h3>
        </div>
        <div class=""box-bordertop"">
            <table class=""table table-hover table-bordered""");
            BeginWriteAttribute("id", " id=\"", 1547, "\"", 1552, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>M?? CT</th>
                        <th>T??n CT</th>
                        <th>M?? m??n h???c</th>
                        <th>T??n m??n h???c</th>
                        <th>S??? gi???</th>
                        <th>Ch???c n??ng</th>
                    </tr>
                </thead>
                <tbody id=""table-body""></tbody>
            </table>
        </div>
    </div>
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modalLopHoc"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content container"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02bb38eb7e7fb6d8e7ce25332161b11236354db111092", async() => {
                WriteLiteral("\r\n                <h2 class=\"text-center m-2\">L???P H???C</h2>\r\n                <input id=\"hiddenvalue\" hidden type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2421, "\"", 2429, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <div class=""errorTxt"" id=""errorTxt""></div>
                <div class=""form-group"">
                    <label>M?? l???p</label>
                    <input class=""form-control"" id=""maLop"" name=""maLop"" />
                </div>
                <div class=""form-group"">
                    <label>ID ch????ng tr??nh</label>
                    <select class=""form-control"" id=""ctDaoTaoID"" name=""ctDaoTaoID"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02bb38eb7e7fb6d8e7ce25332161b11236354db112103", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                    <label>Ng??y khai gi???ng</label>
                    <input class=""form-control"" id=""ngayKhaiGiang"" name=""ngayKhaiGiang"" placeholder=""DD-MM-YYYY"" />
                    <button class=""btn btn-primary"" id=""checkdate1"">CHECK DATE</button>
                </div>
                <div class=""form-group"">
                    <label>Ng??y k???t th??c</label>
                    <input class=""form-control"" id=""ngayKetThuc"" name=""ngayKetThuc"" placeholder=""DD-MM-YYYY"" />
                    <button class=""btn btn-primary"" id=""checkdate2"">CHECK DATE</button>
                </div>
                <div class=""form-group"">
                    <label>S??? l?????ng h???c vi??n</label>
                    <input class=""form-control"" id=""soLuongHV"" name=""soLuongHV"" />
                </div>
                <div class=""form-group"">
                    <label>Quy???t ?????nh m??? l???p</label>
                    <div ");
                WriteLiteral(@"class=""file-info"" id=""file-info-1"">
                        <div class=""file-icon""><i class=""fa fa-file-word fa-2x""></i></div>
                        <div class=""file-content"">
                            <a class=""file-name"" id=""file-name-1""></a>
                        </div>
                    </div>
                    <div class=""custom-file"" id=""custom-file-1"">
                        <label for=""fileUpload1"">????nh k??m</label>
                        <input type=""file"" id=""fileUpload1"" name=""fileUpload1"" />
                    </div>
                </div>
                <div class=""form-group"">
                    <label>Th???i kh??a bi???u</label>
                    <div class=""file-info"" id=""file-info-2"">
                        <div class=""file-icon""><i class=""fa fa-file-word fa-2x""></i></div>
                        <div class=""file-content"">
                            <a class=""file-name"" id=""file-name-2""></a>
                        </div>
                    </div>
            ");
                WriteLiteral(@"        <div class=""custom-file"" id=""custom-file-2"">
                        <label for=""fileUpload2"">????nh k??m</label>
                        <input type=""file"" id=""fileUpload2"" name=""fileUpload2"" />
                    </div>
                </div>
                <div class=""form-group"">
                    <label>Ghi ch??</label>
                    <textarea class=""form-control"" id=""ghiChu"" name=""ghiChu"" rows=""3""></textarea>
                </div>
                <div class=""form-group"">
                    <button type=""button"" class=""btn btn-primary"" id=""btnSubmit"">L??u l???i</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">????ng</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
                <h4 class=""modal-title"">Th??ng b??o</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"" id=""notiMessenger""></div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-success"" id=""btnConfirm"">X??c nh???n</button>
                <button type=""button"" class=""btn btn-danger"" id=""btnClose"" data-dismiss=""modal"">????ng l???i</button>
            </div>
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
            url: '/MonHoc/DanhSach',
            type: 'GET',
            data: {
                id: null,
                ctDaoTaoID: null,
            },
            success: function (data) {
                if (data.code == 200) {
                    let stt = 0;
                    $.each(data.monhoc, function (key, value) {
                        stt = stt + 1;
                        let tr = '<tr id=""' + value.id + '"">';
                        tr += '<td>' + stt + '</td>';
                        tr += '<td>' + value.maCT + '</td>';
                        tr += '<td>' + value.tenCT + '</td>';
                        tr += '<td>' + value.maMonHoc + '</td>';
                        tr += '<td>' + value.tenMonHoc + '</td>';
                        tr += '<td>' + value.soGio + '</td>';
                        tr += '<td>'
                        tr +");
                WriteLiteral(@"= '<button class=""btn btn-sm btn-info"" id=""btnEdit"" name=""edit""><i class=""fa fa-info-circle""></i></button>';
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
