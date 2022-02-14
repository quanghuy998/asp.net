using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDaoTao.Domain.Response
{
    public class LopHocResponse
    {
        public Guid ID { set; get; }
        public Guid CTDaoTaoID { get; set; }
        public int STT { get; set; }
        public string MaLop { get; set; }
        public string MaCT { get; set; }
        public DateTime NgayKhaiGiang { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int SoLuongHV { get; set; }
        public string QDMoLop { get; set; }
        public string ThoiKhoaBieu { get; set; }
        public string GhiChu { get; set; }
    }
}
