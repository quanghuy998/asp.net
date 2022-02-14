using QuanLyDaoTao.Domain.Response;
using QuanLyDaoTao.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.DAL.Interface
{
    public interface ILophocRepository
    {
        List<LopHocResponse> LopHocDanhSach(Guid? ID, Guid? CTDaoTaoID);
        LopHocResponse LopHocLayID(Guid ID);
        int LopHocChinhSua(LopHocRequest request);
        int LopHocTaoMoi(LopHocRequest request);
        bool LopHocXoaBo(Guid ID);
    }
}
