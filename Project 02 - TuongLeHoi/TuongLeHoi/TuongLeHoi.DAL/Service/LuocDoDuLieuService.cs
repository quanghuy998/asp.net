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
    public class LuocDoDuLieuService : ILuocDoDuLieuService
    {
        private readonly ILuocDoDuLieuRepository _luocDoDuLieuRepository;
        public LuocDoDuLieuService(ILuocDoDuLieuRepository luocDoDuLieuRepository)
        {
            _luocDoDuLieuRepository = luocDoDuLieuRepository;
        }
        public List<LuocDoDuLieuResponse> LuocDoDuLieuDanhSach()
        {
            return _luocDoDuLieuRepository.LuocDoDuLieuDanhSach();
        }

        public LuocDoDuLieuResponse LuocDoDuLieuLayID(int ID)
        {
            return _luocDoDuLieuRepository.LuocDoDuLieuLayID(ID);
        }

        public string LuocDoDuLieuChinhSua(LuocDoDuLieuRequest request)
        {
            return _luocDoDuLieuRepository.LuocDoDuLieuChinhSua(request);
        }

        public string LuocDoDuLieuTaoMoi(LuocDoDuLieuRequest request)
        {
            return _luocDoDuLieuRepository.LuocDoDuLieuTaoMoi(request);
        }

        public bool LuocDoDuLieuXoaBo(int ID)
        {
            return _luocDoDuLieuRepository.LuocDoDuLieuXoaBo(ID);
        }
    }
}
