using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuongLeHoiDomain.Request
{
    public class LoaiTuLieuRequest
    {
        public Guid ID { get; set; }
        public string TenLoaiTuLieu { get; set; }
        public string MoTa { get; set; }
    }
}
