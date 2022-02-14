using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoiDomain.Request;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.BAL.Interface
{
    public interface IKieuDuLieuService
    {
        List<KieuDuLieuResponse> KieuDuLieuDanhSach();
        KieuDuLieuResponse KieuDuLieuLayID(int ID);
        string KieuDuLieuChinhSua(KieuDuLieuRequest request);
        string KieuDuLieuTaoMoi(KieuDuLieuRequest request);
        bool KieuDuLieuXoaBo(int ID);
    }
}
