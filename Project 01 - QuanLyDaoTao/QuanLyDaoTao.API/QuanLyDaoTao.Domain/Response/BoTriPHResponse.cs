using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Response
{
    public class BoTriPHResponse
    {
        public Guid ID { get; set; }
        public string MaLop { get; set; }
        public string MaPhong { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string GhiChu { get; set; }
        public Guid PhongHocID { get; set; }
        public Guid LopHocID { get; set; }
    }
}
