using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.BangDiem
{
    public class ChinhSua
    {
        public Guid ID { get; set; }
        public Guid HocVienID { get; set; }
        public Guid ThiCuID { get; set; }
        public Guid DanhMucID { get; set; }
        public double DiemThi { get; set; }
        public string GhiChu { get; set; }
    }
}
