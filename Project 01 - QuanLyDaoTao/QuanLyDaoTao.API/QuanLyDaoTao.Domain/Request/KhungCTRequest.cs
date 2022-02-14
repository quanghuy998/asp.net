using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Request
{
    public class KhungCTRequest
    {
        public Guid ID { get; set; }
        public string MaKhungCT { get; set; }
        public string GhiChu { get; set; }
        public Guid NhanVienID { get; set; }
        public Guid LopHocID { get; set; }
    }
}
