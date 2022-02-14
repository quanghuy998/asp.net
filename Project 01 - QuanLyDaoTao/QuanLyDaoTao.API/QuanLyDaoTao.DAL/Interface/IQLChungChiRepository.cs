using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.DAL.Interface
{
    public interface IQLChungChiRepository
    {
        List<QLChungChiResponse> QLChungChiDanhSach(Guid? ID);
        QLChungChiResponse QLChungChiLayID(Guid ID);
        int QLChungChiChinhSua(QLChungChiRequest request);
        int QLChungChiTaoMoi(QLChungChiRequest request);
        bool QLChungChiXoaBo(Guid ID);
    }
}
