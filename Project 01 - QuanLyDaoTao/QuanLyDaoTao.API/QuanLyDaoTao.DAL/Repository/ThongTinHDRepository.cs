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
    public class ThongTinHDRepository : DataBaseRepository, IThongTinHDRepository
    {
        public List<ThongTinHDResponse> ThongTinHDDanhSach(Guid? ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                List<ThongTinHDResponse> danhsach = SqlMapper.Query<ThongTinHDResponse>(connect, "SPThongTinHD_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ThongTinHDResponse ThongTinHDLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            ThongTinHDResponse getID = SqlMapper.Query<ThongTinHDResponse>(connect, "SPThongTinHD_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }
        public int ThongTinHDChinhSua(ThongTinHDRequest request)
        {
            throw new NotImplementedException();
        }


        public int ThongTinHDTaoMoi(ThongTinHDRequest request)
        {
            throw new NotImplementedException();
        }

        public bool ThongTinHDXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPThongTinHD_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
