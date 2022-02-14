using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoi.DAL.Interface;
using TuongLeHoiDomain.Request;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.DAL.Repository
{
    public class TuLieuRepository : DataBaseRepository, ITuLieuRepository
    {
        public List<TuLieuResponse> TuLieuDanhSach(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                List<TuLieuResponse> list = SqlMapper.Query<TuLieuResponse>(connect, "SPTuLieu_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TuLieuResponse TuLieuLayID(Guid ID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", ID);
            TuLieuResponse response = SqlMapper.Query<TuLieuResponse>(connect, "SPTuLieu_LayID", param: parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }

        public string TuLieuChinhSua(TuLieuRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@TenTuLieu", request.TenTuLieu);
                parameters.Add("@HinhAnh", request.HinhAnh);
                parameters.Add("@MoTa", request.MoTa);
                parameters.Add("@NguoiTao", request.NguoiTao);
                parameters.Add("@NguoiCapNhatCuoi", request.NguoiCapNhatCuoi);
                parameters.Add("@MaLoaiTuLieu", request.MaLoaiTuLieu);
                var result = SqlMapper.ExecuteScalar<string>(connect, "SPTuLieu_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string TuLieuTaoMoi(TuLieuRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@TenTuLieu", request.TenTuLieu);
                parameters.Add("@HinhAnh", request.HinhAnh);
                parameters.Add("@MoTa", request.MoTa);
                parameters.Add("@NguoiTao", request.NguoiTao);
                parameters.Add("@NguoiCapNhatCuoi", request.NguoiCapNhatCuoi);
                parameters.Add("@MaLoaiTuLieu", request.MaLoaiTuLieu);
                var result = SqlMapper.ExecuteScalar<string>(connect, "SPTuLieu_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public bool TuLieuXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", ID);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPTuLieu_XoaBo", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
