using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.DAL.Interface
{
    public interface IBaoLuuRepository
    {
        List<BaoLuuResponse> BaoLuuDanhSach(Guid? ID);
        BaoLuuResponse BaoLuuLayID(Guid ID);
        int BaoLuuChinhSua(BaoLuuRequest request);
        int BaoLuuTaoMoi(BaoLuuRequest request);
        bool BaoLuuXoaBo(Guid ID);
    }
}
