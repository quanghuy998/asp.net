using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Models.FileUpload
{
    public class FileUpload
    {
        public int ID { get; set; }
        public string TenTep { get; set; }
        public string NoiLuuTru { get; set; }
        public Guid DoiTuongID { get; set; }
        public int STTTep { get; set; }
    }
}
