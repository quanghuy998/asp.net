using Microsoft.AspNetCore.Http;
using QuanLyDaoTao.BAL.Interface;
using QuanLyDaoTao.DAL.Interface;
using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.BAL.Service
{
    public class FileUploadService : IFileUploadService
    {
        private IFileUploadRepository _fileUploadRepository;
        public FileUploadService(IFileUploadRepository fileUploadRepository)
        {
            _fileUploadRepository = fileUploadRepository;
        }

        //Thấy theo đối tượng ID
        public IList<FileUploadResponse> FileUpload_LayTheoDoiTuongID(Guid DoiTuongID)
        {
            return _fileUploadRepository.FileUpload_LayTheoDoiTuongID(DoiTuongID);
        }

        //Chỉnh sửa
        public int FileUpload_ChinhSua(FileUploadRequest request)
        {
            return _fileUploadRepository.FileUpload_ChinhSua(request);
        }

        //Tạo mới
        public int FileUpload_TaoMoi(FileUploadRequest request)
        {
            return _fileUploadRepository.FileUpload_TaoMoi(request);
        }

        //Xóa bỏ
        public bool FileUpload_Xoa(Guid DoiTuongID, string TenTep)
        {
            return _fileUploadRepository.FileUpload_Xoa(DoiTuongID, TenTep);
        }

    }
}
