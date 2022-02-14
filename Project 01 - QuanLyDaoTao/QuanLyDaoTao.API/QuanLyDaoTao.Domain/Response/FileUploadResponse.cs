using System;


namespace QuanLyDaoTao.Domain.Response
{
    public class FileUploadResponse
    {
        public string TenTep { get; set; }
        public string NoiLuuTru { get; set; }
        public Guid DoiTuongID { get; set; }
        public int STTTep { get; set; }
    }
}
