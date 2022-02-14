using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Request
{
    public class BangDiemRequest
    {
        public Guid ID { get; set; }
        public Guid HocVienID { get; set; }
        public Guid ThiCuID { get; set; }
        public Guid DanhMucID { get; set; }
        public double DiemThi { get; set; }
        public string GhiChu { get; set; }
    }
}
