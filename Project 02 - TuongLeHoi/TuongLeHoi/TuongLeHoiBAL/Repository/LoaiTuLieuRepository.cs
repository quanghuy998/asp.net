using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoi.DAL.Interface;
using TuongLeHoiDomain.Request;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.DAL.Repository
{
    public class LoaiTuLieuRepository : DataBaseRepository, ILoaiTuLieuRepository
    {
        public List<LoaiTuLieuResponse> LoaiTuLieuDanhSach()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                List<LoaiTuLieuResponse> list = SqlMapper.Query<LoaiTuLieuResponse>(connect, "SPLoaiTuLieu_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LoaiTuLieuResponse LoaiTuLieuLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            LoaiTuLieuResponse response = SqlMapper.Query<LoaiTuLieuResponse>(connect, "SPLoaiTuLieu_LayID", param: parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }

        public string LoaiTuLieuChinhSua(LoaiTuLieuRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@TenLoaiTuLieu", request.TenLoaiTuLieu);
                parameters.Add("@MoTa", request.MoTa);
                var result = SqlMapper.ExecuteScalar<string>(connect, "SPLoaiTuLieu_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string LoaiTuLieuTaoMoi(LoaiTuLieuRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TenLoaiTuLieu", request.TenLoaiTuLieu);
                parameters.Add("@MoTa", request.MoTa);
                var result = SqlMapper.ExecuteScalar<string>(connect, "SPLoaiTuLieu_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public bool LoaiTuLieuXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPLoaiTuLieu_XoaBo", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
