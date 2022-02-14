using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.DAL.Interface
{
    public interface IThongTinHDRepository
    {
        List<ThongTinHDResponse> ThongTinHDDanhSach(Guid? ID);
        ThongTinHDResponse ThongTinHDLayID(Guid ID);
        int ThongTinHDChinhSua(ThongTinHDRequest request);
        int ThongTinHDTaoMoi(ThongTinHDRequest request);
        bool ThongTinHDXoaBo(Guid ID);
    }
}
