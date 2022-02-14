using Microsoft.AspNetCore.Http;
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
    public class MonHocController : ControllerBase
    {
        private readonly IMonHocService _monHocService;
        public MonHocController(IMonHocService monHocService)
        {
            _monHocService = monHocService;
        }
        [HttpGet]
        public IEnumerable<MonHocResponse> MonHocDanhSach(Guid? ID, Guid? CTDaoTaoID)
        {
            return _monHocService.MonHocDanhSach(ID, CTDaoTaoID);
        }
        [HttpGet("{id}")]
        public MonHocResponse MonHocLayID(Guid ID)
        {
            return _monHocService.MonHocLayID(ID);
        }
        [HttpPut]
        public int MonHocChinhSua([FromBody]MonHocRequest request)
        {
            return _monHocService.MonHocChinhSua(request);
        }
        [HttpPost]
        public int MonHocTaoMoi([FromBody]MonHocRequest request)
        {
            return _monHocService.MonHocTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool MonHocXoaBo(Guid ID)
        {
            return _monHocService.MonHocXoaBo(ID);
        }
    }
}





