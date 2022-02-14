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
    public class DMMonHocService : IDMMonHocService
    {
        private readonly IDMMonHocRepository _dMMonHocRepository;
        public DMMonHocService(IDMMonHocRepository dMMonHocRepository)
        {
            _dMMonHocRepository = dMMonHocRepository;
        }

        public List<DMMonHocResponse> DMMonHocDanhSach(Guid? ID)
        {
            return _dMMonHocRepository.DMMonHocDanhSach(ID);
        }

        public DMMonHocResponse DMMonHocLayID(Guid ID)
        {
            return _dMMonHocRepository.DMMonHocLayID(ID);
        }

        public int DMMonHocChinhSua(DMMonHocRequest request)
        {
            return _dMMonHocRepository.DMMonHocChinhSua(request);
        }

        public int DMMonHocTaoMoi(DMMonHocRequest request)
        {
            return _dMMonHocRepository.DMMonHocTaoMoi(request);
        }

        public bool DMMonHocXoaBo(Guid ID)
        {
            return _dMMonHocRepository.DMMonHocXoaBo(ID);
        }

    }
}
