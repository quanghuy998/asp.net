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
    public class TuLieuService : ITuLieuService
    {
        private readonly ITuLieuRepository _tuLieuRepository;
        public TuLieuService(ITuLieuRepository tuLieuRepository)
        {
            _tuLieuRepository = tuLieuRepository;
        }
        public List<TuLieuResponse> TuLieuDanhSach(Guid ID)
        {
            return _tuLieuRepository.TuLieuDanhSach(ID);
        }

        public TuLieuResponse TuLieuLayID(Guid ID)
        {
            return _tuLieuRepository.TuLieuLayID(ID);
        }

        public string TuLieuChinhSua(TuLieuRequest request)
        {
            return _tuLieuRepository.TuLieuChinhSua(request);
        }

        public string TuLieuTaoMoi(TuLieuRequest request)
        {
            return _tuLieuRepository.TuLieuTaoMoi(request);
        }

        public bool TuLieuXoaBo(Guid ID)
        {
            return _tuLieuRepository.TuLieuXoaBo(ID);
        }
    }
}
