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
    public class BaoLuuService : IBaoLuuService
    {
        private readonly IBaoLuuRepository _baoLuuRepository;
        public BaoLuuService(IBaoLuuRepository baoLuuRepository)
        {
            _baoLuuRepository = baoLuuRepository;
        }
        public List<BaoLuuResponse> BaoLuuDanhSach(Guid? ID)
        {
            return _baoLuuRepository.BaoLuuDanhSach(ID);
        }

        public BaoLuuResponse BaoLuuLayID(Guid ID)
        {
            return _baoLuuRepository.BaoLuuLayID(ID);
        }

        public int BaoLuuChinhSua(BaoLuuRequest request)
        {
            return _baoLuuRepository.BaoLuuChinhSua(request);
        }

        public int BaoLuuTaoMoi(BaoLuuRequest request)
        {
            return _baoLuuRepository.BaoLuuTaoMoi(request);
        }

        public bool BaoLuuXoaBo(Guid ID)
        {
            return _baoLuuRepository.BaoLuuXoaBo(ID);
        }
    }
}
