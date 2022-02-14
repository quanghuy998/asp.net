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
    public class LopHocRepository : DataBaseRepository, ILophocRepository
    {
        public List<LopHocResponse> LopHocDanhSach(Guid? ID, Guid? CTDaoTaoID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                parameters.Add("@CTDaoTaoID", CTDaoTaoID);
                List<LopHocResponse> danhsach = SqlMapper.Query<LopHocResponse>(connect, "SPLopHoc_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LopHocResponse LopHocLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            LopHocResponse getID = SqlMapper.Query<LopHocResponse>(connect, "SPLopHoc_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int LopHocChinhSua(LopHocRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@MaLop", request.MaLop);
                parameters.Add("@NgayKhaiGiang", request.NgayKhaiGiang);
                parameters.Add("@NgayKetThuc", request.NgayKetThuc);
                parameters.Add("@SoLuongHV", request.SoLuongHV);
                parameters.Add("@QDMoLop", request.QDMoLop);
                parameters.Add("@ThoiKhoaBieu", request.ThoiKhoaBieu);
                parameters.Add("@GhiChu", request.GhiChu);
                parameters.Add("@CTDaoTaoID", request.CTDaoTaoID);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPLopHoc_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int LopHocTaoMoi(LopHocRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@MaLop", request.MaLop);
                parameters.Add("@NgayKhaiGiang", request.NgayKhaiGiang);
                parameters.Add("@NgayKetThuc", request.NgayKetThuc);
                parameters.Add("@SoLuongHV", request.SoLuongHV);
                parameters.Add("@QDMoLop", request.QDMoLop);
                parameters.Add("@ThoiKhoaBieu", request.ThoiKhoaBieu);
                parameters.Add("@GhiChu", request.GhiChu);
                parameters.Add("@CTDaoTaoID", request.CTDaoTaoID);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPLopHoc_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool LopHocXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPLopHoc_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
