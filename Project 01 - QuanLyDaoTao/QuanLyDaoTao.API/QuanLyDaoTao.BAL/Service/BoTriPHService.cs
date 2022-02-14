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
    public class BoTriPHService : IBoTriPHService
    {
        private readonly IBoTriPHRepository _boTriPHRepository;
        public BoTriPHService(IBoTriPHRepository boTriPHRepository)
        {
            _boTriPHRepository = boTriPHRepository;
        }

        public List<BoTriPHResponse> BoTriPHDanhSach(Guid? ID)
        {
            return _boTriPHRepository.BoTriPHDanhSach(ID);
        }

        public BoTriPHResponse BoTriPHLayID(Guid ID)
        {
            return _boTriPHRepository.BoTriPHLayID(ID);
        }

        public int BoTriPHChinhSua(BoTriPHRequest request)
        {
            return _boTriPHRepository.BoTriPHChinhSua(request);
        }

        public int BoTriPHTaoMoi(BoTriPHRequest request)
        {
            return _boTriPHRepository.BoTriPHTaoMoi(request);
        }

        public bool BoTriPHXoaBo(Guid ID)
        {
            return _boTriPHRepository.BoTriPHXoaBo(ID);
        }
    }
}
