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
    public class BaoLuuRepository : DataBaseRepository, IBaoLuuRepository
    {
        public List<BaoLuuResponse> BaoLuuDanhSach(Guid? ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                List<BaoLuuResponse> danhsach = SqlMapper.Query<BaoLuuResponse>(connect, "SPBaoLuu_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaoLuuResponse BaoLuuLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            BaoLuuResponse getID = SqlMapper.Query<BaoLuuResponse>(connect, "SPBaoLuu_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int BaoLuuChinhSua(BaoLuuRequest request)
        {
            throw new NotImplementedException();
        }

        public int BaoLuuTaoMoi(BaoLuuRequest request)
        {
            throw new NotImplementedException();
        }

        public bool BaoLuuXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPBaoLuu_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
