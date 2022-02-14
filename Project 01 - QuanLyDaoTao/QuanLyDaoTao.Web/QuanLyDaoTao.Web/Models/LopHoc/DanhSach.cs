using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.LopHoc
{
    public class DanhSach
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
