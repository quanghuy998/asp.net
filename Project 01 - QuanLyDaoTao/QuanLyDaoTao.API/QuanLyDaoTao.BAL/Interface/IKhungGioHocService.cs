using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.BAL.Interface
{
    public interface IKhungGioHocService
    {
        List<KhungGioHocResponse> KhungGioHocDanhSach(Guid? ID);
        KhungGioHocResponse KhungGioHocLayID(Guid ID);
        int KhungGioHocChinhSua(KhungGioHocRequest request);
        int KhungGioHocTaoMoi(KhungGioHocRequest request);
        bool KhungGioHocXoaBo(Guid ID);
    }
}
