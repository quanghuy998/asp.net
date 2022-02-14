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
    public class ThongTinHDService : IThongTinHDService
    {
        private readonly IThongTinHDRepository _thongTinHDRepository;
        public ThongTinHDService(IThongTinHDRepository thongTinHDRepository)
        {
            _thongTinHDRepository = thongTinHDRepository;
        }

        public List<ThongTinHDResponse> ThongTinHDDanhSach(Guid? ID)
        {
            return _thongTinHDRepository.ThongTinHDDanhSach(ID);
        }

        public ThongTinHDResponse ThongTinHDLayID(Guid ID)
        {
            return _thongTinHDRepository.ThongTinHDLayID(ID);
        }

        public int ThongTinHDChinhSua(ThongTinHDRequest request)
        {
            return _thongTinHDRepository.ThongTinHDChinhSua(request);
        }

        public int ThongTinHDTaoMoi(ThongTinHDRequest request)
        {
            return _thongTinHDRepository.ThongTinHDTaoMoi(request);
        }

        public bool ThongTinHDXoaBo(Guid ID)
        {
            return _thongTinHDRepository.ThongTinHDXoaBo(ID);
        }

    }
}
