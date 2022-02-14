using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyDaoTao.BAL.Interface;
using QuanLyDaoTao.Domain.Response;
using QuanLyDaoTao.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace QuanLyDaoTao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuongTrinhDaoTaoController
    {
        private readonly IChuongTrinhDaoTaoService _chuongTrinhDaoTaoService;
        private readonly IFileUploadService _fileUploadService;

        public ChuongTrinhDaoTaoController(IChuongTrinhDaoTaoService chuongTrinhDaoTaoService, 
            IFileUploadService fileUploadService) 
        {
            _chuongTrinhDaoTaoService = chuongTrinhDaoTaoService;
            _fileUploadService = fileUploadService;
        }

        // Danh sách chương trình đào tạo theo Trạng thái và Mã chương trình
        [HttpGet]
        public IEnumerable<CTDaoTaoResponse> CTDTDanhSach(int TrangThai = 2, string MaCT = null)
        {
            return _chuongTrinhDaoTaoService.CTDTDanhSach(TrangThai, MaCT);
        }

        // Lấy mã chương trình đào tạo
        [HttpGet("{ID}")]
        public CTDaoTaoResponse CTDTLayMaCT(Guid ID)
        {
            return _chuongTrinhDaoTaoService.CTDTLayMaCT(ID);
        }

        // Chỉnh sửa chương trình đào tạo
        [HttpPut("{ID}")]
        public int CTDTChinhSua([FromBody]CTDaoTaoRequest request)
        {
            if(request.NoiDungCT != null)
            {
                string filePath1 = Path.Combine("\\files\\ChuongTrinhDaoTao", request.NoiDungCT);
                FileUploadRequest data1 = new FileUploadRequest();
                data1.TenTep = request.NoiDungCT;
                data1.NoiLuuTru = filePath1;
                data1.DoiTuongID = request.ID;
                data1.STTTep = 1;
                _fileUploadService.FileUpload_ChinhSua(data1);
            }
            if (request.NoiDungCT != null)
            {
                string filePath2 = Path.Combine("\\files\\ChuongTrinhDaoTao", request.QDBanHanh);
                FileUploadRequest data2 = new FileUploadRequest();
                data2.TenTep = request.QDBanHanh;
                data2.NoiLuuTru = filePath2;
                data2.DoiTuongID = request.ID;
                data2.STTTep = 2;
                _fileUploadService.FileUpload_ChinhSua(data2);
            }
            // Truyền dữ liệu vào Database FileUpload
            return _chuongTrinhDaoTaoService.CTDTChinhSua(request);
        }

        // Tạo mới chương trình đào tạo
        [HttpPost]
        public int CTDTTaoMoi(CTDaoTaoRequest request)
        {
            request.ID = Guid.NewGuid();
            string filePath1 = Path.Combine("\\files\\ChuongTrinhDaoTao", request.NoiDungCT);
            string filePath2 = Path.Combine("\\files\\ChuongTrinhDaoTao", request.QDBanHanh);

            // Truyền dữ liệu vào Database FileUpload
            FileUploadRequest data1 = new FileUploadRequest();
            FileUploadRequest data2 = new FileUploadRequest();
            data1.TenTep = request.NoiDungCT;
            data1.NoiLuuTru = filePath1;
            data1.DoiTuongID = request.ID;
            data1.STTTep = 1;
            data2.TenTep = request.QDBanHanh;
            data2.NoiLuuTru = filePath2;
            data2.DoiTuongID = request.ID;
            data2.STTTep = 2;

            _fileUploadService.FileUpload_TaoMoi(data1);
            _fileUploadService.FileUpload_TaoMoi(data2);

            return _chuongTrinhDaoTaoService.CTDTTaoMoi(request);
        }

        // Xóa bỏ chương trình đào tạo
        [HttpDelete("{ID}")]
        public bool CTDTXoaBo(Guid ID)
        {
            return _chuongTrinhDaoTaoService.CTDTXoaBo(ID);
        }
    }
}
