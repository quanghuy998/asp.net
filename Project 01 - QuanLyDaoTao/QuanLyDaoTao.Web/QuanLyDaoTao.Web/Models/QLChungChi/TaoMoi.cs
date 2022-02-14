using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.QLChungChi
{
    public class TaoMoi
    {
        public string SoHieuCC { get; set; }
        public int TrangThai { get; set; }
        public DateTime NgayNhan { get; set; }
        public Guid NhanVienID { get; set; }
        public Guid LopHocID { get; set; }
        public Guid HocVienID { get; set; }

    }
}
