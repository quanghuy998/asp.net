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
    public class ThiCuController
    {
        private readonly IThiCuService _ThiCuService;
        public ThiCuController(IThiCuService ThiCuService)
        {
            _ThiCuService = ThiCuService;
        }
        [HttpGet]
        public IEnumerable<ThiCuResponse> ThiCuDanhSach(Guid? ID)
        {
            return _ThiCuService.ThiCuDanhSach(ID);
        }
        [HttpGet("{id}")]
        public ThiCuResponse ThiCuLayID(Guid ID)
        {
            return _ThiCuService.ThiCuLayID(ID);
        }
        [HttpPut]
        public int ThiCuChinhSua([FromBody] ThiCuRequest request)
        {
            return _ThiCuService.ThiCuChinhSua(request);
        }
        [HttpPost]
        public int ThiCuTaoMoi([FromBody] ThiCuRequest request)
        {
            return _ThiCuService.ThiCuTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool ThiCuXoaBo(Guid ID)
        {
            return _ThiCuService.ThiCuXoaBo(ID);
        }

    }
}
