using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuongLeHoi.BAL.Interface;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ThongTinTuLieuController : Controller
    {
        private readonly IThongTinTuLieuService _thongTinTuLieuService;
        public ThongTinTuLieuController(IThongTinTuLieuService thongTinTuLieuService)
        {
            _thongTinTuLieuService = thongTinTuLieuService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult LayID(Guid ID)
        {
            List<ThongTinTuLieuResponse> tulieu = _thongTinTuLieuService.ThongTinTuLieuLayID(ID);
            return Json(new { code = 200, msg = "Thanh cong", tulieu = tulieu });
        }
        public JsonResult ThuocTinh(Guid MaLoaiTuLieu)
        {
            List<ThongTinTuLieuThuocTinhResponse> thuoctinh = _thongTinTuLieuService.ThongTinTuLieuThuocTinh(MaLoaiTuLieu);
            return Json(new { code = 200, msg = "Thanh cong", thuoctinh = thuoctinh });
        }
    }
}
