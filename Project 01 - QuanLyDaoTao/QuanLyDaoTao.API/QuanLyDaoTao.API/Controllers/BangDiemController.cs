using Microsoft.AspNetCore.Mvc;
using QuanLyDaoTao.BAL.Interface;
using QuanLyDaoTao.Domain.Request;
using QuanLyDaoTao.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDaoTao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BangDiemController
    {
        private readonly IBangDiemService _BangDiemService;
        public BangDiemController(IBangDiemService BangDiemService)
        {
            _BangDiemService = BangDiemService;
        }
        [HttpGet]
        public IEnumerable<BangDiemResponse> BangDiemDanhSach(Guid? CTDaoTaoID, Guid? LopHocID,
                                                 Guid? HocVienID, Guid? MonHocID)
        {
            return _BangDiemService.BangDiemDanhSach(CTDaoTaoID, LopHocID, HocVienID, MonHocID);
        }
        [HttpGet("{id}")]
        public BangDiemResponse BangDiemLayID(Guid ID)
        {
            return _BangDiemService.BangDiemLayID(ID);
        }
        [HttpPut]
        public int BangDiemChinhSua([FromBody] BangDiemRequest request)
        {
            return _BangDiemService.BangDiemChinhSua(request);
        }
        [HttpPost]
        public int BangDiemTaoMoi([FromBody] BangDiemRequest request)
        {
            return _BangDiemService.BangDiemTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool BangDiemXoaBo(Guid ID)
        {
            return _BangDiemService.BangDiemXoaBo(ID);
        }

    }
}
