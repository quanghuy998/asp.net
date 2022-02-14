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
    public class ThuocTinhService : IThuocTinhService
    {
        private readonly IThuocTinhRepository _thuocTinhRepository;
        public ThuocTinhService(IThuocTinhRepository thuocTinhRepository)
        {
            _thuocTinhRepository = thuocTinhRepository;
        }
        public List<ThuocTinhResponse> ThuocTinhDanhSach(int? MaNhom)
        {
            return _thuocTinhRepository.ThuocTinhDanhSach(MaNhom);
        }

        public ThuocTinhResponse ThuocTinhLayID(int ID)
        {
            return _thuocTinhRepository.ThuocTinhLayID(ID);
        }

        public string ThuocTinhChinhSua(ThuocTinhRequest request)
        {
            return _thuocTinhRepository.ThuocTinhChinhSua(request);
        }

        public string ThuocTinhTaoMoi(ThuocTinhRequest request)
        {
            return _thuocTinhRepository.ThuocTinhTaoMoi(request);
        }

        public bool ThuocTinhXoaBo(int ID)
        {
            return _thuocTinhRepository.ThuocTinhXoaBo(ID);
        }
    }
}
