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
    public class DMMonHocController
    {
        private readonly IDMMonHocService _DMMonHocService;
        public DMMonHocController(IDMMonHocService DMMonHocService)
        {
            _DMMonHocService = DMMonHocService;
        }
        [HttpGet]
        public IEnumerable<DMMonHocResponse> DMMonHocDanhSach(Guid? ID)
        {
            return _DMMonHocService.DMMonHocDanhSach(ID);
        }
        [HttpGet("{id}")]
        public DMMonHocResponse DMMonHocLayID(Guid ID)
        {
            return _DMMonHocService.DMMonHocLayID(ID);
        }
        [HttpPut]
        public int DMMonHocChinhSua([FromBody] DMMonHocRequest request)
        {
            return _DMMonHocService.DMMonHocChinhSua(request);
        }
        [HttpPost]
        public int DMMonHocTaoMoi([FromBody] DMMonHocRequest request)
        {
            return _DMMonHocService.DMMonHocTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool DMMonHocXoaBo(Guid ID)
        {
            return _DMMonHocService.DMMonHocXoaBo(ID);
        }

    }
}
