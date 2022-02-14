using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.BAL.Interface
{
    public interface IThiCuService
    {
        List<ThiCuResponse> ThiCuDanhSach(Guid? ID);
        ThiCuResponse ThiCuLayID(Guid ID);
        int ThiCuChinhSua(ThiCuRequest request);
        int ThiCuTaoMoi(ThiCuRequest request);
        bool ThiCuXoaBo(Guid ID);
    }
}
