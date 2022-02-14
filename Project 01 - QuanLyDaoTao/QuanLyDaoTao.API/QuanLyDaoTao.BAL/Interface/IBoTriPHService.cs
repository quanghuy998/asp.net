using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.BAL.Interface
{
    public interface IBoTriPHService
    {
        List<BoTriPHResponse> BoTriPHDanhSach(Guid? ID);
        BoTriPHResponse BoTriPHLayID(Guid ID);
        int BoTriPHChinhSua(BoTriPHRequest request);
        int BoTriPHTaoMoi(BoTriPHRequest request);
        bool BoTriPHXoaBo(Guid ID);
    }
}
