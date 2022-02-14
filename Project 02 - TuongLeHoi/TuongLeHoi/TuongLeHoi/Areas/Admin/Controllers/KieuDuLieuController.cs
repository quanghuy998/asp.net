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
    public class KieuDuLieuController : Controller
    {
        private readonly IKieuDuLieuService _kieuDuLieuService;
        public KieuDuLieuController(IKieuDuLieuService kieuDuLieuService)
        {
            _kieuDuLieuService = kieuDuLieuService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult DanhSach()
        {
            List<KieuDuLieuResponse> danhsach = _kieuDuLieuService.KieuDuLieuDanhSach();
            return Json(new { code = 200, msg = "Thanh cong", danhsach = danhsach });
        }
        public JsonResult LayID(int id)
        {
            KieuDuLieuResponse data = _kieuDuLieuService.KieuDuLieuLayID(id);
            return Json(new { code = 200, msg = "Lấy thông tin thành công", data = data });
        }

        public JsonResult ChinhSua(KieuDuLieuRequest request)
        {
            string result = _kieuDuLieuService.KieuDuLieuChinhSua(request);
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

        public JsonResult TaoMoi(KieuDuLieuRequest request)
        {
            string result = _kieuDuLieuService.KieuDuLieuTaoMoi(request);
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
            bool result = _kieuDuLieuService.KieuDuLieuXoaBo(id);
            if (result == true)
            {
                return Json(new { code = 200, msg = "Xoá bỏ thành công" });
            }
            else return Json(new { code = 500, msg = "Xoá bỏ thất bại" });

        }
    }
}
