using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoiDomain.Request;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.DAL.Interface
{
    public interface IThuocTinhRepository
    {
        List<ThuocTinhResponse> ThuocTinhDanhSach(int? MaNhom);
        ThuocTinhResponse ThuocTinhLayID(int ID);
        string ThuocTinhChinhSua(ThuocTinhRequest request);
        string ThuocTinhTaoMoi(ThuocTinhRequest request);
        bool ThuocTinhXoaBo(int ID);
    }
}
