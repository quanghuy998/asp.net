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
    public class ThoiKhoaBieuRepository : DataBaseRepository, IThoiKhoaBieuRepository
    {
        public List<ThoiKhoaBieuResponse> ThoiKhoaBieuDanhSach(Guid? ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                List<ThoiKhoaBieuResponse> danhsach = SqlMapper.Query<ThoiKhoaBieuResponse>(connect, "SPThoiKhoaBieu_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ThoiKhoaBieuResponse ThoiKhoaBieuLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            ThoiKhoaBieuResponse getID = SqlMapper.Query<ThoiKhoaBieuResponse>(connect, "SPThoiKhoaBieu_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int ThoiKhoaBieuChinhSua(ThoiKhoaBieuRequest request)
        {
            throw new NotImplementedException();
        }

        public int ThoiKhoaBieuTaoMoi(ThoiKhoaBieuRequest request)
        {
            throw new NotImplementedException();
        }

        public bool ThoiKhoaBieuXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPThoiKhoaBieu_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
