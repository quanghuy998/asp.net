using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyDaoTao.BAL.Interface;
using QuanLyDaoTao.Domain.Response;
using QuanLyDaoTao.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace QuanLyDaoTao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LopHocController : ControllerBase
    {
        public readonly ILopHocService _lopHocService;
        private readonly IFileUploadService _fileUploadService;
        public LopHocController(ILopHocService lopHocService, IFileUploadService fileUploadService)
        {
            _lopHocService = lopHocService;
            _fileUploadService = fileUploadService;
        }
        [HttpGet]
        public IEnumerable<LopHocResponse> LopHocDanhSach(Guid? ID, Guid? CTDaoTaoID)
        {
            return _lopHocService.LopHocDanhSach(ID, CTDaoTaoID);
        }
        [HttpGet("{id}")]
        public LopHocResponse LopHocLayID(Guid id)
        {
            return _lopHocService.LopHocLayID(id);
        }
        [HttpPut]
        public int LopHocChinhSua(LopHocRequest request)
        {
            if (request.QDMoLop != null)
            {
                string filePath1 = Path.Combine("\\files\\LopHoc", request.QDMoLop);
                FileUploadRequest data1 = new FileUploadRequest();
                data1.TenTep = request.QDMoLop;
                data1.NoiLuuTru = filePath1;
                data1.DoiTuongID = request.ID;
                data1.STTTep = 1;
                _fileUploadService.FileUpload_ChinhSua(data1);
            }
            if (request.ThoiKhoaBieu != null)
            {
                string filePath2 = Path.Combine("\\files\\LopHoc", request.ThoiKhoaBieu);
                FileUploadRequest data2 = new FileUploadRequest();
                data2.TenTep = request.ThoiKhoaBieu;
                data2.NoiLuuTru = filePath2;
                data2.DoiTuongID = request.ID;
                data2.STTTep = 2;
                _fileUploadService.FileUpload_ChinhSua(data2);
            }
            return _lopHocService.LopHocChinhSua(request);
        }
        [HttpPost]
        public int LopHocTaoMoi([FromBody]LopHocRequest request)
        {
            request.ID = Guid.NewGuid();
            // Truyền dữ liệu vào Database FileUpload
            if (request.QDMoLop != null)
            {
                string path1 = Path.Combine("\\files\\LopHoc", request.QDMoLop);
                FileUploadRequest data1 = new FileUploadRequest();
                data1.TenTep = request.QDMoLop;
                data1.NoiLuuTru = path1;
                data1.DoiTuongID = request.ID;
                data1.STTTep = 1;
                _fileUploadService.FileUpload_TaoMoi(data1);
            }
            if (request.ThoiKhoaBieu != null)
            {
                string path2 = Path.Combine("\\files\\LopHoc", request.ThoiKhoaBieu);
                FileUploadRequest data2 = new FileUploadRequest();
                data2.TenTep = request.ThoiKhoaBieu;
                data2.NoiLuuTru = path2;
                data2.DoiTuongID = request.ID;
                data2.STTTep = 2;
                _fileUploadService.FileUpload_TaoMoi(data2);
            }
            return _lopHocService.LopHocTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool LopHocXoaBo(Guid id)
        {
            return _lopHocService.LopHocXoaBo(id);
        }
    }
}
