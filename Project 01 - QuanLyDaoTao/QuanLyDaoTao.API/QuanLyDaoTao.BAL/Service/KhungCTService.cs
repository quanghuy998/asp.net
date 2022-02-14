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
    public class KhungCTService : IKhungCTService
    {
        private readonly IKhungCTRepository _khungCTRepository;
        public KhungCTService(IKhungCTRepository khungCTRepository)
        {
            _khungCTRepository = khungCTRepository;
        }

        public List<KhungCTResponse> KhungCTDanhSach(Guid? ID)
        {
            return _khungCTRepository.KhungCTDanhSach(ID);
        }

        public KhungCTResponse KhungCTLayID(Guid ID)
        {
            return _khungCTRepository.KhungCTLayID(ID);
        }

        public int KhungCTChinhSua(KhungCTRequest request)
        {
            return _khungCTRepository.KhungCTChinhSua(request);
        }

        public int KhungCTTaoMoi(KhungCTRequest request)
        {
            return _khungCTRepository.KhungCTTaoMoi(request);
        }

        public bool KhungCTXoaBo(Guid ID)
        {
            return _khungCTRepository.KhungCTXoaBo(ID);
        }
    }
}
