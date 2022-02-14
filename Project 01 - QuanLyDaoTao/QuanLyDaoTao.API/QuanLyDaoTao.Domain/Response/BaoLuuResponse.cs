using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Response
{
    public class BaoLuuResponse
    {
        public Guid ID { get; set; }
        public string MaLop { get; set; }
        public string MaHV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgayBaoLuu { get; set; }
        public string LyDo { get; set; }
        public string MaLopMoi { get; set; }
        public string GhiChu { get; set; }
        public Guid LopHocID { get; set; }
        public Guid HocVienID { get; set; }
    }
}
