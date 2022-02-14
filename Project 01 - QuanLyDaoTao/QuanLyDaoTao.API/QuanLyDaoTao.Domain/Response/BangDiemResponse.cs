using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Response
{
    public class BangDiemResponse
    {
        public Guid ID { get; set; }
        public string MaCT { get; set; }
        public string MaLop { get; set; }
        public string HoTen { get; set; }
        public string TenMonHoc { get; set; }
        public string MaMonHoc { get; set; }
        public int DiemThi { get; set; }
        public int LanThi { get; set; }
        public string GhiChu { get; set; }
        public Guid ThiCuID { get; set; }
        public Guid DanhMucID { get; set; }
    }
}
