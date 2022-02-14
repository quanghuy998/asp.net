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
    public class KhungCTRepository : DataBaseRepository, IKhungCTRepository
    {
        public List<KhungCTResponse> KhungCTDanhSach(Guid? ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                List<KhungCTResponse> danhsach = SqlMapper.Query<KhungCTResponse>(connect, "SPKhungCT_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public KhungCTResponse KhungCTLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            KhungCTResponse getID = SqlMapper.Query<KhungCTResponse>(connect, "SPKhungCT_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }
        public int KhungCTChinhSua(KhungCTRequest request)
        {
            throw new NotImplementedException();
        }


        public int KhungCTTaoMoi(KhungCTRequest request)
        {
            throw new NotImplementedException();
        }

        public bool KhungCTXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPKhungCT_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
