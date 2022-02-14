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
    public class HocVienService : IHocVienService
    {
        private readonly IHocVienRepository _hocVienRepository;
        public HocVienService(IHocVienRepository hocVienRepository)
        {
            _hocVienRepository = hocVienRepository;
        }

        public List<HocVienResponse> HocVienDanhSach(Guid? ID)
        {
            return _hocVienRepository.HocVienDanhSach(ID);
        }

        public HocVienResponse HocVienLayID(Guid ID)
        {
            return _hocVienRepository.HocVienLayID(ID);
        }

        public int HocVienChinhSua(HocVienRequest request)
        {
            return _hocVienRepository.HocVienChinhSua(request);
        }

        public int HocVienTaoMoi(HocVienRequest request)
        {
            return _hocVienRepository.HocVienTaoMoi(request);
        }

        public bool HocVienXoaBo(Guid ID)
        {
            return _hocVienRepository.HocVienXoaBo(ID);
        }

    }
}
