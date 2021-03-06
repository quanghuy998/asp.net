using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoiDomain.Request;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.DAL.Interface
{
    public interface ILuocDoDuLieuRepository
    {
        List<LuocDoDuLieuResponse> LuocDoDuLieuDanhSach();
        LuocDoDuLieuResponse LuocDoDuLieuLayID(int ID);
        string LuocDoDuLieuChinhSua(LuocDoDuLieuRequest request);
        string LuocDoDuLieuTaoMoi(LuocDoDuLieuRequest request);
        bool LuocDoDuLieuXoaBo(int ID);
    }
}
