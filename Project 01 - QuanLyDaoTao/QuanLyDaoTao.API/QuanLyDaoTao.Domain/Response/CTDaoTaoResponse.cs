using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Domain.Response
{
    public class CTDaoTaoResponse
    {
        public Guid ID { get; set; }
        public int STT { get; set; }
        public string MaCT { get; set; }
        public string TenCT { get; set; }
        public decimal HocPhi { get; set; }
        public DateTime NgayBanHanh { get; set; }
        public string QDBanHanh { get; set; }
        public string NoiDungCT { get; set; }
        public string GhiChu { get; set; }
        public int TrangThai { get; set; }
    }
}
