using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.KhungCT
{
    public class ChinhSua
    {
        public Guid ID { get; set; }
        public string MaKhungCT { get; set; }
        public string GhiChu { get; set; }
        public Guid NhanVienID { get; set; }
        public Guid LopHocID { get; set; }

    }
}
