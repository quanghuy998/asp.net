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
    public class BoTriPHController
    {
        private readonly IBoTriPHService _BoTriPHService;
        public BoTriPHController(IBoTriPHService BoTriPHService)
        {
            _BoTriPHService = BoTriPHService;
        }
        [HttpGet]
        public IEnumerable<BoTriPHResponse> BoTriPHDanhSach(Guid? ID)
        {
            return _BoTriPHService.BoTriPHDanhSach(ID);
        }
        [HttpGet("{id}")]
        public BoTriPHResponse BoTriPHLayID(Guid ID)
        {
            return _BoTriPHService.BoTriPHLayID(ID);
        }
        [HttpPut]
        public int BoTriPHChinhSua([FromBody] BoTriPHRequest request)
        {
            return _BoTriPHService.BoTriPHChinhSua(request);
        }
        [HttpPost]
        public int BoTriPHTaoMoi([FromBody] BoTriPHRequest request)
        {
            return _BoTriPHService.BoTriPHTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool BoTriPHXoaBo(Guid ID)
        {
            return _BoTriPHService.BoTriPHXoaBo(ID);
        }

    }
}
