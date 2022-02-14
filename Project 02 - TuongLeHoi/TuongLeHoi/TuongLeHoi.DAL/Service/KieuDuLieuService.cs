using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoi.BAL.Interface;
using TuongLeHoi.DAL.Interface;
using TuongLeHoiDomain.Request;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.BAL.Service
{
    public class KieuDuLieuService : IKieuDuLieuService
    {
        private readonly IKieuDuLieuRepository _kieuDuLieuRepository;
        public KieuDuLieuService(IKieuDuLieuRepository kieuDuLieuRepository)
        {
            _kieuDuLieuRepository = kieuDuLieuRepository;
        }
        public List<KieuDuLieuResponse> KieuDuLieuDanhSach()
        {
            return _kieuDuLieuRepository.KieuDuLieuDanhSach();
        }

        public KieuDuLieuResponse KieuDuLieuLayID(int ID)
        {
            return _kieuDuLieuRepository.KieuDuLieuLayID(ID);
        }

        public string KieuDuLieuChinhSua(KieuDuLieuRequest request)
        {
            return _kieuDuLieuRepository.KieuDuLieuChinhSua(request);
        }

        public string KieuDuLieuTaoMoi(KieuDuLieuRequest request)
        {
            return _kieuDuLieuRepository.KieuDuLieuTaoMoi(request);
        }

        public bool KieuDuLieuXoaBo(int ID)
        {
            return _kieuDuLieuRepository.KieuDuLieuXoaBo(ID);
        }
    }
}
