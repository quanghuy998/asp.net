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
    public class KhungGioHocController
    {
        private readonly IKhungGioHocService _KhungGioHocService;
        public KhungGioHocController(IKhungGioHocService KhungGioHocService)
        {
            _KhungGioHocService = KhungGioHocService;
        }
        [HttpGet]
        public IEnumerable<KhungGioHocResponse> KhungGioHocDanhSach(Guid? ID)
        {
            return _KhungGioHocService.KhungGioHocDanhSach(ID);
        }
        [HttpGet("{id}")]
        public KhungGioHocResponse KhungGioHocLayID(Guid ID)
        {
            return _KhungGioHocService.KhungGioHocLayID(ID);
        }
        [HttpPut]
        public int KhungGioHocChinhSua([FromBody] KhungGioHocRequest request)
        {
            return _KhungGioHocService.KhungGioHocChinhSua(request);
        }
        [HttpPost]
        public int KhungGioHocTaoMoi([FromBody] KhungGioHocRequest request)
        {
            return _KhungGioHocService.KhungGioHocTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool KhungGioHocXoaBo(Guid ID)
        {
            return _KhungGioHocService.KhungGioHocXoaBo(ID);
        }

    }
}
