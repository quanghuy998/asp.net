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
    public class KhungGioHocService : IKhungGioHocService
    {
        private readonly IKhungGioHocRepository _khungGioHocRepository;
        public KhungGioHocService(IKhungGioHocRepository khungGioHocRepository)
        {
            _khungGioHocRepository = khungGioHocRepository;
        }

        public List<KhungGioHocResponse> KhungGioHocDanhSach(Guid? ID)
        {
            return _khungGioHocRepository.KhungGioHocDanhSach(ID);
        }

        public KhungGioHocResponse KhungGioHocLayID(Guid ID)
        {
            return _khungGioHocRepository.KhungGioHocLayID(ID);
        }

        public int KhungGioHocChinhSua(KhungGioHocRequest request)
        {
            return _khungGioHocRepository.KhungGioHocChinhSua(request);
        }

        public int KhungGioHocTaoMoi(KhungGioHocRequest request)
        {
            return _khungGioHocRepository.KhungGioHocTaoMoi(request);
        }

        public bool KhungGioHocXoaBo(Guid ID)
        {
            return _khungGioHocRepository.KhungGioHocXoaBo(ID);
        }

    }
}
