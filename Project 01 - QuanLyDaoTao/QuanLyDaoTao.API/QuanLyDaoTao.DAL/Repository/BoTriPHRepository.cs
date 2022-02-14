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
    public class BoTriPHRepository : DataBaseRepository, IBoTriPHRepository
    {
        public List<BoTriPHResponse> BoTriPHDanhSach(Guid? ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                List<BoTriPHResponse> danhsach = SqlMapper.Query<BoTriPHResponse>(connect, "SPBoTriPhongHoc_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BoTriPHResponse BoTriPHLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            BoTriPHResponse getID = SqlMapper.Query<BoTriPHResponse>(connect, "SPBoTriPhongHoc_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int BoTriPHChinhSua(BoTriPHRequest request)
        {
            throw new NotImplementedException();
        }

        public int BoTriPHTaoMoi(BoTriPHRequest request)
        {
            throw new NotImplementedException();
        }

        public bool BoTriPHXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPBoTriPhongHoc_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
