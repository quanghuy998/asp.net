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
    public class PhongHocService : IPhongHocService
    {
        private readonly IPhongHocRepository _phongHocRepository;
        public PhongHocService(IPhongHocRepository phongHocRepository)
        {
            _phongHocRepository = phongHocRepository;
        }

        public List<PhongHocResponse> PhongHocDanhSach(Guid? ID)
        {
            return _phongHocRepository.PhongHocDanhSach(ID);
        }

        public PhongHocResponse PhongHocLayID(Guid ID)
        {
            return _phongHocRepository.PhongHocLayID(ID);
        }

        public int PhongHocChinhSua(PhongHocRequest request)
        {
            return _phongHocRepository.PhongHocChinhSua(request);
        }

        public int PhongHocTaoMoi(PhongHocRequest request)
        {
            return _phongHocRepository.PhongHocTaoMoi(request);
        }

        public bool PhongHocXoaBo(Guid ID)
        {
            return _phongHocRepository.PhongHocXoaBo(ID);
        }

    }
}
