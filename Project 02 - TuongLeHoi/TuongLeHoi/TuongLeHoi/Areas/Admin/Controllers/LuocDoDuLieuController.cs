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
    public class LuocDoDuLieuController : Controller
    {
        private readonly ILuocDoDuLieuService _luocDoDuLieuService;
        public LuocDoDuLieuController(ILuocDoDuLieuService luocDoDuLieuService)
        {
            _luocDoDuLieuService = luocDoDuLieuService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult DanhSach()
        {
            List<LuocDoDuLieuResponse> danhsach = _luocDoDuLieuService.LuocDoDuLieuDanhSach();
            return Json(new { code = 200, msg = "Thanh cong", danhsach = danhsach });
        }
        [HttpGet]
        public JsonResult LayID(int id)
        {
            LuocDoDuLieuResponse data = _luocDoDuLieuService.LuocDoDuLieuLayID(id);
            return Json(new { code = 200, msg = "Lấy thông tin thành công", data = data });
        }

        public JsonResult ChinhSua(LuocDoDuLieuRequest request)
        {
            string result = _luocDoDuLieuService.LuocDoDuLieuChinhSua(request);
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

        public JsonResult TaoMoi(LuocDoDuLieuRequest request)
        {
            string result = _luocDoDuLieuService.LuocDoDuLieuTaoMoi(request);
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
            bool result = _luocDoDuLieuService.LuocDoDuLieuXoaBo(id);
            if (result == true)
            {
                return Json(new { code = 200, msg = "Xoá bỏ thành công" });
            }
            else return Json(new { code = 500, msg = "Xoá bỏ thất bại" });

        }
    }
}
