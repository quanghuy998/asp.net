using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuongLeHoiDomain.Response
{
    public class TepKemTheoResponse
    {
        public int ID { get; set; }
        public Guid MaTuLieu { get; set; }
        public string TenTep { get; set; }
        public string MoTa { get; set; }
        public string ViTriLuuTru { get; set; }
    }
}
