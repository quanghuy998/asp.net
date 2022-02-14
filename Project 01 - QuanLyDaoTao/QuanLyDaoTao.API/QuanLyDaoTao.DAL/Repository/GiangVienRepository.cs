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
    public class GiangVienRepository : DataBaseRepository, IGiangVienRepository
    {
        public List<GiangVienResponse> GiangVienDanhSach(Guid? ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                List<GiangVienResponse> danhsach = SqlMapper.Query<GiangVienResponse>(connect, "SPGiangVien_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public GiangVienResponse GiangVienLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            GiangVienResponse getID = SqlMapper.Query<GiangVienResponse>(connect, "SPGiangVien_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }
        public int GiangVienChinhSua(GiangVienRequest request)
        {
            throw new NotImplementedException();
        }


        public int GiangVienTaoMoi(GiangVienRequest request)
        {
            throw new NotImplementedException();
        }

        public bool GiangVienXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPGiangVien_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
