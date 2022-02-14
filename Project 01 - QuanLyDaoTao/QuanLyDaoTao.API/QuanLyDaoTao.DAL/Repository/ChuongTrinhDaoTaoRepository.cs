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

namespace QuanLyDaoTao.DAL.Repository
{
    public class ChuongTrinhDaoTaoRepository : DataBaseRepository, IChuongTrinhDaoTaoRepository
    {
        // Danh sách chương trình đào tạo
        public IList<CTDaoTaoResponse> CTDTDanhSach(int TrangThai, string MaCT)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TrangThai", TrangThai);
                parameters.Add("@MaCT", MaCT);
                IList<CTDaoTaoResponse> danhSach = SqlMapper.Query<CTDaoTaoResponse>(connect, "SPChuongTrinhDaoTao_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Lấy mã chương trình đào tạo
        public CTDaoTaoResponse CTDTLayMaCT(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            CTDaoTaoResponse layCTDT = SqlMapper.Query<CTDaoTaoResponse>(connect, "SPChuongTrinhDaoTao_LayMaCT", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return layCTDT;
        }
        
        // Chỉnh sửa chương trình đào tạo
        public int CTDTChinhSua(CTDaoTaoRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@MaCT", request.MaCT);
                parameters.Add("@TenCT", request.TenCT);
                parameters.Add("@HocPhi", request.HocPhi);
                parameters.Add("@NgayBanHanh", request.NgayBanHanh);
                parameters.Add("@QDBanHanh", request.QDBanHanh);
                parameters.Add("@NoiDungCT", request.NoiDungCT);
                parameters.Add("@GhiChu", request.GhiChu);
                parameters.Add("@TrangThai", request.TrangThai);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPChuongTrinhDaoTao_Sua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Tạo mới chương trình đào tạo
        public int CTDTTaoMoi(CTDaoTaoRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@MaCT", request.MaCT);
                parameters.Add("@TenCT", request.TenCT);
                parameters.Add("@HocPhi", request.HocPhi);
                parameters.Add("@NgayBanHanh", request.NgayBanHanh);
                parameters.Add("@QDBanHanh", request.QDBanHanh);
                parameters.Add("@NoiDungCT", request.NoiDungCT);
                parameters.Add("@GhiChu", request.GhiChu);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPChuongTrinhDaoTao_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CTDTXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPChuongTrinhDaoTao_Xoa", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
