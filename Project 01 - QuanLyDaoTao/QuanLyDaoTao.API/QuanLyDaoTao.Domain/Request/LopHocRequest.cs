using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDaoTao.Domain.Request
{
    public class LopHocRequest
    {
        public Guid ID { get; set; }
        public string MaLop { get; set; }
        public DateTime NgayKhaiGiang { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int SoLuongHV { get; set; }
        public string QDMoLop { get; set; }
        public string ThoiKhoaBieu { get; set; }
        public string GhiChu { get; set; }
        public Guid CTDaoTaoID { get; set; }
    }
}
