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
    public class PhongHocRepository : DataBaseRepository, IPhongHocRepository
    {
        public List<PhongHocResponse> PhongHocDanhSach(Guid? ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                List<PhongHocResponse> danhsach = SqlMapper.Query<PhongHocResponse>(connect, "SPPhongHoc_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PhongHocResponse PhongHocLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            PhongHocResponse getID = SqlMapper.Query<PhongHocResponse>(connect, "SPPhongHoc_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int PhongHocChinhSua(PhongHocRequest request)
        {
            throw new NotImplementedException();
        }

        public int PhongHocTaoMoi(PhongHocRequest request)
        {
            throw new NotImplementedException();
        }

        public bool PhongHocXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPPhongHoc_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
