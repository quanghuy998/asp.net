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
    public class MonHocService : IMonHocService
    {
        private readonly IMonHocRepository _monHocRepository;
        public MonHocService(IMonHocRepository monHocRepository)
        {
            _monHocRepository = monHocRepository;
        }
        public int MonHocChinhSua(MonHocRequest request)
        {
            return _monHocRepository.MonHocChinhSua(request);
        }

        public List<MonHocResponse> MonHocDanhSach(Guid? ID, Guid? CTDaoTaoID)
        {
            return _monHocRepository.MonHocDanhSach(ID, CTDaoTaoID);
        }

        public MonHocResponse MonHocLayID(Guid ID)
        {
            return _monHocRepository.MonHocLayID(ID);
        }

        public int MonHocTaoMoi(MonHocRequest request)
        {
            return _monHocRepository.MonHocTaoMoi(request);
        }

        public bool MonHocXoaBo(Guid ID)
        {
            return _monHocRepository.MonHocXoaBo(ID);
        }
    }
}
