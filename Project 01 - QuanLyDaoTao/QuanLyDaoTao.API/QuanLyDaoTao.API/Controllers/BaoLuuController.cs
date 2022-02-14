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
    public class BaoLuuController
    {
        private readonly IBaoLuuService _BaoLuuService;
        public BaoLuuController(IBaoLuuService BaoLuuService)
        {
            _BaoLuuService = BaoLuuService;
        }
        [HttpGet]
        public IEnumerable<BaoLuuResponse> BaoLuuDanhSach(Guid? ID)
        {
            return _BaoLuuService.BaoLuuDanhSach(ID);
        }
        [HttpGet("{id}")]
        public BaoLuuResponse BaoLuuLayID(Guid ID)
        {
            return _BaoLuuService.BaoLuuLayID(ID);
        }
        [HttpPut]
        public int BaoLuuChinhSua([FromBody] BaoLuuRequest request)
        {
            return _BaoLuuService.BaoLuuChinhSua(request);
        }
        [HttpPost]
        public int BaoLuuTaoMoi([FromBody] BaoLuuRequest request)
        {
            return _BaoLuuService.BaoLuuTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool BaoLuuXoaBo(Guid ID)
        {
            return _BaoLuuService.BaoLuuXoaBo(ID);
        }

    }
}
