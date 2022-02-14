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
    public class NhomThuocTinhService : INhomThuocTinhService
    {
        private readonly INhomThuocTinhRepository _nhomThuocTinhRepository;
        public NhomThuocTinhService(INhomThuocTinhRepository nhomThuocTinhRepository)
        {
            _nhomThuocTinhRepository = nhomThuocTinhRepository;
        }
        public List<NhomThuocTinhResponse> NhomThuocTinhDanhSach()
        {
            return _nhomThuocTinhRepository.NhomThuocTinhDanhSach();
        }

        public NhomThuocTinhResponse NhomThuocTinhLayID(int ID)
        {
            return _nhomThuocTinhRepository.NhomThuocTinhLayID(ID);
        }

        public string NhomThuocTinhChinhSua(NhomThuocTinhRequest request)
        {
            return _nhomThuocTinhRepository.NhomThuocTinhChinhSua(request);
        }

        public string NhomThuocTinhTaoMoi(NhomThuocTinhRequest request)
        {
            return _nhomThuocTinhRepository.NhomThuocTinhTaoMoi(request);
        }

        public bool NhomThuocTinhXoaBo(int ID)
        {
            return _nhomThuocTinhRepository.NhomThuocTinhXoaBo(ID);
        }
    }
}
