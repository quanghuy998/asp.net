using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.BAL.Interface
{
    public interface IBaoLuuService
    {
        List<BaoLuuResponse> BaoLuuDanhSach(Guid? ID);
        BaoLuuResponse BaoLuuLayID(Guid ID);
        int BaoLuuChinhSua(BaoLuuRequest request);
        int BaoLuuTaoMoi(BaoLuuRequest request);
        bool BaoLuuXoaBo(Guid ID);
    }
}
