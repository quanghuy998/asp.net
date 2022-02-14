using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.QLChungChi
{
    public class DanhSach
    {
        public Guid ID { get; set; }
        public string SoHieuCC { get; set; }
        public string MaLop { get; set; }
        public string HoTen { get; set; }
        public DateTime NgayNhan { get; set; }
        public string TrangThai { get; set; }
        public Guid NhanVienID { get; set; }
        public Guid LopHocID { get; set; }
        public Guid HocVienID { get; set; }

    }
}
