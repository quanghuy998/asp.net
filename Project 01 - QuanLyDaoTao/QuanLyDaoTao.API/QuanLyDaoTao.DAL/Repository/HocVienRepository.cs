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
    public class HocVienRepository : DataBaseRepository, IHocVienRepository
    {
        public List<HocVienResponse> HocVienDanhSach(Guid? ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                List<HocVienResponse> danhsach = SqlMapper.Query<HocVienResponse>(connect, "SPHocVien_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public HocVienResponse HocVienLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            HocVienResponse getID = SqlMapper.Query<HocVienResponse>(connect, "SPHocVien_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }
        public int HocVienChinhSua(HocVienRequest request)
        {
            throw new NotImplementedException();
        }


        public int HocVienTaoMoi(HocVienRequest request)
        {
            throw new NotImplementedException();
        }

        public bool HocVienXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPHocVien_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
