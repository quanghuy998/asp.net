using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.DAL.Interface
{
    public interface IThoiKhoaBieuRepository
    {
        List<ThoiKhoaBieuResponse> ThoiKhoaBieuDanhSach(Guid? ID);
        ThoiKhoaBieuResponse ThoiKhoaBieuLayID(Guid ID);
        int ThoiKhoaBieuChinhSua(ThoiKhoaBieuRequest request);
        int ThoiKhoaBieuTaoMoi(ThoiKhoaBieuRequest request);
        bool ThoiKhoaBieuXoaBo(Guid ID);
    }
}
