using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Response
{
    public class HocVienResponse
    {
        public Guid ID { get; set; }
        public string MaLop { get; set; }
        public string MaHV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string HinhAnh { get; set; }
        public string TrinhDo { get; set; }
        public string NgheNghiep { get; set; }
        public string DonViCongTac { get; set; }
        public string ChucVu { get; set; }
        public string SoQDHocNghe { get; set; }
        public string SoQBHocNghe { get; set; }
        public string SoSoBHXH { get; set; }
        public string HotenNBT { get; set; }
        public string SDTNBT { get; set; }
        public string GhiChu { get; set; }
        public Guid LopHocID { get; set; }
    }
}
