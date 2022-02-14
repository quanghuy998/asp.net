using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuongLeHoiDomain.Request
{
    public class LuocDoDuLieuRequest
    {
        public int ID { get; set; }
        public int MaThuocTinh { get; set; }
        public bool BatBuoc { get; set; }
        public bool LapLai { get; set; }
        public int ThuTu { get; set; }
        public int DoDai { get; set; }
        public Guid MaLoaiTuLieu { get; set; }
    }
}
