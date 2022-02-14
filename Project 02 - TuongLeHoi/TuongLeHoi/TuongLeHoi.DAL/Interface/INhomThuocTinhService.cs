using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoiDomain.Request;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.BAL.Interface
{
    public interface INhomThuocTinhService
    {
        List<NhomThuocTinhResponse> NhomThuocTinhDanhSach();
        NhomThuocTinhResponse NhomThuocTinhLayID(int ID);
        string NhomThuocTinhChinhSua(NhomThuocTinhRequest request);
        string NhomThuocTinhTaoMoi(NhomThuocTinhRequest request);
        bool NhomThuocTinhXoaBo(int ID);
    }
}
