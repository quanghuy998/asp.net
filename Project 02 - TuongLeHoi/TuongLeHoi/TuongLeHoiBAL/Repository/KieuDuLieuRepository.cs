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
    public class KieuDuLieuRepository : DataBaseRepository, IKieuDuLieuRepository
    {
        public List<KieuDuLieuResponse> KieuDuLieuDanhSach()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                List<KieuDuLieuResponse> list = SqlMapper.Query<KieuDuLieuResponse>(connect, "SPKieuDuLieu_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public KieuDuLieuResponse KieuDuLieuLayID(int ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            KieuDuLieuResponse response = SqlMapper.Query<KieuDuLieuResponse>(connect, "SPKieuDuLieu_LayID", param: parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }

        public string KieuDuLieuChinhSua(KieuDuLieuRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@TenKieuDuLieu", request.TenKieuDuLieu);
                var result = SqlMapper.ExecuteScalar<string>(connect, "SPKieuDuLieu_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string KieuDuLieuTaoMoi(KieuDuLieuRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TenKieuDuLieu", request.TenKieuDuLieu);
                var result = SqlMapper.ExecuteScalar<string>(connect, "SPKieuDuLieu_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public bool KieuDuLieuXoaBo(int ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPKieuDuLieu_XoaBo", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
