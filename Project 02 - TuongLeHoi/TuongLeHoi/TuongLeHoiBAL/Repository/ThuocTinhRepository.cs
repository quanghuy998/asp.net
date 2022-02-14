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
    public class ThuocTinhRepository : DataBaseRepository, IThuocTinhRepository
    {
        public List<ThuocTinhResponse> ThuocTinhDanhSach(int? MaNhom)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaNhom", MaNhom);
                List<ThuocTinhResponse> list = SqlMapper.Query<ThuocTinhResponse>(connect, "SPThuocTinh_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ThuocTinhResponse ThuocTinhLayID(int ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            ThuocTinhResponse response = SqlMapper.Query<ThuocTinhResponse>(connect, "SPThuocTinh_LayID", param: parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }

        public string ThuocTinhChinhSua(ThuocTinhRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@TenThuocTinh", request.TenThuocTinh);
                parameters.Add("@MoTa", request.MoTa);
                parameters.Add("@MaNhom", request.MaNhom);
                parameters.Add("@KieuDuLieu", request.KieuDuLieu);
                var result = SqlMapper.ExecuteScalar<string>(connect, "SPThuocTinh_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string ThuocTinhTaoMoi(ThuocTinhRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TenThuocTinh", request.TenThuocTinh);
                parameters.Add("@MoTa", request.MoTa);
                parameters.Add("@MaNhom", request.MaNhom);
                parameters.Add("@KieuDuLieu", request.KieuDuLieu);
                var result = SqlMapper.ExecuteScalar<string>(connect, "SPThuocTinh_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public bool ThuocTinhXoaBo(int ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPThuocTinh_XoaBo", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
