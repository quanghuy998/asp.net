using QuanLyDaoTao.BAL.Interface;
using QuanLyDaoTao.DAL.Interface;
using QuanLyDaoTao.Domain.Response;
using QuanLyDaoTao.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.BAL.Service
{
    public class ChuongTrinhDaoTaoService : IChuongTrinhDaoTaoService
    {
        private IChuongTrinhDaoTaoRepository _chuongTrinhDaoTaoRepository;
        public ChuongTrinhDaoTaoService(IChuongTrinhDaoTaoRepository chuongTrinhDaoTaoRepository)
        {
            _chuongTrinhDaoTaoRepository = chuongTrinhDaoTaoRepository;
        }

        public IList<CTDaoTaoResponse> CTDTDanhSach(int TrangThai, string MaCT)
        {
            return _chuongTrinhDaoTaoRepository.CTDTDanhSach(TrangThai, MaCT);
        }

        public CTDaoTaoResponse CTDTLayMaCT(Guid ID)
        {
            return _chuongTrinhDaoTaoRepository.CTDTLayMaCT(ID);
        }

        public int CTDTChinhSua(CTDaoTaoRequest request)
        {
            return _chuongTrinhDaoTaoRepository.CTDTChinhSua(request);
        }

        public int CTDTTaoMoi(CTDaoTaoRequest request)
        {
            return _chuongTrinhDaoTaoRepository.CTDTTaoMoi(request);
        }

        public bool CTDTXoaBo(Guid ID)
        {
            return _chuongTrinhDaoTaoRepository.CTDTXoaBo(ID);
        }
    }
}
