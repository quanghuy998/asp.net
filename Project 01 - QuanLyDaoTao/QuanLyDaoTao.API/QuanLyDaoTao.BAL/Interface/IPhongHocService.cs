using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.BAL.Interface
{
    public interface IPhongHocService
    {
        List<PhongHocResponse> PhongHocDanhSach(Guid? ID);
        PhongHocResponse PhongHocLayID(Guid ID);
        int PhongHocChinhSua(PhongHocRequest request);
        int PhongHocTaoMoi(PhongHocRequest request);
        bool PhongHocXoaBo(Guid ID);
    }
}
