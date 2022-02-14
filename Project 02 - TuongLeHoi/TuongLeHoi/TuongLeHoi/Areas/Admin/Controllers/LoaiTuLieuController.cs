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
    public class LoaiTuLieuController : Controller
    {
        private readonly ILoaiTuLieuService _loaiTuLieuService;
        public LoaiTuLieuController(ILoaiTuLieuService loaiTuLieuService)
        {
            _loaiTuLieuService = loaiTuLieuService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult DanhSach()
        {
            List<LoaiTuLieuResponse> danhsach = _loaiTuLieuService.LoaiTuLieuDanhSach();
            return Json(new { code = 200, msg = "Thanh cong", danhsach = danhsach });
        }
        [HttpGet]
        public JsonResult LayID(Guid id)
        {
            LoaiTuLieuResponse data = _loaiTuLieuService.LoaiTuLieuLayID(id);
            return Json(new { code = 200, msg = "Lấy thông tin thành công", data = data });
        }

        public JsonResult ChinhSua(LoaiTuLieuRequest request)
        {
            string result = _loaiTuLieuService.LoaiTuLieuChinhSua(request);
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

        public JsonResult TaoMoi(LoaiTuLieuRequest request)
        {
            string result = _loaiTuLieuService.LoaiTuLieuTaoMoi(request);
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
            bool result = _loaiTuLieuService.LoaiTuLieuXoaBo(id);
            if (result == true)
            {
                return Json(new { code = 200, msg = "Xoá bỏ thành công" });
            }
            else return Json(new { code = 500, msg = "Xoá bỏ thất bại" });

        }
    }
}
