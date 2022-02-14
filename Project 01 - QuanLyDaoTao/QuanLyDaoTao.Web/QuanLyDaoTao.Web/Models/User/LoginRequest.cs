using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.User
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Phải nhập {0}")]
        [Display(Name = "Tên tài khoản/Email")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Nhớ thông tin đăng nhập?")]
        public bool RememberMe { get; set; }

    }
}
