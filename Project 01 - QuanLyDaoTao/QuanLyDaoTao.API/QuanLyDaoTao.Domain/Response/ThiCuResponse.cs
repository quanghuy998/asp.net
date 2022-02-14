using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Response
{
    public class ThiCuResponse
    {
        public Guid ID { get; set; }
        public string MaThi { get; set; }
        public int LanThi { get; set; }
        public string MaLop { get; set; }
        public string TenMonHoc { get; set; }
        public string HinhThucThi { get; set; }
        public DateTime NgayThi { get; set; }
        public string MaDeThi { get; set; }
        public int SLThamDu { get; set; }
        public int SLVang { get; set; }
        public string BienBan { get; set; }
        public string MaNV { get; set; }
        public Guid DanhMucID { get; set; }

    }
}
