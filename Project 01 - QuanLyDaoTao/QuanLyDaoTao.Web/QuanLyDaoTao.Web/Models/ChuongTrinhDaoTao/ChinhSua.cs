using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.ChuongTrinhDaoTao
{
    public class ChinhSua
    {
        public Guid ID { get; set; }
        public string MaCT { get; set; }
        public string TenCT { get; set; }
        public decimal HocPhi { get; set; }
        public DateTime NgayBanHanh { get; set; }
        public string NoiDungCT { get; set; }
        public string QDBanHanh { get; set; }
        public string GhiChu { get; set; }
        public int TrangThai { get; set; }

        public IFormFile FileNoiDungCT { get; set; }
        public IFormFile FileQDBanHanh { get; set; }
    }
}
