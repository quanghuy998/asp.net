using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.LopHoc
{
    public class ChinhSua
    {
        public Guid ID { get; set; }
        public Guid CTDaoTaoID { get; set; }
        public string MaLop { get; set; }
        public DateTime NgayKhaiGiang { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int SoLuongHV { get; set; }
        public string QDMoLop { get; set; }
        public string ThoiKhoaBieu { get; set; }
        public string GhiChu { get; set; }

        public IFormFile FileQDMoLop { get; set; }
        public IFormFile FileThoiKhoaBieu { get; set; }
    }
}
