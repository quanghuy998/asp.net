using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuongLeHoi.BAL.Interface;
using TuongLeHoi.DAL.Interface;
using TuongLeHoiDomain.Request;
using TuongLeHoiDomain.Response;

namespace TuongLeHoi.BAL.Service
{
    public class ThongTinMoTaService : IThongTinMoTaService
    {
        private readonly IThongTinMoTaRepository _thongTinMoTaRepository;
        public ThongTinMoTaService(IThongTinMoTaRepository thongTinMoTaRepository)
        {
            _thongTinMoTaRepository = thongTinMoTaRepository;
        }
        public List<ThongTinMoTaResponse> ThongTinMoTaDanhSach()
        {
            return _thongTinMoTaRepository.ThongTinMoTaDanhSach();
        }

        public ThongTinMoTaResponse ThongTinMoTaLayID(int ID)
        {
            return _thongTinMoTaRepository.ThongTinMoTaLayID(ID);
        }

        public string ThongTinMoTaChinhSua(ThongTinMoTaRequest request)
        {
            return _thongTinMoTaRepository.ThongTinMoTaChinhSua(request);
        }

        public string ThongTinMoTaTaoMoi(ThongTinMoTaRequest request)
        {
            return _thongTinMoTaRepository.ThongTinMoTaTaoMoi(request);
        }

        public bool ThongTinMoTaXoaBo(int ID)
        {
            return _thongTinMoTaRepository.ThongTinMoTaXoaBo(ID);
        }
    }
}
