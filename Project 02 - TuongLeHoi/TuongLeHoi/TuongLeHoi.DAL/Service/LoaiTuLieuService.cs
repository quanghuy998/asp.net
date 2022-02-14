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
    public class LoaiTuLieuService : ILoaiTuLieuService
    {
        private readonly ILoaiTuLieuRepository _loaiTuLieuRepository;
        public LoaiTuLieuService(ILoaiTuLieuRepository loaiTuLieuRepository)
        {
            _loaiTuLieuRepository = loaiTuLieuRepository;
        }
        public List<LoaiTuLieuResponse> LoaiTuLieuDanhSach()
        {
            return _loaiTuLieuRepository.LoaiTuLieuDanhSach();
        }

        public LoaiTuLieuResponse LoaiTuLieuLayID(Guid ID)
        {
            return _loaiTuLieuRepository.LoaiTuLieuLayID(ID);
        }

        public string LoaiTuLieuChinhSua(LoaiTuLieuRequest request)
        {
            return _loaiTuLieuRepository.LoaiTuLieuChinhSua(request);
        }

        public string LoaiTuLieuTaoMoi(LoaiTuLieuRequest request)
        {
            return _loaiTuLieuRepository.LoaiTuLieuTaoMoi(request);
        }

        public bool LoaiTuLieuXoaBo(Guid ID)
        {
            return _loaiTuLieuRepository.LoaiTuLieuXoaBo(ID);
        }
    }
}
