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
    public class ThiCuRepository : DataBaseRepository, IThiCuRepository
    {
        public List<ThiCuResponse> ThiCuDanhSach(Guid? ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                List<ThiCuResponse> danhsach = SqlMapper.Query<ThiCuResponse>(connect, "SPThiCu_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ThiCuResponse ThiCuLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            ThiCuResponse getID = SqlMapper.Query<ThiCuResponse>(connect, "SPThiCu_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }
        public int ThiCuChinhSua(ThiCuRequest request)
        {
            throw new NotImplementedException();
        }


        public int ThiCuTaoMoi(ThiCuRequest request)
        {
            throw new NotImplementedException();
        }

        public bool ThiCuXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPThiCu_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
