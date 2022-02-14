using QuanLyDaoTao.Domain.Response;
using QuanLyDaoTao.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace QuanLyDaoTao.DAL.Interface
{
    public interface IFileUploadRepository
    {
        IList<FileUploadResponse> FileUpload_LayTheoDoiTuongID(Guid DoiTuongID);
        int FileUpload_ChinhSua(FileUploadRequest request);
        int FileUpload_TaoMoi(FileUploadRequest request);
        bool FileUpload_Xoa(Guid DoiTuongID, string TenTep);
    }
}
