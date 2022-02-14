using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Request
{
    public class MonHocRequest
    {
        public Guid ID { get; set; }
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public int SoGio { get; set; }
        public string GhiChu { get; set; }
        public Guid CTDaoTaoID { get; set; }
    }
}
