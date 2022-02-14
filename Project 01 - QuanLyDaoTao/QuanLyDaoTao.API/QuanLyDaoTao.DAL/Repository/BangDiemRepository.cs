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
    public class BangDiemRepository : DataBaseRepository, IBangDiemRepository
    {

        public List<BangDiemResponse> BangDiemDanhSach(Guid? CTDaoTaoID, Guid? LopHocID, Guid? HocVienID, Guid? MonHocID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CTDaoTaoID", CTDaoTaoID);
                parameters.Add("@LopHocID", LopHocID);
                parameters.Add("@HocVienID", HocVienID);
                parameters.Add("@MonHocID", MonHocID);
                List<BangDiemResponse> danhsach = SqlMapper.Query<BangDiemResponse>(connect, "SPBangDiem_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BangDiemResponse BangDiemLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            BangDiemResponse getID = SqlMapper.Query<BangDiemResponse>(connect, "SPBangDiem_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int BangDiemChinhSua(BangDiemRequest request)
        {
            throw new NotImplementedException();
        }

        public int BangDiemTaoMoi(BangDiemRequest request)
        {
            throw new NotImplementedException();
        }

        public bool BangDiemXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPBangDiem_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
