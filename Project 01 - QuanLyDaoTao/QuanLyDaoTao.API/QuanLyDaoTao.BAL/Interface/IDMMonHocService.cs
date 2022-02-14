using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.BAL.Interface
{
    public interface IDMMonHocService
    {
        List<DMMonHocResponse> DMMonHocDanhSach(Guid? ID);
        DMMonHocResponse DMMonHocLayID(Guid ID);
        int DMMonHocChinhSua(DMMonHocRequest request);
        int DMMonHocTaoMoi(DMMonHocRequest request);
        bool DMMonHocXoaBo(Guid ID);
    }
}
