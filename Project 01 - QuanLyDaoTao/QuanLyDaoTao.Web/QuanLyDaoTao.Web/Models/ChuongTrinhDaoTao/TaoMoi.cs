using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.ChuongTrinhDaoTao
{
    public class TaoMoi
    {
        [Required(ErrorMessage = "Phải nhập {0}")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "{0} phải dài chỉ từ {2}-{1} kí tự")]
        public string MaCT { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        [StringLength(256, MinimumLength = 1, ErrorMessage = "{0} phải dài chỉ từ {2}-{1} kí tự")]
        public string TenCT { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        [Range(0, Double.PositiveInfinity)]
        public decimal HocPhi { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        public DateTime NgayBanHanh { get; set; }

        public string NoiDungCT { get; set; }
        public string QDBanHanh { get; set; }

        [StringLength(50, MinimumLength = 0, ErrorMessage = "{0} phải dài chỉ từ {2}-{1} kí tự")]
        public string GhiChu { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        public IFormFile FileNoiDungCT { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        public IFormFile FileQDBanHanh { get; set; }
    }
}
