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
    public class QLChungChiController
    {
        private readonly IQLChungChiService _QLChungChiService;
        public QLChungChiController(IQLChungChiService QLChungChiService)
        {
            _QLChungChiService = QLChungChiService;
        }
        [HttpGet]
        public IEnumerable<QLChungChiResponse> QLChungChiDanhSach(Guid? ID)
        {
            return _QLChungChiService.QLChungChiDanhSach(ID);
        }
        [HttpGet("{id}")]
        public QLChungChiResponse QLChungChiLayID(Guid ID)
        {
            return _QLChungChiService.QLChungChiLayID(ID);
        }
        [HttpPut]
        public int QLChungChiChinhSua([FromBody] QLChungChiRequest request)
        {
            return _QLChungChiService.QLChungChiChinhSua(request);
        }
        [HttpPost]
        public int QLChungChiTaoMoi([FromBody] QLChungChiRequest request)
        {
            return _QLChungChiService.QLChungChiTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool QLChungChiXoaBo(Guid ID)
        {
            return _QLChungChiService.QLChungChiXoaBo(ID);
        }

    }
}
