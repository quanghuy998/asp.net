using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.BAL.Interface
{
    public interface IGiangVienService
    {
        List<GiangVienResponse> GiangVienDanhSach(Guid? ID);
        GiangVienResponse GiangVienLayID(Guid ID);
        int GiangVienChinhSua(GiangVienRequest request);
        int GiangVienTaoMoi(GiangVienRequest request);
        bool GiangVienXoaBo(Guid ID);
    }
}
