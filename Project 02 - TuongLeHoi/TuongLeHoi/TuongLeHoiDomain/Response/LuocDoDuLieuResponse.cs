using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuongLeHoiDomain.Response
{
    public class LuocDoDuLieuResponse
    {
        public int ID { get; set; }
        public Guid MaLoaiTuLieu { get; set; }
        public int MaThuocTinh { get; set; }
        public bool BatBuoc { get; set; }
        public bool LapLai { get; set; }
        public int ThuTu { get; set; }
        public int DoDai { get; set; }
        public int MaNhom { get; set; }

        public string TenLoaiTuLieu { get; set; }
        public string TenThuocTinh { get; set; }
    }
}
