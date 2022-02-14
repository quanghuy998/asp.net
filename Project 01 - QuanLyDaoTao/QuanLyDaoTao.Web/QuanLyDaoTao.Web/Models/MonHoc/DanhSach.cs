using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.MonHoc
{
    public class DanhSach
    {
        public Guid ID { get; set; }
        public string MaCT { get; set; }
        public string TenCT { get; set; }
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public int Sogio { get; set; }
        public string GhiChu { get; set; }
        public Guid CTDaoTaoID { get; set; }
    }
}
