using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Request
{
    public class KhungGioHocRequest
    {
        public Guid ID { get; set; }
        public string MaKhungGio { get; set; }
        public DateTime GioBatDau { get; set; }
        public DateTime GioKetThuc { get; set; }
        public string GhiChu { get; set; }
        public Guid DanhMucID { get; set; }
        public Guid HopDongID { get; set; }
    }
}
