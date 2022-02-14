using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.BangDiem
{
    public class DanhSach
    {
        public Guid ID { get; set; }
        public string MaCT { get; set; }
        public string MaLop { get; set; }
        public string HoTen { get; set; }
        public string TenMonHoc { get; set; }
        public int DiemThi { get; set; }
        public int LanThi { get; set; }
        public string GhiChu { get; set; }
        public Guid ThiCuID { get; set; }
        public Guid DanhMucID { get; set; }

    }
}
