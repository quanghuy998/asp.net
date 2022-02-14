using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.BAL.Interface
{
    public interface IBangDiemService
    {
        List<BangDiemResponse> BangDiemDanhSach(Guid? CTDaoTaoID, Guid? LopHocID,
                                                 Guid? HocVienID, Guid? MonHocID);
        BangDiemResponse BangDiemLayID(Guid ID);
        int BangDiemChinhSua(BangDiemRequest request);
        int BangDiemTaoMoi(BangDiemRequest request);
        bool BangDiemXoaBo(Guid ID);
    }
}
