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
    public class ThiCuService : IThiCuService
    {
        private readonly IThiCuRepository _thiCuRepository;
        public ThiCuService(IThiCuRepository thiCuRepository)
        {
            _thiCuRepository = thiCuRepository;
        }

        public List<ThiCuResponse> ThiCuDanhSach(Guid? ID)
        {
            return _thiCuRepository.ThiCuDanhSach(ID);
        }

        public ThiCuResponse ThiCuLayID(Guid ID)
        {
            return _thiCuRepository.ThiCuLayID(ID);
        }

        public int ThiCuChinhSua(ThiCuRequest request)
        {
            return _thiCuRepository.ThiCuChinhSua(request);
        }

        public int ThiCuTaoMoi(ThiCuRequest request)
        {
            return _thiCuRepository.ThiCuTaoMoi(request);
        }

        public bool ThiCuXoaBo(Guid ID)
        {
            return _thiCuRepository.ThiCuXoaBo(ID);
        }

    }
}
