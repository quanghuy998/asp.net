using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.DAL.Interface
{
    public interface IMonHocRepository
    {
        List<MonHocResponse> MonHocDanhSach(Guid? ID, Guid? CTDaoTaoID);
        MonHocResponse MonHocLayID(Guid ID);
        int MonHocChinhSua(MonHocRequest request);
        int MonHocTaoMoi(MonHocRequest request);
        bool MonHocXoaBo(Guid ID);
    }
}
