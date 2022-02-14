using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Request
{
    public class PhongHocRequest
    {
        public Guid ID { get; set; }
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public int SoMayTinh { get; set; }
        public string GhiChu { get; set; }
    }
}
