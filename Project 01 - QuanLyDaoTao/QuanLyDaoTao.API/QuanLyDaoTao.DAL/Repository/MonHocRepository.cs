using Dapper;
using QuanLyDaoTao.DAL.Interface;
using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.DAL.Repository
{
    public class MonHocRepository : DataBaseRepository, IMonHocRepository
    {
        public List<MonHocResponse> MonHocDanhSach(Guid? ID, Guid? CTDaoTaoID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                parameters.Add("@CTDaoTaoID", CTDaoTaoID);
                List<MonHocResponse> danhsach = SqlMapper.Query<MonHocResponse>(connect, "SPMonHoc_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MonHocResponse MonHocLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            MonHocResponse getID = SqlMapper.Query<MonHocResponse>(connect, "SPMonHoc_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int MonHocChinhSua(MonHocRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@MaMonHoc", request.MaMonHoc);
                parameters.Add("@TenMonHoc", request.TenMonHoc);
                parameters.Add("@SoGio", request.SoGio);
                parameters.Add("@GhiChu", request.GhiChu);
                parameters.Add("@CTDaoTaoID", request.CTDaoTaoID);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPMonHoc_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int MonHocTaoMoi(MonHocRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaMonHoc", request.MaMonHoc);
                parameters.Add("@TenMonHoc", request.TenMonHoc);
                parameters.Add("@SoGio", request.SoGio);
                parameters.Add("@GhiChu", request.GhiChu);
                parameters.Add("@CTDaoTaoID", request.CTDaoTaoID);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPMonHoc_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool MonHocXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPMonHoc_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
