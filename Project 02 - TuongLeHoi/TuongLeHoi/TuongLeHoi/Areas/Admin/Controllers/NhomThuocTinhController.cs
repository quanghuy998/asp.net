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
    public class NhomThuocTinhController : Controller
    {
        private readonly INhomThuocTinhService _nhomThuocTinhService;
        public NhomThuocTinhController(INhomThuocTinhService nhomThuocTinhService)
        {
            _nhomThuocTinhService = nhomThuocTinhService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult DanhSach()
        {
            List<NhomThuocTinhResponse> danhsach = _nhomThuocTinhService.NhomThuocTinhDanhSach();
            return Json(new { code = 200, msg = "Thanh cong", danhsach = danhsach });
        }
        [HttpGet]
        public JsonResult LayID(int id)
        {
            NhomThuocTinhResponse data = _nhomThuocTinhService.NhomThuocTinhLayID(id);
            return Json(new { code = 200, msg = "Lấy thông tin thành công", data = data});
        }

        public JsonResult ChinhSua(NhomThuocTinhRequest request)
        {
            string result = _nhomThuocTinhService.NhomThuocTinhChinhSua(request);
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

        public JsonResult TaoMoi(NhomThuocTinhRequest request)
        {
            string result = _nhomThuocTinhService.NhomThuocTinhTaoMoi(request);
            if(result == "Success")
            {
                return Json(new {code = 200, msg = "Tạo mới thành công"});
            }
            else if(result == "Failure")
            {
                return Json(new { code = 500, msg = "Tạo mới thất bại" });
            }
            else return Json(new { code = 600, msg = "Tạo mới thất bại: " + result });

        }

        public JsonResult XoaBo(int id)
        {
            bool result = _nhomThuocTinhService.NhomThuocTinhXoaBo(id);
            if (result == true)
            {
                return Json(new { code = 200, msg = "Xoá bỏ thành công" });
            }
            else return Json(new { code = 500, msg = "Xoá bỏ thất bại" });

        }
    }
}
