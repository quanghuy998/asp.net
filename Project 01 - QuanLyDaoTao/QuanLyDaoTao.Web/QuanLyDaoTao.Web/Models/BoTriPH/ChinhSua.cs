using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.BoTriPH
{
    public class ChinhSua
    {
        public Guid ID { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string GhiChu { get; set; }
        public Guid LopHocID { get; set; }
        public Guid PhongHocID { get; set; }
    }
}
