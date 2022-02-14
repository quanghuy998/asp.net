using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TuongLeHoiDomain.Request
{
    public class ThuocTinhRequest
    {
        public int ID { get; set; }
        public string TenThuocTinh { get; set; }
        public string MoTa { get; set; }
        public int MaNhom { get; set; }
        public int KieuDuLieu { get; set; }
    }
}
