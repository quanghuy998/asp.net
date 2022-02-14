using QuanLyDaoTao.Domain.Response;
using QuanLyDaoTao.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.DAL.Interface
{
    public interface IChuongTrinhDaoTaoRepository
    {
        IList<CTDaoTaoResponse> CTDTDanhSach(int TrangThai, string MaCT);
        CTDaoTaoResponse CTDTLayMaCT(Guid ID);
        int CTDTChinhSua(CTDaoTaoRequest request);
        int CTDTTaoMoi(CTDaoTaoRequest request);
        bool CTDTXoaBo(Guid ID);
    }
}
