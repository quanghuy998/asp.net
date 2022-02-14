using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoi.BAL.Interface;
using TuongLeHoi.DAL.Interface;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.BAL.Service
{
    public class ThongTinTuLieuService : IThongTinTuLieuService
    {
        private readonly IThongTinTuLieuRepository _thongTinTuLieuRepository;
        public ThongTinTuLieuService(IThongTinTuLieuRepository thongTinTuLieuRepository)
        {
            _thongTinTuLieuRepository = thongTinTuLieuRepository;
        }

        public List<ThongTinTuLieuResponse> ThongTinTuLieuLayID(Guid ID)
        {
            return _thongTinTuLieuRepository.ThongTinTuLieuLayID(ID);
        }

        public List<ThongTinTuLieuThuocTinhResponse> ThongTinTuLieuThuocTinh(Guid MaLoaiTuLieu)
        {
            return _thongTinTuLieuRepository.ThongTinTuLieuThuocTinh(MaLoaiTuLieu);
        }
    }
}
