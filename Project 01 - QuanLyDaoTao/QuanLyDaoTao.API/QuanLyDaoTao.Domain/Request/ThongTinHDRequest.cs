using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Request
{
    public class ThongTinHDRequest
    {
        public Guid ID { get; set; }
        public string MaHopDong { get; set; }
        public int SoGio { get; set; }
        public int ThuLao { get; set; }
        public DateTime NgayKy { get; set; }
        public DateTime NgayThanhLy { get; set; }
        public string HopDongGD { get; set; }
        public string HopDongTL { get; set; }
        public string MaNVLamHD { get; set; }
        public string MaNVTLHD { get; set; }
        public Guid GiangVienID { get; set; }
        public Guid DanhMucID { get; set; }
    }
}
