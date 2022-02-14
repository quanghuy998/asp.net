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
    public class TuLieuController : Controller
    {
        private readonly ITuLieuService _tuLieuService;
        public TuLieuController(ITuLieuService tuLieuService)
        {
            _tuLieuService = tuLieuService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult DanhSach(Guid id)
        {
            List<TuLieuResponse> danhsach = _tuLieuService.TuLieuDanhSach(id);
            return Json(new { code = 200, msg = "Thanh cong", danhsach = danhsach });
        }
        [HttpGet]
        public JsonResult LayID(Guid id)
        {
            TuLieuResponse data = _tuLieuService.TuLieuLayID(id);
            return Json(new { code = 200, msg = "Lấy thông tin thành công", data = data });
        }

        public JsonResult ChinhSua(TuLieuRequest request)
        {
            string result = _tuLieuService.TuLieuChinhSua(request);
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

        public JsonResult TaoMoi(TuLieuRequest request)
        {
            string result = _tuLieuService.TuLieuTaoMoi(request);
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

        public JsonResult XoaBo(Guid id)
        {
            bool result = _tuLieuService.TuLieuXoaBo(id);
            if (result == true)
            {
                return Json(new { code = 200, msg = "Xoá bỏ thành công" });
            }
            else return Json(new { code = 500, msg = "Xoá bỏ thất bại" });

        }
    }
}
