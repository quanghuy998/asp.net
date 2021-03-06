using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoiDomain.Request;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.BAL.Interface
{
    public interface ITuLieuService
    {
        List<TuLieuResponse> TuLieuDanhSach(Guid ID);
        TuLieuResponse TuLieuLayID(Guid ID);
        string TuLieuChinhSua(TuLieuRequest request);
        string TuLieuTaoMoi(TuLieuRequest request);
        bool TuLieuXoaBo(Guid ID);
    }
}
