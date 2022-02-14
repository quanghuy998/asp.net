using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.DAL.Interface
{
    public interface IHocVienRepository
    {
        List<HocVienResponse> HocVienDanhSach(Guid? ID);
        HocVienResponse HocVienLayID(Guid ID);
        int HocVienChinhSua(HocVienRequest request);
        int HocVienTaoMoi(HocVienRequest request);
        bool HocVienXoaBo(Guid ID);
    }
}
