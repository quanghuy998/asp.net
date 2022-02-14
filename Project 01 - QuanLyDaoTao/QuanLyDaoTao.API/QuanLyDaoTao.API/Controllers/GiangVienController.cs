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
    public class GiangVienController
    {
        private readonly IGiangVienService _GiangVienService;
        public GiangVienController(IGiangVienService GiangVienService)
        {
            _GiangVienService = GiangVienService;
        }
        [HttpGet]
        public IEnumerable<GiangVienResponse> GiangVienDanhSach(Guid? ID)
        {
            return _GiangVienService.GiangVienDanhSach(ID);
        }
        [HttpGet("{id}")]
        public GiangVienResponse GiangVienLayID(Guid ID)
        {
            return _GiangVienService.GiangVienLayID(ID);
        }
        [HttpPut]
        public int GiangVienChinhSua([FromBody] GiangVienRequest request)
        {
            return _GiangVienService.GiangVienChinhSua(request);
        }
        [HttpPost]
        public int GiangVienTaoMoi([FromBody] GiangVienRequest request)
        {
            return _GiangVienService.GiangVienTaoMoi(request);
        }
        [HttpDelete("{id}")]
        public bool GiangVienXoaBo(Guid ID)
        {
            return _GiangVienService.GiangVienXoaBo(ID);
        }
    }
}
