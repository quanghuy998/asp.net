using QuanLyDaoTao.BAL.Interface;
using QuanLyDaoTao.DAL.Interface;
using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.BAL.Service
{
    public class BangDiemService : IBangDiemService
    {
        private readonly IBangDiemRepository _bangDiemRepository;
        public BangDiemService(IBangDiemRepository bangDiemRepository)
        {
            _bangDiemRepository = bangDiemRepository;
        }
        public List<BangDiemResponse> BangDiemDanhSach(Guid? CTDaoTaoID, Guid? LopHocID, Guid? HocVienID, Guid? MonHocID)
        {
            return _bangDiemRepository.BangDiemDanhSach(CTDaoTaoID, LopHocID, HocVienID, MonHocID);
        }

        public BangDiemResponse BangDiemLayID(Guid ID)
        {
            return _bangDiemRepository.BangDiemLayID(ID);
        }

        public int BangDiemChinhSua(BangDiemRequest request)
        {
            return _bangDiemRepository.BangDiemChinhSua(request);
        }

        public int BangDiemTaoMoi(BangDiemRequest request)
        {
            return _bangDiemRepository.BangDiemTaoMoi(request);
        }

        public bool BangDiemXoaBo(Guid ID)
        {
            return _bangDiemRepository.BangDiemXoaBo(ID);
        }
    }
}
