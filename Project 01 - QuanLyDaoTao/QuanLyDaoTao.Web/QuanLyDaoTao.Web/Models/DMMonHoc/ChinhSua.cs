using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.DMMonHoc
{
    public class ChinhSua
    {
        public Guid ID { get; set; }
        public Guid MonHocID { get; set; }
        public Guid KhungCTID { get; set; }
        public string HinhThuThi { get; set; }
        public string GhiChu { get; set; }

    }
}
