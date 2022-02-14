using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TuongLeHoiDomain.Response
{
    public class ThuocTinhResponse
    {
        public int ID { get; set; }
        public string TenThuocTinh { get; set; }
        public string MoTa { get; set; }
        public int MaNhom { get; set; }
        public int KieuDuLieu { get; set; }

        public string TenNhom { get; set; }
        public string TenKieuDuLieu { get; set; }

    }
}
