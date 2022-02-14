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
    public class DMMonHocRepository : DataBaseRepository, IDMMonHocRepository
    {
        public List<DMMonHocResponse> DMMonHocDanhSach(Guid? ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                List<DMMonHocResponse> danhsach = SqlMapper.Query<DMMonHocResponse>(connect, "SPDMMonHoc_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DMMonHocResponse DMMonHocLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            DMMonHocResponse getID = SqlMapper.Query<DMMonHocResponse>(connect, "SPDMMonHoc_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int DMMonHocChinhSua(DMMonHocRequest request)
        {
            throw new NotImplementedException();
        }


        public int DMMonHocTaoMoi(DMMonHocRequest request)
        {
            throw new NotImplementedException();
        }

        public bool DMMonHocXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPDMMonHoc_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
