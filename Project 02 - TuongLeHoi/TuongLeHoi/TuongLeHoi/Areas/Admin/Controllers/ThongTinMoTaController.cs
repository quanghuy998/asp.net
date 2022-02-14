using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuongLeHoi.BAL.Interface;
using TuongLeHoiDomain.Request;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ThongTinMoTaController : Controller
    {
        private readonly IThongTinMoTaService _thongTinMoTaService;
        public ThongTinMoTaController(IThongTinMoTaService thongTinMoTaService)
        {
            _thongTinMoTaService = thongTinMoTaService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult DanhSach()
        {
            List<ThongTinMoTaResponse> danhsach = _thongTinMoTaService.ThongTinMoTaDanhSach();
            return Json(new { code = 200, msg = "Thanh cong", danhsach = danhsach });
        }
        [HttpGet]
        public JsonResult LayID(int id)
        {
            ThongTinMoTaResponse data = _thongTinMoTaService.ThongTinMoTaLayID(id);
            return Json(new { code = 200, msg = "Lấy thông tin thành công", data = data });
        }

        public JsonResult ChinhSua(ThongTinMoTaRequest request)
        {
            string result = _thongTinMoTaService.ThongTinMoTaChinhSua(request);
            if (result == "Success")
            {
                return Json(new { code = 200, msg = "Chỉnh sửa thành công" });
            }
            else if (result == "Failure")
            {
                return Json(new { code = 500, msg = "Chỉnh sửa thất bại" });
            }
            else return Json(new { code = 600, msg = "Chỉnh sửa thất bại: " + result });
        }

        public JsonResult TaoMoi(ThongTinMoTaRequest request)
        {
            string result = _thongTinMoTaService.ThongTinMoTaTaoMoi(request);
            if (result == "Success")
            {
                return Json(new { code = 200, msg = "Tạo mới thành công" });
            }
            else if (result == "Failure")
            {
                return Json(new { code = 500, msg = "Tạo mới thất bại" });
            }
            else return Json(new { code = 600, msg = "Tạo mới thất bại: " + result });

        }

        public JsonResult XoaBo(int id)
        {
            bool result = _thongTinMoTaService.ThongTinMoTaXoaBo(id);
            if (result == true)
            {
                return Json(new { code = 200, msg = "Xoá bỏ thành công" });
            }
            else return Json(new { code = 500, msg = "Xoá bỏ thất bại" });
        }
    }
}
