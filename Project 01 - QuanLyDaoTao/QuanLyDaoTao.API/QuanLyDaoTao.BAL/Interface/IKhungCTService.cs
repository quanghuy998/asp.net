using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.BAL.Interface
{
    public interface IKhungCTService
    {
        List<KhungCTResponse> KhungCTDanhSach(Guid? ID);
        KhungCTResponse KhungCTLayID(Guid ID);
        int KhungCTChinhSua(KhungCTRequest request);
        int KhungCTTaoMoi(KhungCTRequest request);
        bool KhungCTXoaBo(Guid ID);
    }
}
