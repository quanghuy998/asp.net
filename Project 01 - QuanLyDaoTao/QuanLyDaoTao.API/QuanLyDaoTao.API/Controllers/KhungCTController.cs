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
    public class KhungCTController
    {
        private readonly IKhungCTService _KhungCTService;
        public KhungCTController(IKhungCTService KhungCTService)
        {
            _KhungCTService = KhungCTService;
        }
        [HttpGet]
        public IEnumerable<KhungCTResponse> KhungCTDanhSach(Guid? ID)
        {
            return _KhungCTService.KhungCTDanhSach(ID);
        }
        [HttpGet("{id}")]
        public KhungCTResponse KhungCTLayID(Guid ID)
        {
            return _KhungCTService.KhungCTLayID(ID);
        }
        [HttpPut]
        public int KhungCTChinhSua([FromBody] KhungCTRequest request)
        {
            return _KhungCTService.KhungCTChinhSua(request);
        }
        [HttpPost]
        public int KhungCTTaoMoi([FromBody] KhungCTRequest request)
        {
            return _KhungCTService.KhungCTTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool KhungCTXoaBo(Guid ID)
        {
            return _KhungCTService.KhungCTXoaBo(ID);
        }

    }
}
