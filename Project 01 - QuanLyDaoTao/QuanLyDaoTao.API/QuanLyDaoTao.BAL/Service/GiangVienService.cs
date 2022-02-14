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
    public class GiangVienService : IGiangVienService
    {
        private readonly IGiangVienRepository _giangVienRepository;
        public GiangVienService(IGiangVienRepository giangVienRepository)
        {
            _giangVienRepository = giangVienRepository;
        }

        public List<GiangVienResponse> GiangVienDanhSach(Guid? ID)
        {
            return _giangVienRepository.GiangVienDanhSach(ID);
        }

        public GiangVienResponse GiangVienLayID(Guid ID)
        {
            return _giangVienRepository.GiangVienLayID(ID);
        }

        public int GiangVienChinhSua(GiangVienRequest request)
        {
            return _giangVienRepository.GiangVienChinhSua(request);
        }

        public int GiangVienTaoMoi(GiangVienRequest request)
        {
            return _giangVienRepository.GiangVienTaoMoi(request);
        }

        public bool GiangVienXoaBo(Guid ID)
        {
            return _giangVienRepository.GiangVienXoaBo(ID);
        }

    }
}
