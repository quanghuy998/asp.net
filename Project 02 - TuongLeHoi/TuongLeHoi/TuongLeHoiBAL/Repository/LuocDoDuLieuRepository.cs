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
    public class LuocDoDuLieuRepository : DataBaseRepository, ILuocDoDuLieuRepository
    {
        public List<LuocDoDuLieuResponse> LuocDoDuLieuDanhSach()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                List<LuocDoDuLieuResponse> list = SqlMapper.Query<LuocDoDuLieuResponse>(connect, "SPLuocDoDuLieu_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LuocDoDuLieuResponse LuocDoDuLieuLayID(int ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            LuocDoDuLieuResponse response = SqlMapper.Query<LuocDoDuLieuResponse>(connect, "SPLuocDoDuLieu_LayID", param: parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }

        public string LuocDoDuLieuChinhSua(LuocDoDuLieuRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@MaThuocTinh", request.MaThuocTinh);
                parameters.Add("@BatBuoc", request.BatBuoc);
                parameters.Add("@LapLai", request.LapLai);
                parameters.Add("@ThuTu", request.ThuTu);
                parameters.Add("@DoDai", request.DoDai);
                parameters.Add("@MaLoaiTuLieu", request.MaLoaiTuLieu);
                var result = SqlMapper.ExecuteScalar<string>(connect, "SPLuocDoDuLieu_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string LuocDoDuLieuTaoMoi(LuocDoDuLieuRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaThuocTinh", request.MaThuocTinh);
                parameters.Add("@BatBuoc", request.BatBuoc);
                parameters.Add("@LapLai", request.LapLai);
                parameters.Add("@ThuTu", request.ThuTu);
                parameters.Add("@DoDai", request.DoDai);
                parameters.Add("@MaLoaiTuLieu", request.MaLoaiTuLieu);
                var result = SqlMapper.ExecuteScalar<string>(connect, "SPLuocDoDuLieu_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public bool LuocDoDuLieuXoaBo(int ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPLuocDoDuLieu_XoaBo", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
