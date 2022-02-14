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
    public class NhomThuocTinhRepository : DataBaseRepository, INhomThuocTinhRepository
    {
        public List<NhomThuocTinhResponse> NhomThuocTinhDanhSach()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                List<NhomThuocTinhResponse> list = SqlMapper.Query<NhomThuocTinhResponse>(connect, "SPNhomThuocTinh_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public NhomThuocTinhResponse NhomThuocTinhLayID(int ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            NhomThuocTinhResponse response = SqlMapper.Query<NhomThuocTinhResponse>(connect, "SPNhomThuocTinh_LayID", param: parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }

        public string NhomThuocTinhChinhSua(NhomThuocTinhRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@TenNhom", request.TenNhom);
                parameters.Add("@MoTa", request.MoTa);

                var result = SqlMapper.ExecuteScalar<string>(connect, "SPNhomThuocTinh_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        public string NhomThuocTinhTaoMoi(NhomThuocTinhRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TenNhom", request.TenNhom);
                parameters.Add("@MoTa", request.MoTa);

                var result = SqlMapper.ExecuteScalar<string>(connect, "SPNhomThuocTinh_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public bool NhomThuocTinhXoaBo(int ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPNhomThuocTinh_XoaBo", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
