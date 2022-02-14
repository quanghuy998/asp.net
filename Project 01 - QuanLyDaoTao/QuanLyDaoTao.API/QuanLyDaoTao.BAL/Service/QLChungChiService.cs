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
    public class QLChungChiService : IQLChungChiService
    {
        private readonly IQLChungChiRepository _qlChungChiRepository;
        public QLChungChiService(IQLChungChiRepository qlChungChiRepository)
        {
            _qlChungChiRepository = qlChungChiRepository;
        }

        public List<QLChungChiResponse> QLChungChiDanhSach(Guid? ID)
        {
            return _qlChungChiRepository.QLChungChiDanhSach(ID);
        }

        public QLChungChiResponse QLChungChiLayID(Guid ID)
        {
            return _qlChungChiRepository.QLChungChiLayID(ID);
        }

        public int QLChungChiChinhSua(QLChungChiRequest request)
        {
            return _qlChungChiRepository.QLChungChiChinhSua(request);
        }

        public int QLChungChiTaoMoi(QLChungChiRequest request)
        {
            return _qlChungChiRepository.QLChungChiTaoMoi(request);
        }

        public bool QLChungChiXoaBo(Guid ID)
        {
            return _qlChungChiRepository.QLChungChiXoaBo(ID);
        }

    }
}
