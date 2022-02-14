using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoiDomain.Request;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.DAL.Interface
{
    public interface IThongTinMoTaRepository
    {
        List<ThongTinMoTaResponse> ThongTinMoTaDanhSach();
        ThongTinMoTaResponse ThongTinMoTaLayID(int ID);
        string ThongTinMoTaChinhSua(ThongTinMoTaRequest request);
        string ThongTinMoTaTaoMoi(ThongTinMoTaRequest request);
        bool ThongTinMoTaXoaBo(int ID);
    }
}
