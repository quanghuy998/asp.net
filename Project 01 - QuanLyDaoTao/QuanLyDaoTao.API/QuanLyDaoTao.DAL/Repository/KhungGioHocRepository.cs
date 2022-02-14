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
    public class KhungGioHocRepository : DataBaseRepository, IKhungGioHocRepository
    {
        public List<KhungGioHocResponse> KhungGioHocDanhSach(Guid? ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                List<KhungGioHocResponse> danhsach = SqlMapper.Query<KhungGioHocResponse>(connect, "SPKhungGioHoc_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public KhungGioHocResponse KhungGioHocLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            KhungGioHocResponse getID = SqlMapper.Query<KhungGioHocResponse>(connect, "SPKhungGioHoc_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int KhungGioHocChinhSua(KhungGioHocRequest request)
        {
            throw new NotImplementedException();
        }

        public int KhungGioHocTaoMoi(KhungGioHocRequest request)
        {
            throw new NotImplementedException();
        }

        public bool KhungGioHocXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPKhungGioHoc_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
