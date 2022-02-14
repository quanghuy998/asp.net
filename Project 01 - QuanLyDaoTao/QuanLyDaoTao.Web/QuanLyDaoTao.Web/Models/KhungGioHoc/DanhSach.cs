using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.KhungGioHoc
{
    public class DanhSach
    {
        public Guid ID { get; set; }
        public string MaLop { get; set; }
        public string TenMonHoc { get; set; }
        public string HoTen { get; set; }
        public string MaKhungGio { get; set; }
        public DateTime GioBatDau { get; set; }
        public DateTime GioKetThuc { get; set; }
        public string GhiChu { get; set; }
        public Guid DanhMucID { get; set; }
        public Guid HopDongID { get; set; }

    }
}
