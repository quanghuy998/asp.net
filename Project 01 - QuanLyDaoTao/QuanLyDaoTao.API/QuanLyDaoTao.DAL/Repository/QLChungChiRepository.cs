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
    public class QLChungChiRepository : DataBaseRepository, IQLChungChiRepository
    {

        public List<QLChungChiResponse> QLChungChiDanhSach(Guid? ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                List<QLChungChiResponse> danhsach = SqlMapper.Query<QLChungChiResponse>(connect, "SPQLChungChi_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public QLChungChiResponse QLChungChiLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            QLChungChiResponse getID = SqlMapper.Query<QLChungChiResponse>(connect, "SPQLChungChi_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int QLChungChiChinhSua(QLChungChiRequest request)
        {
            throw new NotImplementedException();
        }
        public int QLChungChiTaoMoi(QLChungChiRequest request)
        {
            throw new NotImplementedException();
        }

        public bool QLChungChiXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPQLChungChi_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
