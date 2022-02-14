using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyDaoTao.BAL.Interface;
using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        private readonly IFileUploadService _fileUploadService;
        public FileUploadController(IFileUploadService fileUploadService)
        {
            _fileUploadService = fileUploadService;
        }

        //Lấy ID FileUpload
        [HttpGet("{DoiTuongID}")]
        public IList<FileUploadResponse> FileUpload_LayTheoDoiTuongID(Guid DoiTuongID)
        {
            return _fileUploadService.FileUpload_LayTheoDoiTuongID(DoiTuongID);
        }

        //Tạo mới FileUpload
        [HttpPost]
        public int FileUpload_TaoMoi(FileUploadRequest request)
        {
            return _fileUploadService.FileUpload_TaoMoi(request);
        }

        //Sửa FileUpload
        [HttpPut]
        public int FileUpload_ChinhSua(FileUploadRequest request)
        {
            return _fileUploadService.FileUpload_ChinhSua(request);
        }

        //Xóa FileUpload
        [HttpDelete]
        public bool FileUpload_Xoa(Guid DoiTuongID, string TenTep)
        {
            return _fileUploadService.FileUpload_Xoa(DoiTuongID, TenTep);
        }
    }
}
