using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuongLeHoi.BAL.Interface;
using TuongLeHoi.BAL.Service;
using TuongLeHoiDomain.Request;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ThuocTinhController : Controller
    {
        private readonly IThuocTinhService _thuocTinhService;
        public ThuocTinhController(IThuocTinhService thuocTinhService)
        {
            _thuocTinhService = thuocTinhService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult DanhSach(int? MaNhom)
        {
            List<ThuocTinhResponse> danhsach = _thuocTinhService.ThuocTinhDanhSach(MaNhom);
            return Json(new { code = 200, msg = "Thanh cong", danhsach = danhsach });
        }
        [HttpGet]
        public JsonResult LayID(int id)
        {
            ThuocTinhResponse data = _thuocTinhService.ThuocTinhLayID(id);
            return Json(new { code = 200, msg = "Lấy thông tin thành công", data = data });
        }

        public JsonResult ChinhSua(ThuocTinhRequest request)
        {
            string result = _thuocTinhService.ThuocTinhChinhSua(request);
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

        public JsonResult TaoMoi(ThuocTinhRequest request)
        {
            string result = _thuocTinhService.ThuocTinhTaoMoi(request);
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
            bool result = _thuocTinhService.ThuocTinhXoaBo(id);
            if (result == true)
            {
                return Json(new { code = 200, msg = "Xoá bỏ thành công" });
            }
            else return Json(new { code = 500, msg = "Xoá bỏ thất bại" });

        }
    }
}
