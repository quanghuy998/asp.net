using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.BAL.Interface
{
    public interface IThongTinTuLieuService
    {
        List<ThongTinTuLieuResponse> ThongTinTuLieuLayID(Guid ID);
        List<ThongTinTuLieuThuocTinhResponse> ThongTinTuLieuThuocTinh(Guid MaLoaiTuLieu);
    }
}
