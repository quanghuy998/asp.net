using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuongLeHoiDomain.Request
{
    public class ThongTinMoTaRequest
    {
        public int ID { get; set; }
        public string GiaTri { get; set; }
        public Guid MaTuLieu { get; set; }
        public int MaThuocTinh { get; set; }
    }
}
