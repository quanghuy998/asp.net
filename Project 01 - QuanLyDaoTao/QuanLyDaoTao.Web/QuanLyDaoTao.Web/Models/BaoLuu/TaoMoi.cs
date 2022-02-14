using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.BaoLuu
{
    public class TaoMoi
    {
        public DateTime NgayBaoLuu { get; set; }
        public string LyDo { get; set; }
        public string DonBaoLuu { get; set; }
        public string MaLopMoi { get; set; }
        public string GhiChu { get; set; }
        public Guid LopHocID { get; set; }
        public Guid HocVienID { get; set; }
    }
}
