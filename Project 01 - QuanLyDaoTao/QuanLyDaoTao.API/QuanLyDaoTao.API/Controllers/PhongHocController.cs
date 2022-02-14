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
    public class PhongHocController
    {
        private readonly IPhongHocService _PhongHocService;
        public PhongHocController(IPhongHocService PhongHocService)
        {
            _PhongHocService = PhongHocService;
        }
        [HttpGet]
        public IEnumerable<PhongHocResponse> PhongHocDanhSach(Guid? ID)
        {
            return _PhongHocService.PhongHocDanhSach(ID);
        }
        [HttpGet("{id}")]
        public PhongHocResponse PhongHocLayID(Guid ID)
        {
            return _PhongHocService.PhongHocLayID(ID);
        }
        [HttpPut]
        public int PhongHocChinhSua([FromBody] PhongHocRequest request)
        {
            return _PhongHocService.PhongHocChinhSua(request);
        }
        [HttpPost]
        public int PhongHocTaoMoi([FromBody] PhongHocRequest request)
        {
            return _PhongHocService.PhongHocTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool PhongHocXoaBo(Guid ID)
        {
            return _PhongHocService.PhongHocXoaBo(ID);
        }

    }
}
