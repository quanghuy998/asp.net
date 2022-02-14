using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoi.DAL.Interface;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.DAL.Repository
{
    public class ThongTinTuLieuRepository : DataBaseRepository, IThongTinTuLieuRepository
    {
        public List<ThongTinTuLieuResponse> ThongTinTuLieuLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            List<ThongTinTuLieuResponse> list = SqlMapper.Query<ThongTinTuLieuResponse>(connect, "SPThongTinTuLieu_LayID", param: parameters, commandType: CommandType.StoredProcedure).ToList();
            return list;
        }

        public List<ThongTinTuLieuThuocTinhResponse> ThongTinTuLieuThuocTinh(Guid MaLoaiTuLieu)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MaLoaiTuLieu", MaLoaiTuLieu);
            List<ThongTinTuLieuThuocTinhResponse> list = SqlMapper.Query<ThongTinTuLieuThuocTinhResponse>(connect, "SPThongTinTuLieu_ThuocTinh", param: parameters, commandType: CommandType.StoredProcedure).ToList();
            return list;
        }
    }
}
