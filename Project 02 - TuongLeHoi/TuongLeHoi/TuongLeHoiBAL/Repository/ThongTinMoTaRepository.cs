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
    public class ThongTinMoTaRepository : DataBaseRepository, IThongTinMoTaRepository
    {
        public List<ThongTinMoTaResponse> ThongTinMoTaDanhSach()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                List<ThongTinMoTaResponse> list = SqlMapper.Query<ThongTinMoTaResponse>(connect, "SPThongTinMoTa_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ThongTinMoTaResponse ThongTinMoTaLayID(int ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            ThongTinMoTaResponse response = SqlMapper.Query<ThongTinMoTaResponse>(connect, "SPThongTinMoTa_LayID", param: parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }

        public string ThongTinMoTaChinhSua(ThongTinMoTaRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@GiaTri", request.GiaTri);
                parameters.Add("@MaTuLieu", request.MaTuLieu);
                parameters.Add("@MaThuocTinh", request.MaThuocTinh);
                var result = SqlMapper.ExecuteScalar<string>(connect, "SPThongTinMoTa_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string ThongTinMoTaTaoMoi(ThongTinMoTaRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@GiaTri", request.GiaTri);
                parameters.Add("@MaTuLieu", request.MaTuLieu);
                parameters.Add("@MaThuocTinh", request.MaThuocTinh);
                var result = SqlMapper.ExecuteScalar<string>(connect, "SPThongTinMoTa_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public bool ThongTinMoTaXoaBo(int ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPThongTinMoTa_XoaBo", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
