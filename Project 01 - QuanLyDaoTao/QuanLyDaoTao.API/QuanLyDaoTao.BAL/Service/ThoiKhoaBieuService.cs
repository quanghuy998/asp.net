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
    public class ThoiKhoaBieuService : IThoiKhoaBieuService
    {
        private readonly IThoiKhoaBieuRepository _thoiKhoaBieuRepository;
        public ThoiKhoaBieuService(IThoiKhoaBieuRepository thoiKhoaBieuRepository)
        {
            _thoiKhoaBieuRepository = thoiKhoaBieuRepository;
        }

        public List<ThoiKhoaBieuResponse> ThoiKhoaBieuDanhSach(Guid? ID)
        {
            return _thoiKhoaBieuRepository.ThoiKhoaBieuDanhSach(ID);
        }

        public ThoiKhoaBieuResponse ThoiKhoaBieuLayID(Guid ID)
        {
            return _thoiKhoaBieuRepository.ThoiKhoaBieuLayID(ID);
        }

        public int ThoiKhoaBieuChinhSua(ThoiKhoaBieuRequest request)
        {
            return _thoiKhoaBieuRepository.ThoiKhoaBieuChinhSua(request);
        }

        public int ThoiKhoaBieuTaoMoi(ThoiKhoaBieuRequest request)
        {
            return _thoiKhoaBieuRepository.ThoiKhoaBieuTaoMoi(request);
        }

        public bool ThoiKhoaBieuXoaBo(Guid ID)
        {
            return _thoiKhoaBieuRepository.ThoiKhoaBieuXoaBo(ID);
        }

    }
}
