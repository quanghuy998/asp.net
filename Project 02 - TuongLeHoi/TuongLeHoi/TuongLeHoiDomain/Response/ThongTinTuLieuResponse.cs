using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuongLeHoiDomain.Response
{
    public class ThongTinTuLieuResponse
    {
        public Guid ID { get; set; }
        public string TenLoaiTuLieu { get; set; }
        public string TenTuLieu { get; set; }
        public int MaThuocTinh { get; set; }
        public string TenThuocTinh { get; set; }
        public string GiaTri { get; set; }
    }
}
