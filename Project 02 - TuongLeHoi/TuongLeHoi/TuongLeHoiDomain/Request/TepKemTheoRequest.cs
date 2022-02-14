using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuongLeHoiDomain.Request
{
    public class TepKemTheoRequest
    {
        public int ID { get; set; }
        public Guid MaTuLieu { get; set; }
        public string TenTep { get; set; }
        public string MoTa { get; set; }
        public string ViTriLuuTru { get; set; }
    }
}
