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
    public class LopHocService : ILopHocService
    {
        private ILophocRepository _lophocRepository ;
        public LopHocService(ILophocRepository lophocRepository)
        {
            _lophocRepository = lophocRepository;
        }

        public List<LopHocResponse> LopHocDanhSach(Guid? ID, Guid? CTDaoTaoID)
        {
            return _lophocRepository.LopHocDanhSach(ID, CTDaoTaoID);
        }

        public LopHocResponse LopHocLayID(Guid ID)
        {
            return _lophocRepository.LopHocLayID(ID);
        }

        public int LopHocChinhSua(LopHocRequest request)
        {
            return _lophocRepository.LopHocChinhSua(request);
        }

        public int LopHocTaoMoi(LopHocRequest request)
        {
            return _lophocRepository.LopHocTaoMoi(request);
        }

        public bool LopHocXoaBo(Guid ID)
        {
            return _lophocRepository.LopHocXoaBo(ID);
        }
    }
}
