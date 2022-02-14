using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuongLeHoiDomain.Response
{
    public class ThongTinTuLieuThuocTinhResponse
    {
        public string TenLoaiTuLieu { get; set; }
        public int MaThuocTinh { get; set; }
        public string TenThuocTinh { get; set; }
        public string TenKieuDuLieu { get; set; }
        public bool BatBuoc { get; set; }
        public bool LapLai { get; set; }
        public int ThuTu { get; set; }
        public int DoDai { get; set; }
    }
}
