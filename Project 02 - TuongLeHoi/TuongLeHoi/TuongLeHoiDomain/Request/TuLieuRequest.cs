using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TuongLeHoiDomain.Request
{
    public class TuLieuRequest
    {
        public Guid ID { get; set; }
        public string TenTuLieu { get; set; }
        public string HinhAnh { get; set; }
        public string MoTa { get; set; }
        public int NguoiTao { get; set; }
        public int NguoiCapNhatCuoi { get; set; }
        public Guid MaLoaiTuLieu { get; set; }
    }
}
