using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.DAL.Interface
{
    public interface IPhongHocRepository
    {
        List<PhongHocResponse> PhongHocDanhSach(Guid? ID);
        PhongHocResponse PhongHocLayID(Guid ID);
        int PhongHocChinhSua(PhongHocRequest request);
        int PhongHocTaoMoi(PhongHocRequest request);
        bool PhongHocXoaBo(Guid ID);
    }
}
