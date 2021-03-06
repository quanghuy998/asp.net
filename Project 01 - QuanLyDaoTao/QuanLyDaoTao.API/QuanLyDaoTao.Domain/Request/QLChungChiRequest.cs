using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Request
{
    public class QLChungChiRequest
    {
        public Guid ID { get; set; }
        public string SoHieuCC { get; set; }
        public int TrangThai { get; set; }
        public DateTime NgayNhan { get; set; }
        public Guid NhanVienID { get; set; }
        public Guid LopHocID { get; set; }
        public Guid HocVienID { get; set; }
    }
}
