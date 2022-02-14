using Dapper;
using QuanLyDaoTao.DAL.Interface;
using QuanLyDaoTao.Domain.Response;
using QuanLyDaoTao.Domain.Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace QuanLyDaoTao.DAL.Repository
{
    public class FileUploadRepository : DataBaseRepository, IFileUploadRepository
    {
        public IList<FileUploadResponse> FileUpload_LayTheoDoiTuongID(Guid DoiTuongID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@DoiTuongID", DoiTuongID);
                IList<FileUploadResponse> fileupload = SqlMapper.Query<FileUploadResponse>(connect, "SPFileUploaded_LayTheoDoiTuongID", parameters, commandType: CommandType.StoredProcedure).ToList();
                return fileupload;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int FileUpload_ChinhSua(FileUploadRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@TenTep", request.TenTep);
                parameters.Add("@NoiLuuTru", request.NoiLuuTru);
                parameters.Add("@DoiTuongID", request.DoiTuongID);
                parameters.Add("@STTTep", request.STTTep);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPFileUploaded_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
}

        public int FileUpload_TaoMoi(FileUploadRequest datarequest)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TenTep", datarequest.TenTep);
                parameters.Add("@NoiLuuTru", datarequest.NoiLuuTru);
                parameters.Add("@DoiTuongID", datarequest.DoiTuongID);
                parameters.Add("@STTTep", datarequest.STTTep);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPFileUploaded_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool FileUpload_Xoa(Guid DoiTuongID, string TenTep)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@DoiTuongID", DoiTuongID);
                parameters.Add("@TenTep", TenTep);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPFileUploaded_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
