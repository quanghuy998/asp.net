using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.ThoiKhoaBieu
{
    public class ChinhSua
    {
        public Guid ID { get; set; }
        public string Thu { get; set; }
        public string GhiChu { get; set; }
        public Guid KhungGioID { get; set; }
        public Guid LopHocID { get; set; }

    }
}
