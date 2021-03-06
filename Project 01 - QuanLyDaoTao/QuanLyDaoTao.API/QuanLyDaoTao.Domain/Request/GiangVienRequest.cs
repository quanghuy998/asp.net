using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Request
{
    public class GiangVienRequest
    {
        public Guid ID { get; set; }
        public string MaGV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DonViCongTac { get; set; }
        public string MaSoThue { get; set; }
        public string TrinhDo { get; set; }
        public string BangCap { get; set; }
        public string ChungChi { get; set; }
    }
}
